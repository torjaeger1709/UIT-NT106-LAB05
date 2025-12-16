//vulw teil dfpy ohqk
using System;
using System.Windows.Forms;
using MailKit.Net.Pop3; 
using MailKit;
using MimeKit;
using System.Text.RegularExpressions;

namespace LAB05
{
    public partial class BT3 : Form
    {
        public BT3()
        {
            InitializeComponent();
            SetupListView();
        }

        
        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Email (Subject)", 300);
            listView1.Columns.Add("From", 200);
            listView1.Columns.Add("Thời gian", 150);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          


            try
            {
                using (var client = new Pop3Client())
                {
                    
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                    
                    client.Connect("pop.gmail.com", 995, true);

                    
                    client.Authenticate(textBox1.Text, textBox2.Text);

                    
                    int messageCount = client.Count;
                    label5.Text = messageCount.ToString();
                    label6.Text = "N/A"; 

                    
                    listView1.Items.Clear();
                    for (int i = messageCount - 1; i >= Math.Max(0, messageCount - 10); i--)
                    {
                        var message = client.GetMessage(i);
                        ListViewItem item = new ListViewItem(message.Subject);
                        item.SubItems.Add(message.From.ToString());
                        item.SubItems.Add(message.Date.DateTime.ToString());
                        listView1.Items.Add(item);
                    }

                    client.Disconnect(true);
                    MessageBox.Show("Lấy danh sách mail qua POP3 thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi kết nối POP3");
            }
        }
    }
}