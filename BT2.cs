//vulw teil dfpy ohqk
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MailKit.Net.Imap;
using MailKit;
using MimeKit;

namespace LAB05
{
    public partial class BT2 : Form
    {
        public BT2()
        {
            InitializeComponent();
            // Cấu hình ListView khi khởi chạy
            SetupListView();
        }

        // Cấu hình các cột cho ListView
        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("Email (Subject)", 300);
            listView1.Columns.Add("From", 200);
            listView1.Columns.Add("Thời gian", 150);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // 1. Kiểm tra đầu vào
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Email và Mật khẩu ứng dụng!", "Thông báo");
                return;
            }



            try
            {
                using (var client = new ImapClient())
                {
                    // 2. Kết nối tới Server IMAP của Gmail (Port 993, SSL = true)
                    client.Connect("imap.gmail.com", 993, true);

                    // 3. Xác thực bằng Email và App Password
                    client.Authenticate(textBox1.Text, textBox2.Text);

                    // 4. Mở hộp thư Inbox
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    // 5. Hiển thị số lượng mail lên label
                    label5.Text = inbox.Count.ToString();      // Total
                    label6.Text = inbox.Recent.ToString();     // Recent

                    // 6. Xóa danh sách cũ và nạp 10 mail mới nhất vào ListView
                    listView1.Items.Clear();

                    // Lấy các mail từ vị trí cuối cùng ngược lên
                    for (int i = inbox.Count - 1; i >= Math.Max(0, inbox.Count - 10); i--)
                    {
                        var message = inbox.GetMessage(i);

                        ListViewItem item = new ListViewItem(message.Subject); // Cột Subject
                        item.SubItems.Add(message.From.ToString());           // Cột From
                        item.SubItems.Add(message.Date.DateTime.ToString());  // Cột Date

                        listView1.Items.Add(item);
                    }

                    client.Disconnect(true);
                    MessageBox.Show("Đăng nhập và lấy dữ liệu thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi kết nối");
            }
        }
    }
}