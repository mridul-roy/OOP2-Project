namespace TicketManagementSystem
{
    partial class Payment
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
            this.lblbKash = new System.Windows.Forms.Label();
            this.lblRocket = new System.Windows.Forms.Label();
            this.lblNagad = new System.Windows.Forms.Label();
            this.txtBkash = new System.Windows.Forms.TextBox();
            this.txtRocket = new System.Windows.Forms.TextBox();
            this.txtNagad = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblbKash
            // 
            this.lblbKash.AutoSize = true;
            this.lblbKash.Location = new System.Drawing.Point(29, 93);
            this.lblbKash.Name = "lblbKash";
            this.lblbKash.Size = new System.Drawing.Size(62, 24);
            this.lblbKash.TabIndex = 0;
            this.lblbKash.Text = "bKash";
            // 
            // lblRocket
            // 
            this.lblRocket.AutoSize = true;
            this.lblRocket.Location = new System.Drawing.Point(29, 147);
            this.lblRocket.Name = "lblRocket";
            this.lblRocket.Size = new System.Drawing.Size(69, 24);
            this.lblRocket.TabIndex = 1;
            this.lblRocket.Text = "Rocket";
            // 
            // lblNagad
            // 
            this.lblNagad.AutoSize = true;
            this.lblNagad.Location = new System.Drawing.Point(29, 203);
            this.lblNagad.Name = "lblNagad";
            this.lblNagad.Size = new System.Drawing.Size(66, 24);
            this.lblNagad.TabIndex = 2;
            this.lblNagad.Text = "Nagad";
            // 
            // txtBkash
            // 
            this.txtBkash.Location = new System.Drawing.Point(180, 93);
            this.txtBkash.Name = "txtBkash";
            this.txtBkash.Size = new System.Drawing.Size(162, 30);
            this.txtBkash.TabIndex = 3;
            // 
            // txtRocket
            // 
            this.txtRocket.Location = new System.Drawing.Point(180, 141);
            this.txtRocket.Name = "txtRocket";
            this.txtRocket.Size = new System.Drawing.Size(162, 30);
            this.txtRocket.TabIndex = 4;
            // 
            // txtNagad
            // 
            this.txtNagad.Location = new System.Drawing.Point(180, 200);
            this.txtNagad.Name = "txtNagad";
            this.txtNagad.Size = new System.Drawing.Size(162, 30);
            this.txtNagad.TabIndex = 5;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(229, 245);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(113, 32);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(370, 353);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(89, 36);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(180, 44);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(162, 22);
            this.txtPhoneNumber.TabIndex = 23;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(29, 44);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(139, 24);
            this.lblPhoneNumber.TabIndex = 22;
            this.lblPhoneNumber.Text = "Phone Number";
            this.lblPhoneNumber.Click += new System.EventHandler(this.lblPhoneNumber_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.txtBkash);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.lblbKash);
            this.groupBox1.Controls.Add(this.lblPhoneNumber);
            this.groupBox1.Controls.Add(this.lblRocket);
            this.groupBox1.Controls.Add(this.lblNagad);
            this.groupBox1.Controls.Add(this.txtRocket);
            this.groupBox1.Controls.Add(this.txtNagad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(73, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 323);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHome);
            this.Name = "Payment";
            this.Text = "Payment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblbKash;
        private System.Windows.Forms.Label lblRocket;
        private System.Windows.Forms.Label lblNagad;
        private System.Windows.Forms.TextBox txtBkash;
        private System.Windows.Forms.TextBox txtRocket;
        private System.Windows.Forms.TextBox txtNagad;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}