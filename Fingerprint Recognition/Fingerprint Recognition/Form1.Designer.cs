namespace Fingerprint_Recognition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            Port_comboBox = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label3 = new Label();
            comboBox4 = new ComboBox();
            numericUpDown2 = new NumericUpDown();
            button10 = new Button();
            button8 = new Button();
            button7 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            Bandrate_comboBox = new ComboBox();
            Connect_button = new Button();
            comboBox3 = new ComboBox();
            label2 = new Label();
            Setting_button = new Button();
            label6 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            checkedListBox1 = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.no_accounts_60dp;
            pictureBox1.Location = new Point(279, 31);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(449, 133);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(554, 305);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "檢測結果";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(9, 31);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(262, 266);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Port_comboBox
            // 
            Port_comboBox.FormattingEnabled = true;
            Port_comboBox.Location = new Point(101, 5);
            Port_comboBox.Margin = new Padding(4);
            Port_comboBox.Name = "Port_comboBox";
            Port_comboBox.Size = new Size(117, 25);
            Port_comboBox.TabIndex = 2;
            Port_comboBox.DropDown += comboBox1_DropDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 3;
            label1.Text = "序列埠:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBox4);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(button10);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(17, 133);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(423, 428);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "控制項";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 273);
            label5.Name = "label5";
            label5.Size = new Size(63, 17);
            label5.TabIndex = 3;
            label5.Text = "安全等級:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 36);
            label3.Name = "label3";
            label3.Size = new Size(25, 17);
            label3.TabIndex = 3;
            label3.Text = "ID:";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBox4.Location = new Point(80, 270);
            comboBox4.Margin = new Padding(2, 3, 2, 3);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(158, 25);
            comboBox4.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(42, 34);
            numericUpDown2.Margin = new Padding(4);
            numericUpDown2.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(196, 24);
            numericUpDown2.TabIndex = 1;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button10
            // 
            button10.Location = new Point(12, 302);
            button10.Margin = new Padding(4);
            button10.Name = "button10";
            button10.Size = new Size(226, 32);
            button10.TabIndex = 0;
            button10.Text = "設定指紋安全等級";
            button10.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(12, 191);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(226, 32);
            button8.TabIndex = 0;
            button8.Text = "檢查指紋安全等級: ?";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(12, 231);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(226, 32);
            button7.TabIndex = 0;
            button7.Text = "搜尋已註冊數量: ?";
            button7.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(12, 149);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(226, 32);
            button5.TabIndex = 0;
            button5.Text = "生成指紋圖檔";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 384);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(226, 32);
            button4.TabIndex = 0;
            button4.Text = "刪除所有指紋";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 343);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(226, 32);
            button3.TabIndex = 0;
            button3.Text = "刪除指紋";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 108);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(226, 32);
            button2.TabIndex = 0;
            button2.Text = "開啟LED";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 66);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(226, 32);
            button1.TabIndex = 0;
            button1.Text = "註冊指紋";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(226, 9);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(37, 17);
            label4.TabIndex = 5;
            label4.Text = "鮑率:";
            // 
            // Bandrate_comboBox
            // 
            Bandrate_comboBox.FormattingEnabled = true;
            Bandrate_comboBox.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200" });
            Bandrate_comboBox.Location = new Point(284, 5);
            Bandrate_comboBox.Margin = new Padding(4);
            Bandrate_comboBox.Name = "Bandrate_comboBox";
            Bandrate_comboBox.Size = new Size(94, 25);
            Bandrate_comboBox.TabIndex = 2;
            // 
            // Connect_button
            // 
            Connect_button.Location = new Point(401, 1);
            Connect_button.Margin = new Padding(4);
            Connect_button.Name = "Connect_button";
            Connect_button.Size = new Size(108, 32);
            Connect_button.TabIndex = 6;
            Connect_button.Text = "Connect";
            Connect_button.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "員工", "管理員" });
            comboBox3.Location = new Point(914, 5);
            comboBox3.Margin = new Padding(4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(82, 25);
            comboBox3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(857, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 5;
            label2.Text = "權限:";
            // 
            // Setting_button
            // 
            Setting_button.Location = new Point(906, 84);
            Setting_button.Margin = new Padding(2, 3, 2, 3);
            Setting_button.Name = "Setting_button";
            Setting_button.Size = new Size(81, 32);
            Setting_button.TabIndex = 8;
            Setting_button.Text = "設定";
            Setting_button.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 84);
            label6.Name = "label6";
            label6.Size = new Size(89, 17);
            label6.TabIndex = 9;
            label6.Text = "註冊人員姓名:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 24);
            textBox1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(226, 85);
            label7.Name = "label7";
            label7.Size = new Size(63, 17);
            label7.TabIndex = 9;
            label7.Text = "員工編號:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(295, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 24);
            textBox2.TabIndex = 10;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(449, 443);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(271, 118);
            checkedListBox1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 578);
            Controls.Add(checkedListBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Setting_button);
            Controls.Add(comboBox3);
            Controls.Add(Connect_button);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(Bandrate_comboBox);
            Controls.Add(Port_comboBox);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            Text = "指紋註冊器  AVEX-SG Technology Inc.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private ComboBox Port_comboBox;
        private Label label1;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
        private Button button4;
        private Label label4;
        private ComboBox Bandrate_comboBox;
        private Button Connect_button;
        private Button button7;
        private Button button8;
        private ComboBox comboBox3;
        private Label label2;
        private Button Setting_button;
        private ComboBox comboBox4;
        private Button button10;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private Label label3;
        private Label label6;
        private TextBox textBox1;
        private Label label7;
        private TextBox textBox2;
        private CheckedListBox checkedListBox1;
    }
}
