using ABCCoffee.BUS;
using ABCCoffee.DTO;
using ABCCoffee.GUI.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCCoffee.GUI.UserControls
{
    public partial class UC_Order : UserControl
    {


        private Button currentButton = null;
        private AccountDTO currentAccount;
        public UC_Order(AccountDTO acc)
        {
            InitializeComponent();
            currentAccount = acc;
        }

        private void UC_Order_Load(object sender, EventArgs e)
        {
            LoadTableList();
            LoadCategory();
            LoadFood();
        }
        private void LoadTableList()
        {
            try
            {
                List<TableDTO> tables = TableBUS.Instance.GetTableList();
                tlpTableList.Controls.Clear();
                foreach (TableDTO table in tables)
                {
                    Button button = new Button()
                    {
                        Dock = DockStyle.Fill,
                        BackColor = Color.SteelBlue,
                        Text = table.TableName,
                        Margin = new Padding(10),
                        ImageList = statusIconList,
                        Tag = table,
                        ImageAlign = ContentAlignment.TopLeft
                    };
                    button.Click += btn_Click;

                    switch (table.TableStatus)
                    {
                        case "Có người":
                            button.ImageIndex = 0; // show "Có người" icon
                            break;
                        default:
                            button.ImageIndex = -1; // No icon
                            break;
                    }

                    tlpTableList.Controls.Add(button);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading table list: " + ex.Message);
            }
        }
        private void LoadCategory()
        {
            try
            {
                cbCategory.DataSource = FoodBUS.Instance.GetCategoryList();
                cbCategory.DisplayMember = "Category";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading category list: " + ex.Message);
            }
        }

        private void LoadFood()
        {
            try
            {
                cbFood.DataSource = FoodBUS.Instance.GetAllFoods();
                cbFood.DisplayMember = "FoodName";
                cbFood.ValueMember = "FoodID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading food list: " + ex.Message);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;

            // Check if seleted button is different from current button
            if (clickedBtn != currentButton)
            {
                if (currentButton != null)
                {
                    if ((currentButton.Tag as TableDTO).TableStatus == "Có người")
                    {
                        currentButton.ImageIndex = 0; // show "Có người" icon
                    }
                    else
                    {
                        currentButton.ImageIndex = -1; // Remove icon
                    }
                }
            }

            currentButton = clickedBtn;

            currentButton.ImageIndex = 1; // Show "Đang chọn" icon

            int tableID = (currentButton.Tag as TableDTO).TableID;
            ShowOrderDetail(tableID);
        }

        private bool ShowOrderDetail(int tableID)
        {
            // remove current data source
            dgvOrderDetail.DataSource = null;

            // Get Unchecked Order ID by Table ID
            int orderID = OrderBUS.Instance.GetUnCheckedOrderIDByTableID(tableID);

            // Get Order Details by Order ID
            DataTable dt = OrderDetailBUS.Instance.GetOrderDetailByOrderID(orderID);

            if (dt.Rows.Count == 0)
            {
                return false;
            }
            dgvOrderDetail.DataSource = dt;
            // Set up DataGridView columns
            dgvOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetail.Columns["FoodName"].HeaderText = "Tên món";
            dgvOrderDetail.Columns["Price"].HeaderText = "Đơn giá";
            dgvOrderDetail.Columns["FoodID"].HeaderText = "Mã món";
            dgvOrderDetail.Columns["Quantity"].HeaderText = "Số lượng";

            dgvOrderDetail.Columns[0].FillWeight = 15;
            dgvOrderDetail.Columns[1].FillWeight = 40;
            dgvOrderDetail.Columns[2].FillWeight = 20;
            dgvOrderDetail.Columns[3].FillWeight = 25;

            // Calculate total price
            decimal totalPrice = 0;
            foreach (DataRow row in dt.Rows)
            {
                decimal price = Convert.ToDecimal(row["Price"]);
                int quantity = Convert.ToInt32(row["Quantity"]);
                totalPrice += price * quantity * (1 - nudDiscount.Value / 100);
            }

            tbTotal.Text = totalPrice.ToString();

            return true;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if (cbCategory.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn món hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nudFoodAmount.Value == 0)
            {
                MessageBox.Show("Vui lòng số lượng hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TableDTO table = currentButton.Tag as TableDTO;
            int orderID = OrderBUS.Instance.GetUnCheckedOrderIDByTableID(table.TableID);

            if (orderID == -1)
            {
                // Create new order
                OrderBUS.Instance.InsertOrder(table.TableID, currentAccount.AccountName);
                orderID = OrderBUS.Instance.GetUnCheckedOrderIDByTableID(table.TableID);
            }

            // Add order details
            OrderDetailBUS.Instance.InsertOrderDetail(
                orderID,
                Convert.ToInt32(cbFood.SelectedValue),
                (int)nudFoodAmount.Value);

            if (ShowOrderDetail(table.TableID))
            {
                // Turn table status to "Có người"
                (currentButton.Tag as TableDTO).TableStatus = "Có người";
                TableBUS.Instance.UpdateTableID((currentButton.Tag as TableDTO).TableID, "Có người");
            }
            else
            {
                (currentButton.Tag as TableDTO).TableStatus = "Trống";
                TableBUS.Instance.UpdateTableID((currentButton.Tag as TableDTO).TableID, "Trống");
            }
        }

        private void nudDiscount_ValueChanged(object sender, EventArgs e)
        {
            ShowOrderDetail((currentButton.Tag as TableDTO).TableID);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if(dgvOrderDetail.Rows.Count <= 0) {
                MessageBox.Show("Hãy gọi món trước khi thanh toán", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            int orderID = OrderBUS.Instance.GetUnCheckedOrderIDByTableID((currentButton.Tag as TableDTO).TableID);
            OrderBUS.Instance.CheckOut(orderID, (int)nudDiscount.Value, Convert.ToDecimal(tbTotal.Text));

            using (frmInvoiceReport rpt = new frmInvoiceReport(orderID))
            {
                rpt.ShowDialog();
            }
            // Update table status
            (currentButton.Tag as TableDTO).TableStatus = "Trống";
            TableBUS.Instance.UpdateTableID((currentButton.Tag as TableDTO).TableID, "Trống");
            ShowOrderDetail((currentButton.Tag as TableDTO).TableID);
            tbTotal.Text = "0";
            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cbCategory.Text;
            if (category == null)
            {
                return;
            }
            try
            {
                cbFood.DataSource = FoodBUS.Instance.GetFoodByCategory(category);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading food list: " + ex.Message);
            }
        }

    }
}
