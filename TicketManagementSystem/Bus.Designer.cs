namespace TicketManagementSystem
{
    partial class Bus
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
            this.lblFromBus = new System.Windows.Forms.Label();
            this.lblToBus = new System.Windows.Forms.Label();
            this.lblDateAndTimeBus = new System.Windows.Forms.Label();
            this.lblPickSeat = new System.Windows.Forms.Label();
            this.dateTimeBus = new System.Windows.Forms.DateTimePicker();
            this.txtFromBus = new System.Windows.Forms.TextBox();
            this.txtToBus = new System.Windows.Forms.TextBox();
            this.linkHome = new System.Windows.Forms.LinkLabel();
            this.btnConfirmBus = new System.Windows.Forms.Button();
            this.chkA1Bus = new System.Windows.Forms.CheckBox();
            this.chkA2Bus = new System.Windows.Forms.CheckBox();
            this.chkA3Bus = new System.Windows.Forms.CheckBox();
            this.chkB2Bus = new System.Windows.Forms.CheckBox();
            this.chkB1Bus = new System.Windows.Forms.CheckBox();
            this.chkA4Bus = new System.Windows.Forms.CheckBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.chkB4Bus = new System.Windows.Forms.CheckBox();
            this.chkB3Bus = new System.Windows.Forms.CheckBox();
            this.chkC4Bus = new System.Windows.Forms.CheckBox();
            this.chkC3Bus = new System.Windows.Forms.CheckBox();
            this.chkC2Bus = new System.Windows.Forms.CheckBox();
            this.chkC1Bus = new System.Windows.Forms.CheckBox();
            this.chkD4Bus = new System.Windows.Forms.CheckBox();
            this.chkD3Bus = new System.Windows.Forms.CheckBox();
            this.chkD2Bus = new System.Windows.Forms.CheckBox();
            this.chkD1Bus = new System.Windows.Forms.CheckBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.ViewSeat = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ViewSeat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFromBus
            // 
            this.lblFromBus.AutoSize = true;
            this.lblFromBus.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromBus.Location = new System.Drawing.Point(19, 143);
            this.lblFromBus.Name = "lblFromBus";
            this.lblFromBus.Size = new System.Drawing.Size(54, 24);
            this.lblFromBus.TabIndex = 0;
            this.lblFromBus.Text = "From";
            this.lblFromBus.Click += new System.EventHandler(this.lblFromBus_Click);
            // 
            // lblToBus
            // 
            this.lblToBus.AutoSize = true;
            this.lblToBus.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToBus.Location = new System.Drawing.Point(19, 188);
            this.lblToBus.Name = "lblToBus";
            this.lblToBus.Size = new System.Drawing.Size(32, 24);
            this.lblToBus.TabIndex = 1;
            this.lblToBus.Text = "To";
            this.lblToBus.Click += new System.EventHandler(this.lblToBus_Click);
            // 
            // lblDateAndTimeBus
            // 
            this.lblDateAndTimeBus.AutoSize = true;
            this.lblDateAndTimeBus.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAndTimeBus.Location = new System.Drawing.Point(19, 246);
            this.lblDateAndTimeBus.Name = "lblDateAndTimeBus";
            this.lblDateAndTimeBus.Size = new System.Drawing.Size(135, 24);
            this.lblDateAndTimeBus.TabIndex = 2;
            this.lblDateAndTimeBus.Text = "Date and Time";
            // 
            // lblPickSeat
            // 
            this.lblPickSeat.AutoSize = true;
            this.lblPickSeat.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickSeat.Location = new System.Drawing.Point(90, 26);
            this.lblPickSeat.Name = "lblPickSeat";
            this.lblPickSeat.Size = new System.Drawing.Size(97, 27);
            this.lblPickSeat.TabIndex = 3;
            this.lblPickSeat.Text = "Pick Seat";
            this.lblPickSeat.Click += new System.EventHandler(this.lblPickSeat_Click);
            // 
            // dateTimeBus
            // 
            this.dateTimeBus.CalendarFont = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBus.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBus.Location = new System.Drawing.Point(164, 246);
            this.dateTimeBus.Name = "dateTimeBus";
            this.dateTimeBus.Size = new System.Drawing.Size(221, 25);
            this.dateTimeBus.TabIndex = 4;
            this.dateTimeBus.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtFromBus
            // 
            this.txtFromBus.Location = new System.Drawing.Point(164, 140);
            this.txtFromBus.Multiline = true;
            this.txtFromBus.Name = "txtFromBus";
            this.txtFromBus.Size = new System.Drawing.Size(191, 22);
            this.txtFromBus.TabIndex = 5;
            // 
            // txtToBus
            // 
            this.txtToBus.Location = new System.Drawing.Point(164, 185);
            this.txtToBus.Multiline = true;
            this.txtToBus.Name = "txtToBus";
            this.txtToBus.Size = new System.Drawing.Size(191, 22);
            this.txtToBus.TabIndex = 6;
            // 
            // linkHome
            // 
            this.linkHome.AutoSize = true;
            this.linkHome.BackColor = System.Drawing.SystemColors.Info;
            this.linkHome.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkHome.Location = new System.Drawing.Point(28, 377);
            this.linkHome.Name = "linkHome";
            this.linkHome.Size = new System.Drawing.Size(58, 22);
            this.linkHome.TabIndex = 10;
            this.linkHome.TabStop = true;
            this.linkHome.Text = "Home";
            this.linkHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHome_LinkClicked);
            // 
            // btnConfirmBus
            // 
            this.btnConfirmBus.AutoSize = true;
            this.btnConfirmBus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmBus.Location = new System.Drawing.Point(628, 324);
            this.btnConfirmBus.Name = "btnConfirmBus";
            this.btnConfirmBus.Size = new System.Drawing.Size(120, 26);
            this.btnConfirmBus.TabIndex = 11;
            this.btnConfirmBus.Text = "Confirm";
            this.btnConfirmBus.UseVisualStyleBackColor = true;
            this.btnConfirmBus.Click += new System.EventHandler(this.btnConfirmBus_Click);
            // 
            // chkA1Bus
            // 
            this.chkA1Bus.AutoSize = true;
            this.chkA1Bus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkA1Bus.Location = new System.Drawing.Point(6, 81);
            this.chkA1Bus.Name = "chkA1Bus";
            this.chkA1Bus.Size = new System.Drawing.Size(55, 28);
            this.chkA1Bus.TabIndex = 12;
            this.chkA1Bus.Text = "A1";
            this.chkA1Bus.UseVisualStyleBackColor = true;
            this.chkA1Bus.CheckedChanged += new System.EventHandler(this.chkA1Bus_CheckedChanged);
            // 
            // chkA2Bus
            // 
            this.chkA2Bus.AutoSize = true;
            this.chkA2Bus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkA2Bus.Location = new System.Drawing.Point(67, 81);
            this.chkA2Bus.Name = "chkA2Bus";
            this.chkA2Bus.Size = new System.Drawing.Size(55, 28);
            this.chkA2Bus.TabIndex = 13;
            this.chkA2Bus.Text = "A2";
            this.chkA2Bus.UseVisualStyleBackColor = true;
            this.chkA2Bus.CheckedChanged += new System.EventHandler(this.chkA2Bus_CheckedChanged);
            // 
            // chkA3Bus
            // 
            this.chkA3Bus.AutoSize = true;
            this.chkA3Bus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkA3Bus.Location = new System.Drawing.Point(139, 81);
            this.chkA3Bus.Name = "chkA3Bus";
            this.chkA3Bus.Size = new System.Drawing.Size(55, 28);
            this.chkA3Bus.TabIndex = 14;
            this.chkA3Bus.Text = "A3";
            this.chkA3Bus.UseVisualStyleBackColor = true;
            this.chkA3Bus.CheckedChanged += new System.EventHandler(this.chkA3Bus_CheckedChanged);
            // 
            // chkB2Bus
            // 
            this.chkB2Bus.AutoSize = true;
            this.chkB2Bus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkB2Bus.Location = new System.Drawing.Point(68, 124);
            this.chkB2Bus.Name = "chkB2Bus";
            this.chkB2Bus.Size = new System.Drawing.Size(54, 28);
            this.chkB2Bus.TabIndex = 17;
            this.chkB2Bus.Text = "B2";
            this.chkB2Bus.UseVisualStyleBackColor = true;
            this.chkB2Bus.CheckedChanged += new System.EventHandler(this.chkB2Bus_CheckedChanged);
            // 
            // chkB1Bus
            // 
            this.chkB1Bus.AutoSize = true;
            this.chkB1Bus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkB1Bus.Location = new System.Drawing.Point(5, 124);
            this.chkB1Bus.Name = "chkB1Bus";
            this.chkB1Bus.Size = new System.Drawing.Size(54, 28);
            this.chkB1Bus.TabIndex = 16;
            this.chkB1Bus.Text = "B1";
            this.chkB1Bus.UseVisualStyleBackColor = true;
            this.chkB1Bus.CheckedChanged += new System.EventHandler(this.chkB1Bus_CheckedChanged);
            // 
            // chkA4Bus
            // 
            this.chkA4Bus.AutoSize = true;
            this.chkA4Bus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkA4Bus.Location = new System.Drawing.Point(194, 81);
            this.chkA4Bus.Name = "chkA4Bus";
            this.chkA4Bus.Size = new System.Drawing.Size(55, 28);
            this.chkA4Bus.TabIndex = 15;
            this.chkA4Bus.Text = "A4";
            this.chkA4Bus.UseVisualStyleBackColor = true;
            this.chkA4Bus.CheckedChanged += new System.EventHandler(this.chkA4Bus_CheckedChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(164, 94);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(191, 22);
            this.txtPhoneNumber.TabIndex = 21;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(19, 97);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(139, 24);
            this.lblPhoneNumber.TabIndex = 20;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(164, 54);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 22);
            this.txtName.TabIndex = 19;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(19, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name";
            // 
            // chkB4Bus
            // 
            this.chkB4Bus.AutoSize = true;
            this.chkB4Bus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkB4Bus.Location = new System.Drawing.Point(193, 124);
            this.chkB4Bus.Name = "chkB4Bus";
            this.chkB4Bus.Size = new System.Drawing.Size(54, 28);
            this.chkB4Bus.TabIndex = 23;
            this.chkB4Bus.Text = "B4";
            this.chkB4Bus.UseVisualStyleBackColor = true;
            this.chkB4Bus.CheckedChanged += new System.EventHandler(this.chkB4Bus_CheckedChanged);
            // 
            // chkB3Bus
            // 
            this.chkB3Bus.AutoSize = true;
            this.chkB3Bus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkB3Bus.Location = new System.Drawing.Point(138, 124);
            this.chkB3Bus.Name = "chkB3Bus";
            this.chkB3Bus.Size = new System.Drawing.Size(54, 28);
            this.chkB3Bus.TabIndex = 22;
            this.chkB3Bus.Text = "B3";
            this.chkB3Bus.UseVisualStyleBackColor = true;
            this.chkB3Bus.CheckedChanged += new System.EventHandler(this.chkB3Bus_CheckedChanged);
            // 
            // chkC4Bus
            // 
            this.chkC4Bus.AutoSize = true;
            this.chkC4Bus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkC4Bus.Location = new System.Drawing.Point(194, 174);
            this.chkC4Bus.Name = "chkC4Bus";
            this.chkC4Bus.Size = new System.Drawing.Size(53, 28);
            this.chkC4Bus.TabIndex = 27;
            this.chkC4Bus.Text = "C4";
            this.chkC4Bus.UseVisualStyleBackColor = true;
            this.chkC4Bus.CheckedChanged += new System.EventHandler(this.chkC4Bus_CheckedChanged);
            // 
            // chkC3Bus
            // 
            this.chkC3Bus.AutoSize = true;
            this.chkC3Bus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkC3Bus.Location = new System.Drawing.Point(139, 174);
            this.chkC3Bus.Name = "chkC3Bus";
            this.chkC3Bus.Size = new System.Drawing.Size(53, 28);
            this.chkC3Bus.TabIndex = 26;
            this.chkC3Bus.Text = "C3";
            this.chkC3Bus.UseVisualStyleBackColor = true;
            this.chkC3Bus.CheckedChanged += new System.EventHandler(this.chkC3Bus_CheckedChanged);
            // 
            // chkC2Bus
            // 
            this.chkC2Bus.AutoSize = true;
            this.chkC2Bus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkC2Bus.Location = new System.Drawing.Point(67, 174);
            this.chkC2Bus.Name = "chkC2Bus";
            this.chkC2Bus.Size = new System.Drawing.Size(53, 28);
            this.chkC2Bus.TabIndex = 25;
            this.chkC2Bus.Text = "C2";
            this.chkC2Bus.UseVisualStyleBackColor = true;
            this.chkC2Bus.CheckedChanged += new System.EventHandler(this.chkC2Bus_CheckedChanged);
            // 
            // chkC1Bus
            // 
            this.chkC1Bus.AutoSize = true;
            this.chkC1Bus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkC1Bus.Location = new System.Drawing.Point(6, 174);
            this.chkC1Bus.Name = "chkC1Bus";
            this.chkC1Bus.Size = new System.Drawing.Size(53, 28);
            this.chkC1Bus.TabIndex = 24;
            this.chkC1Bus.Text = "C1";
            this.chkC1Bus.UseVisualStyleBackColor = true;
            this.chkC1Bus.CheckedChanged += new System.EventHandler(this.chkC1Bus_CheckedChanged);
            // 
            // chkD4Bus
            // 
            this.chkD4Bus.AutoSize = true;
            this.chkD4Bus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkD4Bus.Location = new System.Drawing.Point(194, 226);
            this.chkD4Bus.Name = "chkD4Bus";
            this.chkD4Bus.Size = new System.Drawing.Size(55, 28);
            this.chkD4Bus.TabIndex = 31;
            this.chkD4Bus.Text = "D4";
            this.chkD4Bus.UseVisualStyleBackColor = true;
            this.chkD4Bus.CheckedChanged += new System.EventHandler(this.chkD4Bus_CheckedChanged);
            // 
            // chkD3Bus
            // 
            this.chkD3Bus.AutoSize = true;
            this.chkD3Bus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkD3Bus.Location = new System.Drawing.Point(139, 226);
            this.chkD3Bus.Name = "chkD3Bus";
            this.chkD3Bus.Size = new System.Drawing.Size(55, 28);
            this.chkD3Bus.TabIndex = 30;
            this.chkD3Bus.Text = "D3";
            this.chkD3Bus.UseVisualStyleBackColor = true;
            this.chkD3Bus.CheckedChanged += new System.EventHandler(this.chkD3Bus_CheckedChanged);
            // 
            // chkD2Bus
            // 
            this.chkD2Bus.AutoSize = true;
            this.chkD2Bus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkD2Bus.Location = new System.Drawing.Point(67, 226);
            this.chkD2Bus.Name = "chkD2Bus";
            this.chkD2Bus.Size = new System.Drawing.Size(55, 28);
            this.chkD2Bus.TabIndex = 29;
            this.chkD2Bus.Text = "D2";
            this.chkD2Bus.UseVisualStyleBackColor = true;
            this.chkD2Bus.CheckedChanged += new System.EventHandler(this.chkD2Bus_CheckedChanged);
            // 
            // chkD1Bus
            // 
            this.chkD1Bus.AutoSize = true;
            this.chkD1Bus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkD1Bus.Location = new System.Drawing.Point(6, 226);
            this.chkD1Bus.Name = "chkD1Bus";
            this.chkD1Bus.Size = new System.Drawing.Size(55, 28);
            this.chkD1Bus.TabIndex = 28;
            this.chkD1Bus.Text = "D1";
            this.chkD1Bus.UseVisualStyleBackColor = true;
            this.chkD1Bus.CheckedChanged += new System.EventHandler(this.chkD1Bus_CheckedChanged);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(536, 369);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(213, 34);
            this.btnPayment.TabIndex = 32;
            this.btnPayment.Text = "Go To Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // ViewSeat
            // 
            this.ViewSeat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ViewSeat.Controls.Add(this.lblPickSeat);
            this.ViewSeat.Controls.Add(this.chkA1Bus);
            this.ViewSeat.Controls.Add(this.chkD4Bus);
            this.ViewSeat.Controls.Add(this.chkA2Bus);
            this.ViewSeat.Controls.Add(this.chkD3Bus);
            this.ViewSeat.Controls.Add(this.chkA3Bus);
            this.ViewSeat.Controls.Add(this.chkD2Bus);
            this.ViewSeat.Controls.Add(this.chkA4Bus);
            this.ViewSeat.Controls.Add(this.chkD1Bus);
            this.ViewSeat.Controls.Add(this.chkB1Bus);
            this.ViewSeat.Controls.Add(this.chkC4Bus);
            this.ViewSeat.Controls.Add(this.chkB2Bus);
            this.ViewSeat.Controls.Add(this.chkC3Bus);
            this.ViewSeat.Controls.Add(this.chkB3Bus);
            this.ViewSeat.Controls.Add(this.chkC2Bus);
            this.ViewSeat.Controls.Add(this.chkB4Bus);
            this.ViewSeat.Controls.Add(this.chkC1Bus);
            this.ViewSeat.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSeat.Location = new System.Drawing.Point(494, 21);
            this.ViewSeat.Name = "ViewSeat";
            this.ViewSeat.Size = new System.Drawing.Size(255, 287);
            this.ViewSeat.TabIndex = 33;
            this.ViewSeat.TabStop = false;
            this.ViewSeat.Text = "View Seat";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblFromBus);
            this.groupBox1.Controls.Add(this.lblToBus);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.lblDateAndTimeBus);
            this.groupBox1.Controls.Add(this.lblPhoneNumber);
            this.groupBox1.Controls.Add(this.dateTimeBus);
            this.groupBox1.Controls.Add(this.txtFromBus);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtToBus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 329);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // Bus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ViewSeat);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnConfirmBus);
            this.Controls.Add(this.linkHome);
            this.Name = "Bus";
            this.Text = "Bus";
            this.ViewSeat.ResumeLayout(false);
            this.ViewSeat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFromBus;
        private System.Windows.Forms.Label lblToBus;
        private System.Windows.Forms.Label lblDateAndTimeBus;
        private System.Windows.Forms.Label lblPickSeat;
        private System.Windows.Forms.DateTimePicker dateTimeBus;
        private System.Windows.Forms.TextBox txtFromBus;
        private System.Windows.Forms.TextBox txtToBus;
        private System.Windows.Forms.LinkLabel linkHome;
        private System.Windows.Forms.Button btnConfirmBus;
        private System.Windows.Forms.CheckBox chkA1Bus;
        private System.Windows.Forms.CheckBox chkA2Bus;
        private System.Windows.Forms.CheckBox chkA3Bus;
        private System.Windows.Forms.CheckBox chkB2Bus;
        private System.Windows.Forms.CheckBox chkB1Bus;
        private System.Windows.Forms.CheckBox chkA4Bus;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox chkB4Bus;
        private System.Windows.Forms.CheckBox chkB3Bus;
        private System.Windows.Forms.CheckBox chkC4Bus;
        private System.Windows.Forms.CheckBox chkC3Bus;
        private System.Windows.Forms.CheckBox chkC2Bus;
        private System.Windows.Forms.CheckBox chkC1Bus;
        private System.Windows.Forms.CheckBox chkD4Bus;
        private System.Windows.Forms.CheckBox chkD3Bus;
        private System.Windows.Forms.CheckBox chkD2Bus;
        private System.Windows.Forms.CheckBox chkD1Bus;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.GroupBox ViewSeat;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}