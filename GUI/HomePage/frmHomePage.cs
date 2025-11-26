using ABCCoffee.BUS;
using ABCCoffee.DTO;
using ABCCoffee.GUI.UserControls;
using System;
using System.Windows.Forms;

namespace ABCCoffee.GUI.HomePage
{
    public partial class frmHomePage : Form
    {
        public AccountDTO LogginAccount { get; private set; }

        public frmHomePage(AccountDTO acc)
        {
            InitializeComponent();
            LogginAccount = acc;
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            if (LogginAccount.Role == "Quản lý")
            {
                btnCheckIn.Visible = false;
            }
            else
            {
                btnManage.Visible = false;
                btnStatistic.Visible = false;
            }
            LoadUserControl(new UC_Order(LogginAccount));
        }

        private void LoadUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnOrderInfo_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Order(LogginAccount));
        }

        private void btnAccountInfo_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_AccountInfo(LogginAccount));
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Manage());
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Statistic());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (AccountBUS.Instance.CheckIn(LogginAccount.AccountName))
            {
                MessageBox.Show("Chấm công thành công!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hôm nay bạn đã chấm công rồi!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
