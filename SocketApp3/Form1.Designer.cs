namespace SocketApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstThermoSensors = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubnetMask = new System.Windows.Forms.TextBox();
            this.chkDefaultFlag = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMacAddress = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtThermosensorsCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVibroSensorInfo1 = new System.Windows.Forms.TextBox();
            this.txtVibrosensorsCount = new System.Windows.Forms.TextBox();
            this.txtVibroSensorInfo2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReadIP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReadPort = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnWriteData = new System.Windows.Forms.Button();
            this.btnGetAllData = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstThermoSensors
            // 
            this.lstThermoSensors.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstThermoSensors.FormattingEnabled = true;
            this.lstThermoSensors.ItemHeight = 14;
            this.lstThermoSensors.Location = new System.Drawing.Point(215, 79);
            this.lstThermoSensors.Name = "lstThermoSensors";
            this.lstThermoSensors.Size = new System.Drawing.Size(252, 298);
            this.lstThermoSensors.TabIndex = 11;
            this.lstThermoSensors.DoubleClick += new System.EventHandler(this.lstThermoSensors_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Маска підмережі";
            // 
            // txtSubnetMask
            // 
            this.txtSubnetMask.Location = new System.Drawing.Point(14, 119);
            this.txtSubnetMask.Name = "txtSubnetMask";
            this.txtSubnetMask.Size = new System.Drawing.Size(162, 20);
            this.txtSubnetMask.TabIndex = 3;
            // 
            // chkDefaultFlag
            // 
            this.chkDefaultFlag.AutoSize = true;
            this.chkDefaultFlag.Location = new System.Drawing.Point(22, 264);
            this.chkDefaultFlag.Name = "chkDefaultFlag";
            this.chkDefaultFlag.Size = new System.Drawing.Size(136, 17);
            this.chkDefaultFlag.TabIndex = 5;
            this.chkDefaultFlag.Text = "Режим налаштування";
            this.chkDefaultFlag.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP-адреса";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(14, 80);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(162, 20);
            this.txtIpAddress.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Шлюз";
            // 
            // txtGateway
            // 
            this.txtGateway.Location = new System.Drawing.Point(14, 158);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(105, 20);
            this.txtGateway.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "MAC-адреса (HEX)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Порт";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Кількість термодатчиків";
            this.label6.Visible = false;
            // 
            // txtMacAddress
            // 
            this.txtMacAddress.Location = new System.Drawing.Point(14, 197);
            this.txtMacAddress.Name = "txtMacAddress";
            this.txtMacAddress.Size = new System.Drawing.Size(162, 20);
            this.txtMacAddress.TabIndex = 6;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(125, 158);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(51, 20);
            this.txtPort.TabIndex = 5;
            // 
            // txtThermosensorsCount
            // 
            this.txtThermosensorsCount.Enabled = false;
            this.txtThermosensorsCount.Location = new System.Drawing.Point(229, 231);
            this.txtThermosensorsCount.Name = "txtThermosensorsCount";
            this.txtThermosensorsCount.Size = new System.Drawing.Size(141, 20);
            this.txtThermosensorsCount.TabIndex = 7;
            this.txtThermosensorsCount.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Датчики вібрації (HEX)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Кількість вібродатчиків";
            this.label8.Visible = false;
            // 
            // txtVibroSensorInfo1
            // 
            this.txtVibroSensorInfo1.Location = new System.Drawing.Point(35, 238);
            this.txtVibroSensorInfo1.Name = "txtVibroSensorInfo1";
            this.txtVibroSensorInfo1.Size = new System.Drawing.Size(54, 20);
            this.txtVibroSensorInfo1.TabIndex = 9;
            // 
            // txtVibrosensorsCount
            // 
            this.txtVibrosensorsCount.Enabled = false;
            this.txtVibrosensorsCount.Location = new System.Drawing.Point(229, 270);
            this.txtVibrosensorsCount.Name = "txtVibrosensorsCount";
            this.txtVibrosensorsCount.Size = new System.Drawing.Size(141, 20);
            this.txtVibrosensorsCount.TabIndex = 8;
            this.txtVibrosensorsCount.Visible = false;
            // 
            // txtVibroSensorInfo2
            // 
            this.txtVibroSensorInfo2.Location = new System.Drawing.Point(118, 238);
            this.txtVibroSensorInfo2.Name = "txtVibroSensorInfo2";
            this.txtVibroSensorInfo2.Size = new System.Drawing.Size(58, 20);
            this.txtVibroSensorInfo2.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Датчики температури (HEX)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "IP-адреса";
            // 
            // txtReadIP
            // 
            this.txtReadIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtReadIP.Location = new System.Drawing.Point(14, 25);
            this.txtReadIP.Name = "txtReadIP";
            this.txtReadIP.Size = new System.Drawing.Size(101, 20);
            this.txtReadIP.TabIndex = 0;
            this.txtReadIP.Text = "10.63.81.10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(122, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Порт";
            // 
            // txtReadPort
            // 
            this.txtReadPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtReadPort.Location = new System.Drawing.Point(125, 25);
            this.txtReadPort.Name = "txtReadPort";
            this.txtReadPort.Size = new System.Drawing.Size(39, 20);
            this.txtReadPort.TabIndex = 1;
            this.txtReadPort.Text = "2000";
            // 
            // lblD
            // 
            this.lblD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblD.Location = new System.Drawing.Point(12, 48);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(55, 15);
            this.lblD.TabIndex = 12;
            this.lblD.Text = "label13";
            // 
            // lblL
            // 
            this.lblL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblL.Location = new System.Drawing.Point(76, 48);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(56, 16);
            this.lblL.TabIndex = 12;
            this.lblL.Text = "label13";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "№1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(95, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "№2";
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::SocketApp3.res.help_icon;
            this.btnHelp.Location = new System.Drawing.Point(427, 9);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(40, 40);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnWriteData
            // 
            this.btnWriteData.Enabled = false;
            this.btnWriteData.Image = global::SocketApp3.res.WriteEEPROM;
            this.btnWriteData.Location = new System.Drawing.Point(310, 9);
            this.btnWriteData.Name = "btnWriteData";
            this.btnWriteData.Size = new System.Drawing.Size(111, 40);
            this.btnWriteData.TabIndex = 3;
            this.btnWriteData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWriteData.UseVisualStyleBackColor = true;
            this.btnWriteData.Click += new System.EventHandler(this.btnWriteData_Click);
            // 
            // btnGetAllData
            // 
            this.btnGetAllData.Image = global::SocketApp3.res.ReadEEPROM;
            this.btnGetAllData.Location = new System.Drawing.Point(184, 9);
            this.btnGetAllData.Name = "btnGetAllData";
            this.btnGetAllData.Size = new System.Drawing.Size(111, 40);
            this.btnGetAllData.TabIndex = 0;
            this.btnGetAllData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetAllData.UseVisualStyleBackColor = true;
            this.btnGetAllData.Click += new System.EventHandler(this.btnGetAllData_Click);
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(16, 273);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(193, 95);
            this.label14.TabIndex = 14;
            this.label14.Text = "\r\nIP      192.168.167.99\r\nMask    255.255.255.0\r\nGateway 192.168.167.254\r\nPort   " +
    " 3306\r\nMAC     DE.AD.BE.EF.01.01";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 389);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.txtThermosensorsCount);
            this.Controls.Add(this.txtVibrosensorsCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.chkDefaultFlag);
            this.Controls.Add(this.txtVibroSensorInfo2);
            this.Controls.Add(this.txtGateway);
            this.Controls.Add(this.txtReadPort);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtReadIP);
            this.Controls.Add(this.txtIpAddress);
            this.Controls.Add(this.txtVibroSensorInfo1);
            this.Controls.Add(this.txtMacAddress);
            this.Controls.Add(this.txtSubnetMask);
            this.Controls.Add(this.btnWriteData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstThermoSensors);
            this.Controls.Add(this.btnGetAllData);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Програма для роботи з контролерами";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetAllData;
        private System.Windows.Forms.ListBox lstThermoSensors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWriteData;
        private System.Windows.Forms.TextBox txtSubnetMask;
        private System.Windows.Forms.CheckBox chkDefaultFlag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMacAddress;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtThermosensorsCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVibroSensorInfo1;
        private System.Windows.Forms.TextBox txtVibrosensorsCount;
        private System.Windows.Forms.TextBox txtVibroSensorInfo2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtReadIP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtReadPort;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label label14;
    }
}

