using ABCCoffee.BUS;
using ABCCoffee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System.IO;
using ABCCoffee.DAL;

namespace ABCCoffee.GUI.UserControls
{
    public partial class UC_Manage : UserControl
    {
        public UC_Manage()
        {
            InitializeComponent();
        }

        private void tpAccount_Enter(object sender, EventArgs e)
        {
            dgvAccountList.DataSource = AccountBUS.Instance.GetAllAccounts();
            dgvAccountList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccountList.Columns["AccountName"].HeaderText = "Tên tài khoản";
            dgvAccountList.Columns["DisplayName"].HeaderText = "Họ và tên";
            dgvAccountList.Columns["Gender"].HeaderText = "Giới tính";
            dgvAccountList.Columns["AccountPassword"].HeaderText = "Mật khẩu";
            dgvAccountList.Columns["Phone"].HeaderText = "Số điện thoại";
            dgvAccountList.Columns["DateOfBirth"].HeaderText = "Ngày sinh";
            dgvAccountList.Columns["AccountRole"].HeaderText = "Vai trò";
            dgvAccountList.Columns["Gender"].HeaderText = "Giới tính";
            dgvAccountList.Columns["ImagePath"].Visible = false;
        }

        private void UC_Manage_Load(object sender, EventArgs e)
        {
            tpAccount_Enter(sender, e);
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(tbAccountName.Text) ||
                string.IsNullOrWhiteSpace(tbDisplayName.Text) ||
                string.IsNullOrWhiteSpace(tbPassword.Text) ||
                string.IsNullOrWhiteSpace(tbPhone.Text) ||
                cbRole.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (AccountBUS.Instance.GetAccountByAccountName(tbAccountName.Text) != null)
            {
                MessageBox.Show("Đã tồn tại tên tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbPhone.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại gồm 10 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add new account
            AccountDTO newAccount = new AccountDTO
            {
                AccountName = tbAccountName.Text.Trim(),
                DisplayName = tbDisplayName.Text.Trim(),
                Password = tbPassword.Text.Trim(),
                Phone = tbPhone.Text.Trim(),
                Gender = cbGender.Text.ToString(),
                DateOfBirth = dtpDateOfBirth.Value.ToString(),
                Role = cbRole.SelectedItem.ToString()
            };

            bool isAdded = AccountBUS.Instance.InsertAccount(newAccount);
            if (isAdded)
            {
                MessageBox.Show("Thêm tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnReloadAccount_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReloadAccount_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            tbAccountName.Text = "";
            tbAccountName.ReadOnly = false;
            tbDisplayName.Text = "";
            tbPassword.Text = "";
            tbPhone.Text = "";
            dtpDateOfBirth.Value = DateTime.Today;
            cbRole.Text = "";
            dgvAccountList.DataSource = AccountBUS.Instance.GetAllAccounts();
            dgvAccountList.ClearSelection();
        }

        private void dgvAccountList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return; //dont accept header row
            // Show info of selected account
            tbAccountName.Text = dgvAccountList.Rows[rowIndex].Cells["AccountName"].Value.ToString() ?? "";
            tbAccountName.ReadOnly = true;
            tbDisplayName.Text = dgvAccountList.Rows[rowIndex].Cells["DisplayName"].Value.ToString() ?? "";
            tbPassword.Text = dgvAccountList.Rows[rowIndex].Cells["AccountPassword"].Value.ToString() ?? "";
            tbPhone.Text = dgvAccountList.Rows[rowIndex].Cells["Phone"].Value.ToString() ?? "";
            cbGender.Text = dgvAccountList.Rows[rowIndex].Cells["Gender"].Value.ToString() ?? "";
            dtpDateOfBirth.Value = Convert.ToDateTime(dgvAccountList.Rows[rowIndex].Cells["DateOfBirth"].Value);
            cbRole.SelectedItem = dgvAccountList.Rows[rowIndex].Cells["AccountRole"].Value.ToString();
        }

        private void btnRemoveAccount_Click(object sender, EventArgs e)
        {
            bool isDeleted = AccountBUS.Instance.DeleteAccount(tbAccountName.Text.Trim());
            if (isDeleted)
            {
                MessageBox.Show("Xóa tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnReloadAccount_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (AccountBUS.Instance.GetAccountByAccountName(tbAccountName.Text) == null)
            {
                MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AccountDTO newAccount = new AccountDTO
            {
                AccountName = tbAccountName.Text.Trim(),
                DisplayName = tbDisplayName.Text.Trim(),
                Password = tbPassword.Text.Trim(),
                Phone = tbPhone.Text.Trim(),
                Gender = cbGender.Text.ToString(),
                DateOfBirth = dtpDateOfBirth.Value.ToString(),
                Role = cbRole.SelectedItem.ToString(),
                ImagePath = ""
            };
            bool isEdited = AccountBUS.Instance.UpdateAccount(newAccount);
            if (isEdited)
            {
                MessageBox.Show("Cập nhật tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnReloadAccount_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tpTable_Enter(object sender, EventArgs e)
        {
            dgvTableList.DataSource = TableBUS.Instance.GetAllTables();
            dgvTableList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTableList.Columns["TableID"].HeaderText = "Mã bàn";
            dgvTableList.Columns["TableName"].HeaderText = "Tên bàn";
            dgvTableList.Columns["TableStatus"].Visible = false;
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            TableBUS.Instance.InsertTable();
            dgvTableList.DataSource = TableBUS.Instance.GetAllTables();
        }

        private void btnRemoveTable_Click(object sender, EventArgs e)
        {
            if (dgvTableList.SelectedRows.Count > 0)
            {
                int tableID = Convert.ToInt32(dgvTableList.SelectedRows[0].Cells["TableID"].Value);
                var result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa bàn có mã {tableID} không?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool isDeleted = TableBUS.Instance.DeleteTable(tableID);
                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa bàn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvTableList.DataSource = TableBUS.Instance.GetAllTables();
                    }
                    else
                    {
                        MessageBox.Show("Xóa bàn thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bàn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvAccountList.ColumnCount; i++) 
            {
                application.Cells[1, i + 1] = dgvAccountList.Columns[i].HeaderText;
            }
            for(int i = 0; i< dgvAccountList.RowCount; i++)
            {
                for(int j = 0; j < dgvAccountList.ColumnCount; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvAccountList.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Export Excel";
            saveDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if(saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveDialog.FileName);
                    MessageBox.Show("Lưu file thành công");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTxt = tbSearch.Text.Trim();
            string query;
            switch (cbSearchBy.Text)
            {
                case "Tài khoản":
                    query = "USP_SearchByAccountName @AccountName";
                    break;
                case "Số điện thoại":
                    query = "USP_SearchByPhone @Phone";
                    break;
                case "Họ và tên":
                    query = "USP_SearchByDisplayName @DisplayName";
                    break;
                default:
                    query = "USP_SearchByAccountName @AccountName";
                    break;
            }
            dgvAccountList.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { searchTxt });
        }

        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

    }
}
