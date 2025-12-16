using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace LAB05
{
    public partial class BT1 : Form
    {
        public BT1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Email gửi và nhận!");
                return;
            }

            try
            {
               
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(textBox1.Text);
                mail.To.Add(textBox2.Text);
                mail.Subject = textBox3.Text;
                mail.Body = richTextBox1.Text;

                
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true; 

                
                smtpClient.Credentials = new NetworkCredential(textBox1.Text, "vulw teil dfpy ohqk");

                
                smtpClient.Send(mail);

                MessageBox.Show("Gửi mail thành công qua System.Net.Mail!", "Thông báo");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống");
            }
        }
    }
}