using System;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;

namespace LAB05
{
    public partial class SendMailForm : Form
    {
        // Biến lưu thông tin đăng nhập được truyền từ Form chính qua
        string _user, _pass, _smtpServer;
        int _smtpPort;

        public SendMailForm(string user, string pass, string smtpServer, int smtpPort)
        {
            InitializeComponent();
            _user = user;
            _pass = pass;
            _smtpServer = smtpServer;
            _smtpPort = smtpPort;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Me", _user));
                message.To.Add(new MailboxAddress("", txtTo.Text));
                message.Subject = txtSubject.Text;
                message.Body = new TextPart("plain") { Text = rtbBody.Text };

                using (var client = new SmtpClient())
                {
                    client.Connect(_smtpServer, _smtpPort, true);
                    client.Authenticate(_user, _pass);
                    client.Send(message);
                    client.Disconnect(true);
                }

                MessageBox.Show("Gửi thành công!", "Success");
                this.Close(); // Đóng form sau khi gửi xong
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi mail: " + ex.Message);
            }
        }
    }
}