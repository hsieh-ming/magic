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
            GPS_Log_listBox.FormattingEnabled = true;
            GPS_Log_listBox.ItemHeight = 19;
            GPS_Log_listBox.Location = new Point(12, 40);
            GPS_Log_listBox.Name = "GPS_Log_listBox";
            GPS_Log_listBox.Size = new Size(704, 574);
            GPS_Log_listBox.TabIndex = 3;
            // 
            // Clear_Log_button
            // 
            Clear_Log_button.Location = new Point(622, 6);
            Clear_Log_button.Name = "Clear_Log_button";
            Clear_Log_button.Size = new Size(94, 29);
            Clear_Log_button.TabIndex = 4;
            Clear_Log_button.Text = "Clear Log";
            Clear_Log_button.UseVisualStyleBackColor = true;
            Clear_Log_button.Click += Clear_Log_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 626);
            Controls.Add(Clear_Log_button);
            Controls.Add(GPS_Log_listBox);
            Controls.Add(Connect_button);
            Controls.Add(Port_Name_comboBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox Port_Name_comboBox;
        private Button Connect_button;
        private ListBox GPS_Log_listBox;
        private Button Clear_Log_button;
    }
}
