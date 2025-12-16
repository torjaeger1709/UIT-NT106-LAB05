namespace LAB05
{
    partial class BT6
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button(); // Nút Đăng xuất
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.txtSmtpPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSmtpServer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtImapPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImapServer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.btnWriteMail = new System.Windows.Forms.Button(); // Nút Soạn thư
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvMails = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.groupBoxLogin.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMails)).BeginInit();
            this.SuspendLayout();

            // --- GroupBox Login ---
            this.groupBoxLogin.Controls.Add(this.btnLogout);
            this.groupBoxLogin.Controls.Add(this.btnLogin);
            this.groupBoxLogin.Controls.Add(this.txtPass);
            this.groupBoxLogin.Controls.Add(this.label2);
            this.groupBoxLogin.Controls.Add(this.txtUser);
            this.groupBoxLogin.Controls.Add(this.label1);
            this.groupBoxLogin.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLogin.Size = new System.Drawing.Size(400, 130);
            this.groupBoxLogin.Text = "1. Đăng nhập";

            // Nút Đăng nhập
            this.btnLogin.Location = new System.Drawing.Point(100, 80);
            this.btnLogin.Size = new System.Drawing.Size(130, 40);
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // Nút Đăng xuất (Mới)
            this.btnLogout.Location = new System.Drawing.Point(240, 80);
            this.btnLogout.Size = new System.Drawing.Size(130, 40);
            this.btnLogout.Text = "ĐĂNG XUẤT";
            this.btnLogout.Enabled = false; 
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // Các TextBox User/Pass giữ nguyên
            this.txtPass.Location = new System.Drawing.Point(100, 50);
            this.txtPass.Size = new System.Drawing.Size(270, 22);
            this.txtPass.PasswordChar = '*';
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Text = "Mật khẩu:";
            this.label2.AutoSize = true;
            this.txtUser.Location = new System.Drawing.Point(100, 20);
            this.txtUser.Size = new System.Drawing.Size(270, 22);
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Text = "Email:";
            this.label1.AutoSize = true;

            // --- GroupBox Settings (Giữ nguyên) ---
            this.groupBoxSettings.Controls.Add(this.txtSmtpPort);
            this.groupBoxSettings.Controls.Add(this.label6);
            this.groupBoxSettings.Controls.Add(this.txtSmtpServer);
            this.groupBoxSettings.Controls.Add(this.label7);
            this.groupBoxSettings.Controls.Add(this.txtImapPort);
            this.groupBoxSettings.Controls.Add(this.label5);
            this.groupBoxSettings.Controls.Add(this.txtImapServer);
            this.groupBoxSettings.Controls.Add(this.label8);
            this.groupBoxSettings.Location = new System.Drawing.Point(420, 12);
            this.groupBoxSettings.Size = new System.Drawing.Size(550, 130);
            this.groupBoxSettings.Text = "2. Cấu hình Server";

            // Setup các textbox settings như cũ...
            this.txtSmtpPort.Location = new System.Drawing.Point(430, 50);
            this.txtSmtpPort.Size = new System.Drawing.Size(100, 22);
            this.txtSmtpPort.Text = "465";
            this.label6.Location = new System.Drawing.Point(380, 53);
            this.label6.Text = "Port:";
            this.label6.AutoSize = true;
            this.txtSmtpServer.Location = new System.Drawing.Point(110, 50);
            this.txtSmtpServer.Size = new System.Drawing.Size(250, 22);
            this.txtSmtpServer.Text = "smtp.gmail.com";
            this.label7.Location = new System.Drawing.Point(10, 53);
            this.label7.Text = "SMTP:";
            this.label7.AutoSize = true;
            this.txtImapPort.Location = new System.Drawing.Point(430, 20);
            this.txtImapPort.Size = new System.Drawing.Size(100, 22);
            this.txtImapPort.Text = "993";
            this.label5.Location = new System.Drawing.Point(380, 23);
            this.label5.Text = "Port:";
            this.label5.AutoSize = true;
            this.txtImapServer.Location = new System.Drawing.Point(110, 20);
            this.txtImapServer.Size = new System.Drawing.Size(250, 22);
            this.txtImapServer.Text = "imap.gmail.com";
            this.label8.Location = new System.Drawing.Point(10, 23);
            this.label8.Text = "IMAP:";
            this.label8.AutoSize = true;

            // --- GroupBox List (Inbox) ---
            this.groupBoxList.Controls.Add(this.btnWriteMail);
            this.groupBoxList.Controls.Add(this.btnRefresh);
            this.groupBoxList.Controls.Add(this.dgvMails);
            this.groupBoxList.Location = new System.Drawing.Point(12, 160);
            this.groupBoxList.Size = new System.Drawing.Size(960, 380); // Kéo rộng ra vì bỏ Send box
            this.groupBoxList.Text = "3. Hộp thư đến";

            // Nút Soạn thư (Mới)
            this.btnWriteMail.Location = new System.Drawing.Point(830, 21);
            this.btnWriteMail.Size = new System.Drawing.Size(120, 30);
            this.btnWriteMail.Text = "VIẾT MAIL";
            this.btnWriteMail.BackColor = System.Drawing.Color.LightGreen;
            this.btnWriteMail.Click += new System.EventHandler(this.btnWriteMail_Click);

            this.btnRefresh.Location = new System.Drawing.Point(10, 21);
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.dgvMails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo, this.colFrom, this.colSubject, this.colDate});
            this.dgvMails.Location = new System.Drawing.Point(10, 60);
            this.dgvMails.Size = new System.Drawing.Size(940, 310);
            
            // Cột GridView
            this.colNo.HeaderText = "#"; this.colNo.Width = 50;
            this.colFrom.HeaderText = "From"; this.colFrom.Width = 200;
            this.colSubject.HeaderText = "Subject"; this.colSubject.Width = 450; // Rộng hơn
            this.colDate.HeaderText = "Date"; this.colDate.Width = 150;

            // Form Main
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.groupBoxLogin);
            this.Name = "Bai6";
            this.Text = "Lab 5 - Bài 6: Email Client Pro";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.groupBoxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMails)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        // Khai báo biến
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.TextBox txtSmtpPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSmtpServer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtImapPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImapServer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnWriteMail;
        private System.Windows.Forms.DataGridView dgvMails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
    }
}