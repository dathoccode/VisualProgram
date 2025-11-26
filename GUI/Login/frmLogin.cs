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

namespace ABCCoffee.GUI.Login
{
    public partial class frmLogin : Form
    {
        public AccountDTO LoginAccount { get; private set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AccountDTO account = new AccountDTO(tbAccName.Text, tbAccPass.Text);
            try
            {
                if (AccountBUS.Instance.LoginValidation(account.AccountName, account.Password))
                {
                    LoginAccount = AccountBUS.Instance.GetAccountByAccountName(account.AccountName);
                    if (LoginAccount == null)
                    {
                        MessageBox.Show("Tài khoản không tồn tại!");
                        return;
                    }

                    if (account.Password != LoginAccount.Password)
                    {
                        MessageBox.Show("Sai mật khẩu. Vui lòng thử lại.");
                        return;
                    }

                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
