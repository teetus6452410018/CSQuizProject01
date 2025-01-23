namespace WindowsFormsApp1
{
    partial class FrmInternetCafe
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label36 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label49 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(304, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "โปรแกรม Internet Cafe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(38, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 238);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลผู้ใช้บริการ";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(268, 196);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(127, 17);
            this.radioButton3.TabIndex = 40;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "บุคลทั่วไป ไม่มีส่วนลด";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(268, 173);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(147, 17);
            this.radioButton2.TabIndex = 39;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "นักเรียน/นักศึกษา ลด 5%";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(268, 150);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 17);
            this.radioButton1.TabIndex = 38;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "สมาชิกลด 10%";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(265, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "ประเภทผู้ใช้บริการ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(316, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(265, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "ชื่อ-สกุล";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(26, 63);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 35;
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(23, 33);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(87, 23);
            this.label36.TabIndex = 34;
            this.label36.Text = "วันที่ใช้บริการ";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(386, 33);
            this.maskedTextBox1.Mask = "0-0000-00000-00-0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(99, 20);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(265, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "รหัสประจำตัวประชาชน";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(38, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 117);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลผู้ใช้บริการ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "อินเตอร์เน็ต ชั่วโมงละ 25.50 บาท",
            "พิมพ์งาน ชั่วโมงละ 10.50 บาท",
            "เล่นเกม Offline ชั่วโมงละ 15.50 บาท",
            "เล่นเกม Online ชั่วโมงละ 25.50 บาท"});
            this.comboBox1.Location = new System.Drawing.Point(158, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 21);
            this.comboBox1.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(23, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 42;
            this.label5.Text = "จำนวนการใช้บริการ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "ประเภทผู้ใช้บริการ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(46, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 48);
            this.label6.TabIndex = 4;
            this.label6.Text = "ข้อมูลการชำระเงิน";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label49);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(591, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 392);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Cyan;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(148, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 24);
            this.label9.TabIndex = 43;
            this.label9.Text = "-";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(19, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 23);
            this.label17.TabIndex = 41;
            this.label17.Text = "รหัสประจำตัวประชาชน";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Cyan;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(148, 68);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(154, 24);
            this.label24.TabIndex = 42;
            this.label24.Text = "-";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(45, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 23);
            this.label8.TabIndex = 41;
            this.label8.Text = "วันที่ใช้บริการ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(87, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 23);
            this.label10.TabIndex = 41;
            this.label10.Text = "ชื่อ-สกุล";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(19, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 19);
            this.label11.TabIndex = 44;
            this.label11.Text = "ประเภทผู้ใช้บริการ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(19, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 19);
            this.label12.TabIndex = 44;
            this.label12.Text = "จำนวนการใช้บริการ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 20);
            this.textBox1.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(248, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 23);
            this.label13.TabIndex = 41;
            this.label13.Text = "ชั่วโมง";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Cyan;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(148, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 24);
            this.label14.TabIndex = 45;
            this.label14.Text = "-";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Cyan;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(148, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 24);
            this.label15.TabIndex = 46;
            this.label15.Text = "-";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Cyan;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(148, 196);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(154, 24);
            this.label16.TabIndex = 47;
            this.label16.Text = "-";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Fuchsia;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(151, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // label49
            // 
            this.label49.BackColor = System.Drawing.Color.Cyan;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.Red;
            this.label49.Location = new System.Drawing.Point(53, 319);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(249, 42);
            this.label49.TabIndex = 59;
            this.label49.Text = "0.00";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "เริ่มใหม่";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(365, 390);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "ยืนยันการชำระเงิน";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = "คำนวณ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(373, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 27);
            this.button3.TabIndex = 9;
            this.button3.Text = "จบโปรแกรม";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmInternetCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 501);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmInternetCafe";
            this.Text = "โปรแกรม Quiz 1 ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}