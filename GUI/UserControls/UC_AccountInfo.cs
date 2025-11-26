using ABCCoffee.BUS;
using ABCCoffee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCCoffee.GUI.UserControls
{
    public partial class UC_AccountInfo : UserControl
    {
        AccountDTO LoginAccount;
        private string defaultImagePath = Path.Combine(Application.StartupPath, "Resources", "avatar_default.jpg");

        public UC_AccountInfo(AccountDTO acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }
        private void UC_AccountInfo_Load(object sender, EventArgs e)
        {
            lblAccontName.Text = LoginAccount.AccountName;
            lblRole.Text = LoginAccount.Role;
            tbDisplayName.Text = LoginAccount.DisplayName;
            tbPassword.Text = LoginAccount.Password;
            tbPhone.Text = LoginAccount.Phone != null ? LoginAccount.Phone : "";
            dtpDateOfBirth.Value = LoginAccount.DateOfBirth != null ? DateTime.Parse(LoginAccount.DateOfBirth) : DateTime.Now;
            cbGender.Text = LoginAccount.Gender != null ? LoginAccount.Gender : "Khác";
            if ( !String.IsNullOrEmpty(LoginAccount.ImagePath))
            {
                pbAccountImage.Image = Image.FromFile(LoginAccount.ImagePath);
            }
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                ofd.Title = "Chọn ảnh để tải lên";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string sourceFilePath = ofd.FileName;

                    // Giải phóng ảnh cũ (nếu có)
                    pbAccountImage.Image?.Dispose();
                    pbAccountImage.Image = null;

                    // Load ảnh KHÔNG KHÓA FILE
                    using (FileStream fs = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
                    {
                        pbAccountImage.Image = Image.FromStream(fs);
                    }

                    // Thư mục đích
                    string folderPath = @"C:\University\5thSemester\VisualProgramming\Project\ABCCoffee\Resources\";

                    string fileName = LoginAccount.AccountName + "image" + Path.GetExtension(sourceFilePath);
                    string desPath = Path.Combine(folderPath, fileName);

                    // Copy file (giờ sẽ không bị lỗi nữa)
                    File.Copy(sourceFilePath, desPath, true);

                    LoginAccount.ImagePath = desPath;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LoginAccount.DisplayName = tbDisplayName.Text;
            LoginAccount.Phone = tbPhone.Text;
            LoginAccount.DateOfBirth = dtpDateOfBirth.Value.ToString("yyyy-MM-dd");
            LoginAccount.Password = tbPassword.Text;
            LoginAccount.Gender = cbGender.Text;
            LoginAccount.ImagePath = LoginAccount.ImagePath ?? defaultImagePath;
            if (AccountBUS.Instance.UpdateAccount(LoginAccount) == true)
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
