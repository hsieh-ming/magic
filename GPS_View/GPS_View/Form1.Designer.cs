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
            GLL_ModeIndicator = new Label();
            GLL_Latitude = new Label();
            GGL_Longitude = new Label();
            GLL_NSDirection = new Label();
            GLL_EWDirection = new Label();
            GLL_Status = new Label();
            GLL_UTC = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            RMC_UTCDate = new Label();
            RMC_Course = new Label();
            RMC_GroundSpeed = new Label();
            RMC_IsValid = new Label();
            RMC_EWIndicator = new Label();
            RMC_NSIndicator = new Label();
            RMC_Longitude = new Label();
            RMC_Latitude = new Label();
            RMC_UTC = new Label();
            label26 = new Label();
            label25 = new Label();
            label11 = new Label();
            label12 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            tabPage5 = new TabPage();
            VTG_MagneticCourse = new Label();
            VTG_SpeedInKnots = new Label();
            VTG_SpeedInKmh = new Label();
            VTG_TrueCourse = new Label();
            label29 = new Label();
            label27 = new Label();
            label30 = new Label();
            label31 = new Label();
            groupBox1 = new GroupBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
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
            tabPage2.Controls.Add(GLL_ModeIndicator);
            tabPage2.Controls.Add(GLL_Latitude);
            tabPage2.Controls.Add(GGL_Longitude);
            tabPage2.Controls.Add(GLL_NSDirection);
            tabPage2.Controls.Add(GLL_EWDirection);
            tabPage2.Controls.Add(GLL_Status);
            tabPage2.Controls.Add(GLL_UTC);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(label19);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(508, 541);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "GLL";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // GLL_ModeIndicator
            // 
            GLL_ModeIndicator.AutoSize = true;
            GLL_ModeIndicator.Location = new Point(168, 279);
            GLL_ModeIndicator.Name = "GLL_ModeIndicator";
            GLL_ModeIndicator.Size = new Size(51, 25);
            GLL_ModeIndicator.TabIndex = 19;
            GLL_ModeIndicator.Text = "XXX";
            // 
            // GLL_Latitude
            // 
            GLL_Latitude.AutoSize = true;
            GLL_Latitude.Location = new Point(168, 69);
            GLL_Latitude.Name = "GLL_Latitude";
            GLL_Latitude.Size = new Size(51, 25);
            GLL_Latitude.TabIndex = 18;
            GLL_Latitude.Text = "XXX";
            // 
            // GGL_Longitude
            // 
            GGL_Longitude.AutoSize = true;
            GGL_Longitude.Location = new Point(168, 111);
            GGL_Longitude.Name = "GGL_Longitude";
            GGL_Longitude.Size = new Size(51, 25);
            GGL_Longitude.TabIndex = 17;
            GGL_Longitude.Text = "XXX";
            // 
            // GLL_NSDirection
            // 
            GLL_NSDirection.AutoSize = true;
            GLL_NSDirection.Location = new Point(168, 153);
            GLL_NSDirection.Name = "GLL_NSDirection";
            GLL_NSDirection.Size = new Size(51, 25);
            GLL_NSDirection.TabIndex = 16;
            GLL_NSDirection.Text = "XXX";
            // 
            // GLL_EWDirection
            // 
            GLL_EWDirection.AutoSize = true;
            GLL_EWDirection.Location = new Point(168, 195);
            GLL_EWDirection.Name = "GLL_EWDirection";
            GLL_EWDirection.Size = new Size(51, 25);
            GLL_EWDirection.TabIndex = 15;
            GLL_EWDirection.Text = "XXX";
            // 
            // GLL_Status
            // 
            GLL_Status.AutoSize = true;
            GLL_Status.Location = new Point(168, 237);
            GLL_Status.Name = "GLL_Status";
            GLL_Status.Size = new Size(51, 25);
            GLL_Status.TabIndex = 14;
            GLL_Status.Text = "XXX";
            // 
            // GLL_UTC
            // 
            GLL_UTC.AutoSize = true;
            GLL_UTC.Location = new Point(168, 27);
            GLL_UTC.Name = "GLL_UTC";
            GLL_UTC.Size = new Size(51, 25);
            GLL_UTC.TabIndex = 13;
            GLL_UTC.Text = "XXX";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(94, 279);
            label13.Name = "label13";
            label13.Size = new Size(57, 25);
            label13.TabIndex = 9;
            label13.Text = "模式:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(94, 237);
            label14.Name = "label14";
            label14.Size = new Size(57, 25);
            label14.TabIndex = 10;
            label14.Text = "狀態:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(61, 195);
            label15.Name = "label15";
            label15.Size = new Size(90, 25);
            label15.TabIndex = 11;
            label15.Text = "東/西 向:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(61, 153);
            label16.Name = "label16";
            label16.Size = new Size(90, 25);
            label16.TabIndex = 12;
            label16.Text = "南/北 向:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(95, 27);
            label17.Name = "label17";
            label17.Size = new Size(56, 25);
            label17.TabIndex = 4;
            label17.Text = "UTC:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(94, 111);
            label18.Name = "label18";
            label18.Size = new Size(57, 25);
            label18.TabIndex = 5;
            label18.Text = "經度:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(94, 69);
            label19.Name = "label19";
            label19.Size = new Size(57, 25);
            label19.TabIndex = 6;
            label19.Text = "緯度:";
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
            tabPage4.Controls.Add(RMC_UTCDate);
            tabPage4.Controls.Add(RMC_Course);
            tabPage4.Controls.Add(RMC_GroundSpeed);
            tabPage4.Controls.Add(RMC_IsValid);
            tabPage4.Controls.Add(RMC_EWIndicator);
            tabPage4.Controls.Add(RMC_NSIndicator);
            tabPage4.Controls.Add(RMC_Longitude);
            tabPage4.Controls.Add(RMC_Latitude);
            tabPage4.Controls.Add(RMC_UTC);
            tabPage4.Controls.Add(label26);
            tabPage4.Controls.Add(label25);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(label20);
            tabPage4.Controls.Add(label21);
            tabPage4.Controls.Add(label22);
            tabPage4.Controls.Add(label23);
            tabPage4.Controls.Add(label24);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(508, 541);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "RMC";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // RMC_UTCDate
            // 
            RMC_UTCDate.AutoSize = true;
            RMC_UTCDate.Location = new Point(141, 369);
            RMC_UTCDate.Name = "RMC_UTCDate";
            RMC_UTCDate.Size = new Size(51, 25);
            RMC_UTCDate.TabIndex = 28;
            RMC_UTCDate.Text = "XXX";
            // 
            // RMC_Course
            // 
            RMC_Course.AutoSize = true;
            RMC_Course.Location = new Point(140, 325);
            RMC_Course.Name = "RMC_Course";
            RMC_Course.Size = new Size(51, 25);
            RMC_Course.TabIndex = 27;
            RMC_Course.Text = "XXX";
            // 
            // RMC_GroundSpeed
            // 
            RMC_GroundSpeed.AutoSize = true;
            RMC_GroundSpeed.Location = new Point(140, 284);
            RMC_GroundSpeed.Name = "RMC_GroundSpeed";
            RMC_GroundSpeed.Size = new Size(51, 25);
            RMC_GroundSpeed.TabIndex = 26;
            RMC_GroundSpeed.Text = "XXX";
            // 
            // RMC_IsValid
            // 
            RMC_IsValid.AutoSize = true;
            RMC_IsValid.Location = new Point(140, 240);
            RMC_IsValid.Name = "RMC_IsValid";
            RMC_IsValid.Size = new Size(51, 25);
            RMC_IsValid.TabIndex = 25;
            RMC_IsValid.Text = "XXX";
            // 
            // RMC_EWIndicator
            // 
            RMC_EWIndicator.AutoSize = true;
            RMC_EWIndicator.Location = new Point(140, 198);
            RMC_EWIndicator.Name = "RMC_EWIndicator";
            RMC_EWIndicator.Size = new Size(51, 25);
            RMC_EWIndicator.TabIndex = 24;
            RMC_EWIndicator.Text = "XXX";
            // 
            // RMC_NSIndicator
            // 
            RMC_NSIndicator.AutoSize = true;
            RMC_NSIndicator.Location = new Point(140, 156);
            RMC_NSIndicator.Name = "RMC_NSIndicator";
            RMC_NSIndicator.Size = new Size(51, 25);
            RMC_NSIndicator.TabIndex = 23;
            RMC_NSIndicator.Text = "XXX";
            // 
            // RMC_Longitude
            // 
            RMC_Longitude.AutoSize = true;
            RMC_Longitude.Location = new Point(140, 114);
            RMC_Longitude.Name = "RMC_Longitude";
            RMC_Longitude.Size = new Size(51, 25);
            RMC_Longitude.TabIndex = 22;
            RMC_Longitude.Text = "XXX";
            // 
            // RMC_Latitude
            // 
            RMC_Latitude.AutoSize = true;
            RMC_Latitude.Location = new Point(140, 72);
            RMC_Latitude.Name = "RMC_Latitude";
            RMC_Latitude.Size = new Size(51, 25);
            RMC_Latitude.TabIndex = 21;
            RMC_Latitude.Text = "XXX";
            // 
            // RMC_UTC
            // 
            RMC_UTC.AutoSize = true;
            RMC_UTC.Location = new Point(140, 30);
            RMC_UTC.Name = "RMC_UTC";
            RMC_UTC.Size = new Size(51, 25);
            RMC_UTC.TabIndex = 20;
            RMC_UTC.Text = "XXX";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(78, 369);
            label26.Name = "label26";
            label26.Size = new Size(57, 25);
            label26.TabIndex = 16;
            label26.Text = "日期:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(77, 325);
            label25.Name = "label25";
            label25.Size = new Size(57, 25);
            label25.TabIndex = 16;
            label25.Text = "航向:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(37, 284);
            label11.Name = "label11";
            label11.Size = new Size(97, 25);
            label11.TabIndex = 16;
            label11.Text = "地面速度:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(37, 240);
            label12.Name = "label12";
            label12.Size = new Size(97, 25);
            label12.TabIndex = 17;
            label12.Text = "定位狀態:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(44, 198);
            label20.Name = "label20";
            label20.Size = new Size(90, 25);
            label20.TabIndex = 18;
            label20.Text = "東/西 向:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(44, 156);
            label21.Name = "label21";
            label21.Size = new Size(90, 25);
            label21.TabIndex = 19;
            label21.Text = "南/北 向:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(78, 30);
            label22.Name = "label22";
            label22.Size = new Size(56, 25);
            label22.TabIndex = 13;
            label22.Text = "UTC:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(77, 114);
            label23.Name = "label23";
            label23.Size = new Size(57, 25);
            label23.TabIndex = 14;
            label23.Text = "經度:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(77, 72);
            label24.Name = "label24";
            label24.Size = new Size(57, 25);
            label24.TabIndex = 15;
            label24.Text = "緯度:";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(VTG_MagneticCourse);
            tabPage5.Controls.Add(VTG_SpeedInKnots);
            tabPage5.Controls.Add(VTG_SpeedInKmh);
            tabPage5.Controls.Add(VTG_TrueCourse);
            tabPage5.Controls.Add(label29);
            tabPage5.Controls.Add(label27);
            tabPage5.Controls.Add(label30);
            tabPage5.Controls.Add(label31);
            tabPage5.Location = new Point(4, 34);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(508, 541);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "VTG";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // VTG_MagneticCourse
            // 
            VTG_MagneticCourse.AutoSize = true;
            VTG_MagneticCourse.Location = new Point(183, 88);
            VTG_MagneticCourse.Name = "VTG_MagneticCourse";
            VTG_MagneticCourse.Size = new Size(51, 25);
            VTG_MagneticCourse.TabIndex = 26;
            VTG_MagneticCourse.Text = "XXX";
            // 
            // VTG_SpeedInKnots
            // 
            VTG_SpeedInKnots.AutoSize = true;
            VTG_SpeedInKnots.Location = new Point(183, 130);
            VTG_SpeedInKnots.Name = "VTG_SpeedInKnots";
            VTG_SpeedInKnots.Size = new Size(51, 25);
            VTG_SpeedInKnots.TabIndex = 25;
            VTG_SpeedInKnots.Text = "XXX";
            // 
            // VTG_SpeedInKmh
            // 
            VTG_SpeedInKmh.AutoSize = true;
            VTG_SpeedInKmh.Location = new Point(183, 174);
            VTG_SpeedInKmh.Name = "VTG_SpeedInKmh";
            VTG_SpeedInKmh.Size = new Size(51, 25);
            VTG_SpeedInKmh.TabIndex = 24;
            VTG_SpeedInKmh.Text = "XXX";
            // 
            // VTG_TrueCourse
            // 
            VTG_TrueCourse.AutoSize = true;
            VTG_TrueCourse.Location = new Point(183, 46);
            VTG_TrueCourse.Name = "VTG_TrueCourse";
            VTG_TrueCourse.Size = new Size(51, 25);
            VTG_TrueCourse.TabIndex = 23;
            VTG_TrueCourse.Text = "XXX";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(120, 46);
            label29.Name = "label29";
            label29.Size = new Size(57, 25);
            label29.TabIndex = 20;
            label29.Text = "航向:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(20, 174);
            label27.Name = "label27";
            label27.Size = new Size(157, 25);
            label27.TabIndex = 21;
            label27.Text = "速度(公里/小時):";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(88, 130);
            label30.Name = "label30";
            label30.Size = new Size(89, 25);
            label30.TabIndex = 21;
            label30.Text = "速度(節):";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(120, 88);
            label31.Name = "label31";
            label31.Size = new Size(57, 25);
            label31.TabIndex = 22;
            label31.Text = "航向:";
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
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
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label11;
        private Label label12;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label27;
        private Label GLL_ModeIndicator;
        private Label GLL_Latitude;
        private Label GGL_Longitude;
        private Label GLL_NSDirection;
        private Label GLL_EWDirection;
        private Label GLL_Status;
        private Label GLL_UTC;
        private Label RMC_UTCDate;
        private Label RMC_Course;
        private Label RMC_GroundSpeed;
        private Label RMC_IsValid;
        private Label RMC_EWIndicator;
        private Label RMC_NSIndicator;
        private Label RMC_Longitude;
        private Label RMC_Latitude;
        private Label RMC_UTC;
        private Label VTG_MagneticCourse;
        private Label VTG_SpeedInKnots;
        private Label VTG_SpeedInKmh;
        private Label VTG_TrueCourse;
    }
}
