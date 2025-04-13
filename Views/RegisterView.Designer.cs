namespace web_MPham.Views
{
    partial class RegisterView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHVT = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnDKy = new System.Windows.Forms.Button();
            this.ckbKichhoat = new System.Windows.Forms.CheckBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên tài khoản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mật khẩu";
            // 
            // txtHVT
            // 
            this.txtHVT.Location = new System.Drawing.Point(246, 81);
            this.txtHVT.Name = "txtHVT";
            this.txtHVT.Size = new System.Drawing.Size(198, 22);
            this.txtHVT.TabIndex = 6;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(246, 196);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(198, 22);
            this.txtusername.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(246, 168);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(198, 22);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(246, 140);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(198, 22);
            this.txtSDT.TabIndex = 9;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(246, 224);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(198, 22);
            this.txtpassword.TabIndex = 11;
            // 
            // btnDKy
            // 
            this.btnDKy.Location = new System.Drawing.Point(281, 301);
            this.btnDKy.Name = "btnDKy";
            this.btnDKy.Size = new System.Drawing.Size(75, 23);
            this.btnDKy.TabIndex = 12;
            this.btnDKy.Text = "Đăng ký";
            this.btnDKy.UseVisualStyleBackColor = true;
            this.btnDKy.Click += new System.EventHandler(this.btnDKy_Click);
            // 
            // ckbKichhoat
            // 
            this.ckbKichhoat.AutoSize = true;
            this.ckbKichhoat.Location = new System.Drawing.Point(132, 269);
            this.ckbKichhoat.Name = "ckbKichhoat";
            this.ckbKichhoat.Size = new System.Drawing.Size(140, 20);
            this.ckbKichhoat.TabIndex = 14;
            this.ckbKichhoat.Text = "Kích hoạt tài khoản";
            this.ckbKichhoat.UseVisualStyleBackColor = true;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(244, 115);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 22);
            this.dtpBirthday.TabIndex = 15;
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.ckbKichhoat);
            this.Controls.Add(this.btnDKy);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtHVT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RegisterView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHVT;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnDKy;
        private System.Windows.Forms.CheckBox ckbKichhoat;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
    }
}