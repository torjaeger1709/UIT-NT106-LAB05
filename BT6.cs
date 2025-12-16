using System;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit;

namespace LAB05
{
    public partial class BT6 : Form
    {
        private ImapClient _imapClient = new ImapClient();

        public BT6()
        {
            InitializeComponent();
            ToggleControls(false); // Mặc định khóa
        }

        // Hàm bật tắt nút
        private void ToggleControls(bool isLogin)
        {
            btnRefresh.Enabled = isLogin;
            btnWriteMail.Enabled = isLogin;
            btnLogout.Enabled = isLogin;
            
            // Khi đã login thì khóa ô nhập user/pass
            btnLogin.Enabled = !isLogin;
            txtUser.ReadOnly = isLogin;
            txtPass.ReadOnly = isLogin;
            txtImapServer.ReadOnly = isLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();
            string imapServer = txtImapServer.Text.Trim();
            int imapPort = int.Parse(txtImapPort.Text.Trim());

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Nhập thiếu thông tin!");
                return;
            }

            try
            {
                btnLogin.Text = "Đang kết nối...";
                
                if (!_imapClient.IsConnected)
                {
                    _imapClient.Connect(imapServer, imapPort, true);
                    _imapClient.Authenticate(email, password);
                }

                MessageBox.Show("Đăng nhập thành công!");
                btnLogin.Text = "Đã đăng nhập";
                ToggleControls(true); // Mở khóa chức năng
                LoadMailList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                btnLogin.Text = "ĐĂNG NHẬP";
                ToggleControls(false);
            }
        }

        // --- CHỨC NĂNG ĐĂNG XUẤT ---
        private void btnLogout_Click(object sender, EventArgs e)
        {
            try 
            {
                if (_imapClient.IsConnected)
                {
                    _imapClient.Disconnect(true);
                }
                
                // Xóa danh sách mail
                dgvMails.Rows.Clear();
                
                // Reset giao diện
                btnLogin.Text = "ĐĂNG NHẬP";
                txtPass.Clear(); // Xóa mật khẩu cho an toàn
                ToggleControls(false); // Khóa lại
                
                MessageBox.Show("Đã đăng xuất!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng xuất: " + ex.Message);
            }
        }

        // --- MỞ FORM GỬI MAIL ---
        private void btnWriteMail_Click(object sender, EventArgs e)
        {
            // Lấy thông tin hiện tại để truyền sang form kia
            string user = txtUser.Text;
            string pass = txtPass.Text;
            string smtpServer = txtSmtpServer.Text;
            int smtpPort = int.Parse(txtSmtpPort.Text);

            // Tạo form mới và hiển thị lên
            SendMailForm sendForm = new SendMailForm(user, pass, smtpServer, smtpPort);
            sendForm.ShowDialog(); // ShowDialog để chặn form chính lại khi đang gửi
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMailList();
        }

        private void LoadMailList()
        {
            if (!_imapClient.IsConnected) return;

            try
            {
                var inbox = _imapClient.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                dgvMails.Rows.Clear();

                int limit = 10;
                int count = inbox.Count;
                
                for (int i = count - 1; i >= 0 && i >= count - limit; i--)
                {
                    var message = inbox.GetMessage(i);
                    dgvMails.Rows.Add(i, message.From.ToString(), message.Subject, message.Date.DateTime.ToString("dd/MM HH:mm"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải mail: " + ex.Message);
            }
        }
    }
}