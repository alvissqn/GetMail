namespace Getmail
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_remem = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstEmail = new System.Windows.Forms.ListView();
            this.colgTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtxtbody = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstCode = new System.Windows.Forms.ListView();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.btnGetMail = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_remem);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng Nhập Mail";
            // 
            // chk_remem
            // 
            this.chk_remem.AutoSize = true;
            this.chk_remem.Location = new System.Drawing.Point(27, 135);
            this.chk_remem.Name = "chk_remem";
            this.chk_remem.Size = new System.Drawing.Size(126, 17);
            this.chk_remem.TabIndex = 3;
            this.chk_remem.Text = "Remember Password";
            this.chk_remem.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(226, 27);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 87);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(74, 94);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(145, 20);
            this.txtPass.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(74, 60);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(145, 20);
            this.txtUser.TabIndex = 1;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(74, 27);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(145, 20);
            this.txtServer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "PassWord :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserName :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstEmail);
            this.groupBox3.Location = new System.Drawing.Point(12, 181);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 214);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Email";
            // 
            // lstEmail
            // 
            this.lstEmail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colgTitle});
            this.lstEmail.FullRowSelect = true;
            this.lstEmail.GridLines = true;
            this.lstEmail.Location = new System.Drawing.Point(6, 19);
            this.lstEmail.Name = "lstEmail";
            this.lstEmail.Size = new System.Drawing.Size(247, 189);
            this.lstEmail.TabIndex = 0;
            this.lstEmail.UseCompatibleStateImageBehavior = false;
            this.lstEmail.View = System.Windows.Forms.View.Details;
            this.lstEmail.SelectedIndexChanged += new System.EventHandler(this.lstEmail_SelectedIndexChanged);
            // 
            // colgTitle
            // 
            this.colgTitle.Text = "Tiêu Đề";
            this.colgTitle.Width = 247;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtxtbody);
            this.groupBox4.Location = new System.Drawing.Point(12, 401);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(562, 231);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nội Dung Mail";
            // 
            // rtxtbody
            // 
            this.rtxtbody.Location = new System.Drawing.Point(6, 19);
            this.rtxtbody.Name = "rtxtbody";
            this.rtxtbody.Size = new System.Drawing.Size(550, 206);
            this.rtxtbody.TabIndex = 0;
            this.rtxtbody.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstCode);
            this.groupBox5.Location = new System.Drawing.Point(291, 181);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(283, 214);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh Sách Code";
            // 
            // lstCode
            // 
            this.lstCode.Location = new System.Drawing.Point(7, 19);
            this.lstCode.Name = "lstCode";
            this.lstCode.Size = new System.Drawing.Size(270, 189);
            this.lstCode.TabIndex = 0;
            this.lstCode.UseCompatibleStateImageBehavior = false;
            this.lstCode.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTrangthai.Location = new System.Drawing.Point(0, 635);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.ReadOnly = true;
            this.txtTrangthai.Size = new System.Drawing.Size(586, 20);
            this.txtTrangthai.TabIndex = 5;
            // 
            // btnGetMail
            // 
            this.btnGetMail.Location = new System.Drawing.Point(368, 31);
            this.btnGetMail.Name = "btnGetMail";
            this.btnGetMail.Size = new System.Drawing.Size(75, 23);
            this.btnGetMail.TabIndex = 6;
            this.btnGetMail.Text = "Get Email";
            this.btnGetMail.UseVisualStyleBackColor = true;
            this.btnGetMail.Click += new System.EventHandler(this.btnGetMail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 655);
            this.Controls.Add(this.btnGetMail);
            this.Controls.Add(this.txtTrangthai);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chk_remem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lstEmail;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtxtbody;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView lstCode;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.Button btnGetMail;
        private System.Windows.Forms.ColumnHeader colgTitle;
    }
}

