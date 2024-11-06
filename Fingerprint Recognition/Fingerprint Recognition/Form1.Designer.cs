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
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            button8 = new Button();
            button7 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            comboBox2 = new ComboBox();
            button6 = new Button();
            comboBox3 = new ComboBox();
            label2 = new Label();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(384, 43);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 545);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(618, 179);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(761, 600);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "檢測結果";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(12, 43);
            pictureBox2.Margin = new Padding(6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(359, 545);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(128, 38);
            comboBox1.Margin = new Padding(6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 37);
            comboBox1.TabIndex = 2;
            comboBox1.DropDown += comboBox1_DropDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 42);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 29);
            label1.TabIndex = 3;
            label1.Text = "序列埠:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(23, 179);
            groupBox2.Margin = new Padding(6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6);
            groupBox2.Size = new Size(582, 600);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "控制項";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(334, 491);
            numericUpDown1.Margin = new Padding(6);
            numericUpDown1.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(104, 37);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button8
            // 
            button8.Location = new Point(12, 430);
            button8.Margin = new Padding(6);
            button8.Name = "button8";
            button8.Size = new Size(310, 44);
            button8.TabIndex = 0;
            button8.Text = "檢查指紋安全等級: ?";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(12, 211);
            button7.Margin = new Padding(6);
            button7.Name = "button7";
            button7.Size = new Size(310, 44);
            button7.TabIndex = 0;
            button7.Text = "搜尋已註冊數量: ?";
            button7.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(12, 154);
            button5.Margin = new Padding(6);
            button5.Name = "button5";
            button5.Size = new Size(310, 44);
            button5.TabIndex = 0;
            button5.Text = "生成指紋圖檔";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 543);
            button4.Margin = new Padding(6);
            button4.Name = "button4";
            button4.Size = new Size(310, 44);
            button4.TabIndex = 0;
            button4.Text = "刪除所有指紋";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 487);
            button3.Margin = new Padding(6);
            button3.Name = "button3";
            button3.Size = new Size(310, 44);
            button3.TabIndex = 0;
            button3.Text = "刪除指紋";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 99);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(310, 44);
            button2.TabIndex = 0;
            button2.Text = "開啟LED";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 43);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(310, 44);
            button1.TabIndex = 0;
            button1.Text = "註冊指紋";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 42);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 29);
            label4.TabIndex = 5;
            label4.Text = "鮑率:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200" });
            comboBox2.Location = new Point(379, 38);
            comboBox2.Margin = new Padding(6);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(128, 37);
            comboBox2.TabIndex = 2;
            // 
            // button6
            // 
            button6.Location = new Point(540, 34);
            button6.Margin = new Padding(6);
            button6.Name = "button6";
            button6.Size = new Size(149, 44);
            button6.TabIndex = 6;
            button6.Text = "Connect";
            button6.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "員工", "管理員" });
            comboBox3.Location = new Point(1246, 38);
            comboBox3.Margin = new Padding(6);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(111, 37);
            comboBox3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1167, 42);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 29);
            label2.TabIndex = 5;
            label2.Text = "權限:";
            // 
            // button9
            // 
            button9.Location = new Point(1246, 126);
            button9.Name = "button9";
            button9.Size = new Size(115, 44);
            button9.TabIndex = 8;
            button9.Text = "設定";
            button9.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 803);
            Controls.Add(button9);
            Controls.Add(comboBox3);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "指紋註冊器  AVEX-SG Technology Inc.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private ComboBox comboBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
        private Button button4;
        private Label label4;
        private ComboBox comboBox2;
        private Button button6;
        private Button button7;
        private Button button8;
        private ComboBox comboBox3;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button button9;
    }
}
