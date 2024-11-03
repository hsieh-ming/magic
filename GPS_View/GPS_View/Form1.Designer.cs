namespace GPS_View
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Port_Name_comboBox = new ComboBox();
            Connect_button = new Button();
            GPS_Log_listBox = new ListBox();
            Clear_Log_button = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            GGA_Quality = new Label();
            GGA_GeoidalSeparation = new Label();
            GGA_Altitude = new Label();
            GGA_SatelliteCount = new Label();
            GGA_EWDirection = new Label();
            GGA_NSDirection = new Label();
            GGA_Longitude = new Label();
            GGA_Latitude = new Label();
            GGA_UTC = new Label();
            label4 = new Label();
            label3 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            groupBox1 = new GroupBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 22);
            label1.TabIndex = 0;
            label1.Text = "ComPort:";
            // 
            // Port_Name_comboBox
            // 
            Port_Name_comboBox.FormattingEnabled = true;
            Port_Name_comboBox.Location = new Point(102, 7);
            Port_Name_comboBox.Name = "Port_Name_comboBox";
            Port_Name_comboBox.Size = new Size(151, 27);
            Port_Name_comboBox.TabIndex = 1;
            Port_Name_comboBox.DropDown += Port_Name_comboBox_DropDown;
            // 
            // Connect_button
            // 
            Connect_button.Location = new Point(259, 6);
            Connect_button.Name = "Connect_button";
            Connect_button.Size = new Size(94, 29);
            Connect_button.TabIndex = 2;
            Connect_button.Text = "Connect";
            Connect_button.UseVisualStyleBackColor = true;
            Connect_button.Click += Connect_button_Click;
            // 
            // GPS_Log_listBox
            // 
            GPS_Log_listBox.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            GPS_Log_listBox.FormattingEnabled = true;
            GPS_Log_listBox.ItemHeight = 25;
            GPS_Log_listBox.Location = new Point(12, 40);
            GPS_Log_listBox.Name = "GPS_Log_listBox";
            GPS_Log_listBox.Size = new Size(924, 579);
            GPS_Log_listBox.TabIndex = 3;
            // 
            // Clear_Log_button
            // 
            Clear_Log_button.Location = new Point(842, 6);
            Clear_Log_button.Name = "Clear_Log_button";
            Clear_Log_button.Size = new Size(94, 29);
            Clear_Log_button.TabIndex = 4;
            Clear_Log_button.Text = "Clear Log";
            Clear_Log_button.UseVisualStyleBackColor = true;
            Clear_Log_button.Click += Clear_Log_button_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            tabControl1.Location = new Point(1116, 40);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(516, 579);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(GGA_Quality);
            tabPage1.Controls.Add(GGA_GeoidalSeparation);
            tabPage1.Controls.Add(GGA_Altitude);
            tabPage1.Controls.Add(GGA_SatelliteCount);
            tabPage1.Controls.Add(GGA_EWDirection);
            tabPage1.Controls.Add(GGA_NSDirection);
            tabPage1.Controls.Add(GGA_Longitude);
            tabPage1.Controls.Add(GGA_Latitude);
            tabPage1.Controls.Add(GGA_UTC);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(508, 541);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "GGA";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(53, 350);
            label10.Name = "label10";
            label10.Size = new Size(97, 25);
            label10.TabIndex = 3;
            label10.Text = "定位品質:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 308);
            label9.Name = "label9";
            label9.Size = new Size(137, 25);
            label9.TabIndex = 3;
            label9.Text = "大地水準面高:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(93, 266);
            label8.Name = "label8";
            label8.Size = new Size(57, 25);
            label8.TabIndex = 3;
            label8.Text = "海拔:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 224);
            label7.Name = "label7";
            label7.Size = new Size(117, 25);
            label7.TabIndex = 3;
            label7.Text = "使用衛星數:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 182);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 3;
            label6.Text = "東/西 向:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 140);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 3;
            label5.Text = "南/北 向:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 14);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 0;
            label2.Text = "UTC:";
            // 
            // GGA_Quality
            // 
            GGA_Quality.AutoSize = true;
            GGA_Quality.Location = new Point(156, 350);
            GGA_Quality.Name = "GGA_Quality";
            GGA_Quality.Size = new Size(51, 25);
            GGA_Quality.TabIndex = 1;
            GGA_Quality.Text = "XXX";
            // 
            // GGA_GeoidalSeparation
            // 
            GGA_GeoidalSeparation.AutoSize = true;
            GGA_GeoidalSeparation.Location = new Point(156, 308);
            GGA_GeoidalSeparation.Name = "GGA_GeoidalSeparation";
            GGA_GeoidalSeparation.Size = new Size(51, 25);
            GGA_GeoidalSeparation.TabIndex = 1;
            GGA_GeoidalSeparation.Text = "XXX";
            // 
            // GGA_Altitude
            // 
            GGA_Altitude.AutoSize = true;
            GGA_Altitude.Location = new Point(156, 266);
            GGA_Altitude.Name = "GGA_Altitude";
            GGA_Altitude.Size = new Size(51, 25);
            GGA_Altitude.TabIndex = 1;
            GGA_Altitude.Text = "XXX";
            // 
            // GGA_SatelliteCount
            // 
            GGA_SatelliteCount.AutoSize = true;
            GGA_SatelliteCount.Location = new Point(156, 224);
            GGA_SatelliteCount.Name = "GGA_SatelliteCount";
            GGA_SatelliteCount.Size = new Size(51, 25);
            GGA_SatelliteCount.TabIndex = 1;
            GGA_SatelliteCount.Text = "XXX";
            // 
            // GGA_EWDirection
            // 
            GGA_EWDirection.AutoSize = true;
            GGA_EWDirection.Location = new Point(156, 182);
            GGA_EWDirection.Name = "GGA_EWDirection";
            GGA_EWDirection.Size = new Size(51, 25);
            GGA_EWDirection.TabIndex = 1;
            GGA_EWDirection.Text = "XXX";
            // 
            // GGA_NSDirection
            // 
            GGA_NSDirection.AutoSize = true;
            GGA_NSDirection.Location = new Point(156, 140);
            GGA_NSDirection.Name = "GGA_NSDirection";
            GGA_NSDirection.Size = new Size(51, 25);
            GGA_NSDirection.TabIndex = 1;
            GGA_NSDirection.Text = "XXX";
            // 
            // GGA_Longitude
            // 
            GGA_Longitude.AutoSize = true;
            GGA_Longitude.Location = new Point(156, 98);
            GGA_Longitude.Name = "GGA_Longitude";
            GGA_Longitude.Size = new Size(51, 25);
            GGA_Longitude.TabIndex = 1;
            GGA_Longitude.Text = "XXX";
            // 
            // GGA_Latitude
            // 
            GGA_Latitude.AutoSize = true;
            GGA_Latitude.Location = new Point(156, 56);
            GGA_Latitude.Name = "GGA_Latitude";
            GGA_Latitude.Size = new Size(51, 25);
            GGA_Latitude.TabIndex = 1;
            GGA_Latitude.Text = "XXX";
            // 
            // GGA_UTC
            // 
            GGA_UTC.AutoSize = true;
            GGA_UTC.Location = new Point(156, 14);
            GGA_UTC.Name = "GGA_UTC";
            GGA_UTC.Size = new Size(51, 25);
            GGA_UTC.TabIndex = 1;
            GGA_UTC.Text = "XXX";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 98);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 2;
            label4.Text = "經度:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 56);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 2;
            label3.Text = "緯度:";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(508, 541);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "GLL";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(508, 541);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "GSA";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(508, 541);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "RMC";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 34);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(508, 541);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "VTG";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            groupBox1.Location = new Point(942, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(168, 579);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "控制台";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1637, 626);
            Controls.Add(groupBox1);
            Controls.Add(tabControl1);
            Controls.Add(Clear_Log_button);
            Controls.Add(GPS_Log_listBox);
            Controls.Add(Connect_button);
            Controls.Add(Port_Name_comboBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox Port_Name_comboBox;
        private Button Connect_button;
        private ListBox GPS_Log_listBox;
        private Button Clear_Log_button;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label label3;
        private Label GGA_UTC;
        private Label label2;
        private Label label5;
        private Label label4;
        private GroupBox groupBox1;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label GGA_Quality;
        private Label GGA_GeoidalSeparation;
        private Label GGA_Altitude;
        private Label GGA_SatelliteCount;
        private Label GGA_EWDirection;
        private Label GGA_NSDirection;
        private Label GGA_Longitude;
        private Label GGA_Latitude;
    }
}
