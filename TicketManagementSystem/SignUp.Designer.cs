namespace TicketManagementSystem
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.lblName = new System.Windows.Forms.Label();
            this.lblSignUpEmail = new System.Windows.Forms.Label();
            this.lblSignUpPassword = new System.Windows.Forms.Label();
            this.lblConSignUpPassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.linkBack = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblName.Location = new System.Drawing.Point(30, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblSignUpEmail
            // 
            this.lblSignUpEmail.AutoSize = true;
            this.lblSignUpEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSignUpEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSignUpEmail.Location = new System.Drawing.Point(30, 133);
            this.lblSignUpEmail.Name = "lblSignUpEmail";
            this.lblSignUpEmail.Size = new System.Drawing.Size(53, 20);
            this.lblSignUpEmail.TabIndex = 1;
            this.lblSignUpEmail.Text = "E-mail";
            // 
            // lblSignUpPassword
            // 
            this.lblSignUpPassword.AutoSize = true;
            this.lblSignUpPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSignUpPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSignUpPassword.Location = new System.Drawing.Point(30, 180);
            this.lblSignUpPassword.Name = "lblSignUpPassword";
            this.lblSignUpPassword.Size = new System.Drawing.Size(78, 20);
            this.lblSignUpPassword.TabIndex = 2;
            this.lblSignUpPassword.Text = "Password";
            // 
            // lblConSignUpPassword
            // 
            this.lblConSignUpPassword.AutoSize = true;
            this.lblConSignUpPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblConSignUpPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConSignUpPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblConSignUpPassword.Location = new System.Drawing.Point(30, 233);
            this.lblConSignUpPassword.Name = "lblConSignUpPassword";
            this.lblConSignUpPassword.Size = new System.Drawing.Size(140, 20);
            this.lblConSignUpPassword.TabIndex = 3;
            this.lblConSignUpPassword.Text = "Confirm Password";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtName.Location = new System.Drawing.Point(188, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtEmail.Location = new System.Drawing.Point(188, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPassword.Location = new System.Drawing.Point(188, 180);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(177, 22);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtConfirmPassword.Location = new System.Drawing.Point(188, 233);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(177, 22);
            this.txtConfirmPassword.TabIndex = 7;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(266, 278);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(99, 33);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // linkBack
            // 
            this.linkBack.AutoSize = true;
            this.linkBack.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkBack.Location = new System.Drawing.Point(510, 404);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(51, 24);
            this.linkBack.TabIndex = 9;
            this.linkBack.TabStop = true;
            this.linkBack.Text = "Back";
            this.linkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHome_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 47);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPhoneNumber.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPhoneNumber.Location = new System.Drawing.Point(188, 84);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(177, 22);
            this.txtPhoneNumber.TabIndex = 12;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPhoneNumber.Location = new System.Drawing.Point(30, 84);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(119, 20);
            this.lblPhoneNumber.TabIndex = 11;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblPhoneNumber);
            this.groupBox1.Controls.Add(this.lblSignUpEmail);
            this.groupBox1.Controls.Add(this.lblSignUpPassword);
            this.groupBox1.Controls.Add(this.lblConSignUpPassword);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtConfirmPassword);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Location = new System.Drawing.Point(133, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 317);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkBack);
            this.Name = "SignUp";
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSignUpEmail;
        private System.Windows.Forms.Label lblSignUpPassword;
        private System.Windows.Forms.Label lblConSignUpPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.LinkLabel linkBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}