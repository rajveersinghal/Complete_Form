namespace LoginForm
{
    partial class f_pass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_pass));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFsend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFCode = new System.Windows.Forms.TextBox();
            this.txtFEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFverify = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnFverify);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnFsend);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFCode);
            this.groupBox1.Controls.Add(this.txtFEmail);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(322, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1015, 580);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnFsend
            // 
            this.btnFsend.BackColor = System.Drawing.Color.Gold;
            this.btnFsend.FlatAppearance.BorderSize = 0;
            this.btnFsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFsend.Location = new System.Drawing.Point(660, 246);
            this.btnFsend.Name = "btnFsend";
            this.btnFsend.Size = new System.Drawing.Size(191, 51);
            this.btnFsend.TabIndex = 9;
            this.btnFsend.Text = "Send";
            this.btnFsend.UseVisualStyleBackColor = false;
            this.btnFsend.Click += new System.EventHandler(this.btnFsend_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(559, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter Email";
            // 
            // txtFCode
            // 
            this.txtFCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtFCode.ForeColor = System.Drawing.Color.Gold;
            this.txtFCode.Location = new System.Drawing.Point(565, 394);
            this.txtFCode.Name = "txtFCode";
            this.txtFCode.PasswordChar = '*';
            this.txtFCode.Size = new System.Drawing.Size(413, 45);
            this.txtFCode.TabIndex = 2;
            // 
            // txtFEmail
            // 
            this.txtFEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtFEmail.ForeColor = System.Drawing.Color.Gold;
            this.txtFEmail.Location = new System.Drawing.Point(565, 186);
            this.txtFEmail.Name = "txtFEmail";
            this.txtFEmail.Size = new System.Drawing.Size(413, 45);
            this.txtFEmail.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Back";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(561, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter Code";
            // 
            // btnFverify
            // 
            this.btnFverify.BackColor = System.Drawing.Color.Gold;
            this.btnFverify.FlatAppearance.BorderSize = 0;
            this.btnFverify.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFverify.Location = new System.Drawing.Point(660, 445);
            this.btnFverify.Name = "btnFverify";
            this.btnFverify.Size = new System.Drawing.Size(191, 51);
            this.btnFverify.TabIndex = 12;
            this.btnFverify.Text = "Verify";
            this.btnFverify.UseVisualStyleBackColor = false;
            this.btnFverify.Click += new System.EventHandler(this.btnFverify_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(621, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "Send Code Via Email";
            // 
            // f_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1659, 804);
            this.Controls.Add(this.groupBox1);
            this.Name = "f_pass";
            this.Text = "f_pass";
            this.Load += new System.EventHandler(this.f_pass_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFsend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFCode;
        private System.Windows.Forms.TextBox txtFEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFverify;
    }
}