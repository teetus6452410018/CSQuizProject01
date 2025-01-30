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
            this.rdNotMember = new System.Windows.Forms.RadioButton();
            this.rdStudent = new System.Windows.Forms.RadioButton();
            this.rdMember = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mcService = new System.Windows.Forms.MonthCalendar();
            this.label36 = new System.Windows.Forms.Label();
            this.mtbIdCard = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbHour = new System.Windows.Forms.TextBox();
            this.cbbTypeUser = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbShowResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbHour = new System.Windows.Forms.Label();
            this.lbTypeUser = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbIdCard = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbService = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btNew = new System.Windows.Forms.Button();
            this.cbAccept = new System.Windows.Forms.CheckBox();
            this.btCal = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.rdNotMember);
            this.groupBox1.Controls.Add(this.rdStudent);
            this.groupBox1.Controls.Add(this.rdMember);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbFullName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mcService);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.mtbIdCard);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(38, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 238);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลผู้ใช้บริการ";
            // 
            // rdNotMember
            // 
            this.rdNotMember.AutoSize = true;
            this.rdNotMember.Location = new System.Drawing.Point(268, 196);
            this.rdNotMember.Name = "rdNotMember";
            this.rdNotMember.Size = new System.Drawing.Size(127, 17);
            this.rdNotMember.TabIndex = 40;
            this.rdNotMember.TabStop = true;
            this.rdNotMember.Text = "บุคลทั่วไป ไม่มีส่วนลด";
            this.rdNotMember.UseVisualStyleBackColor = true;
            // 
            // rdStudent
            // 
            this.rdStudent.AutoSize = true;
            this.rdStudent.Location = new System.Drawing.Point(268, 173);
            this.rdStudent.Name = "rdStudent";
            this.rdStudent.Size = new System.Drawing.Size(147, 17);
            this.rdStudent.TabIndex = 39;
            this.rdStudent.TabStop = true;
            this.rdStudent.Text = "นักเรียน/นักศึกษา ลด 5%";
            this.rdStudent.UseVisualStyleBackColor = true;
            // 
            // rdMember
            // 
            this.rdMember.AutoSize = true;
            this.rdMember.Checked = true;
            this.rdMember.Location = new System.Drawing.Point(268, 150);
            this.rdMember.Name = "rdMember";
            this.rdMember.Size = new System.Drawing.Size(93, 17);
            this.rdMember.TabIndex = 38;
            this.rdMember.TabStop = true;
            this.rdMember.Text = "สมาชิกลด 10%";
            this.rdMember.UseVisualStyleBackColor = true;
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
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(316, 79);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(173, 20);
            this.tbFullName.TabIndex = 37;
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
            // mcService
            // 
            this.mcService.Location = new System.Drawing.Point(26, 63);
            this.mcService.Name = "mcService";
            this.mcService.TabIndex = 35;
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
            // mtbIdCard
            // 
            this.mtbIdCard.Location = new System.Drawing.Point(386, 33);
            this.mtbIdCard.Mask = "0-0000-00000-00-0";
            this.mtbIdCard.Name = "mtbIdCard";
            this.mtbIdCard.Size = new System.Drawing.Size(99, 20);
            this.mtbIdCard.TabIndex = 7;
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
            this.groupBox2.Controls.Add(this.tbHour);
            this.groupBox2.Controls.Add(this.cbbTypeUser);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(38, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 117);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลผู้ใช้บริการ";
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
            // tbHour
            // 
            this.tbHour.Location = new System.Drawing.Point(158, 65);
            this.tbHour.Name = "tbHour";
            this.tbHour.Size = new System.Drawing.Size(84, 20);
            this.tbHour.TabIndex = 41;
            this.tbHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHour_KeyPress);
            // 
            // cbbTypeUser
            // 
            this.cbbTypeUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeUser.FormattingEnabled = true;
            this.cbbTypeUser.Items.AddRange(new object[] {
            "อินเตอร์เน็ต ชั่วโมงละ 20.50 บาท",
            "พิมพ์งาน ชั่วโมงละ 10.50 บาท",
            "เล่นเกม Offline ชั่วโมงละ 15.50 บาท",
            "เล่นเกม Online ชั่วโมงละ 25.50 บาท"});
            this.cbbTypeUser.Location = new System.Drawing.Point(116, 29);
            this.cbbTypeUser.Name = "cbbTypeUser";
            this.cbbTypeUser.Size = new System.Drawing.Size(174, 21);
            this.cbbTypeUser.TabIndex = 43;
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
            this.label4.Location = new System.Drawing.Point(12, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
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
            this.groupBox3.Controls.Add(this.lbShowResult);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.lbHour);
            this.groupBox3.Controls.Add(this.lbTypeUser);
            this.groupBox3.Controls.Add(this.lbFullName);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lbIdCard);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.lbService);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(591, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 392);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // lbShowResult
            // 
            this.lbShowResult.BackColor = System.Drawing.Color.Cyan;
            this.lbShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowResult.ForeColor = System.Drawing.Color.Red;
            this.lbShowResult.Location = new System.Drawing.Point(53, 319);
            this.lbShowResult.Name = "lbShowResult";
            this.lbShowResult.Size = new System.Drawing.Size(249, 42);
            this.lbShowResult.TabIndex = 59;
            this.lbShowResult.Text = "0.00";
            this.lbShowResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lbHour
            // 
            this.lbHour.BackColor = System.Drawing.Color.Cyan;
            this.lbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHour.ForeColor = System.Drawing.Color.Red;
            this.lbHour.Location = new System.Drawing.Point(148, 196);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(176, 24);
            this.lbHour.TabIndex = 47;
            this.lbHour.Text = "-";
            this.lbHour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTypeUser
            // 
            this.lbTypeUser.BackColor = System.Drawing.Color.Cyan;
            this.lbTypeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeUser.ForeColor = System.Drawing.Color.Red;
            this.lbTypeUser.Location = new System.Drawing.Point(148, 164);
            this.lbTypeUser.Name = "lbTypeUser";
            this.lbTypeUser.Size = new System.Drawing.Size(213, 24);
            this.lbTypeUser.TabIndex = 46;
            this.lbTypeUser.Text = "-";
            this.lbTypeUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFullName
            // 
            this.lbFullName.BackColor = System.Drawing.Color.Cyan;
            this.lbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullName.ForeColor = System.Drawing.Color.Red;
            this.lbFullName.Location = new System.Drawing.Point(148, 130);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(176, 24);
            this.lbFullName.TabIndex = 45;
            this.lbFullName.Text = "-";
            this.lbFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(19, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 19);
            this.label11.TabIndex = 44;
            this.label11.Text = "ประเภทผู้ใช้บริการ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // lbIdCard
            // 
            this.lbIdCard.BackColor = System.Drawing.Color.Cyan;
            this.lbIdCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdCard.ForeColor = System.Drawing.Color.Red;
            this.lbIdCard.Location = new System.Drawing.Point(148, 98);
            this.lbIdCard.Name = "lbIdCard";
            this.lbIdCard.Size = new System.Drawing.Size(176, 24);
            this.lbIdCard.TabIndex = 43;
            this.lbIdCard.Text = "-";
            this.lbIdCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // lbService
            // 
            this.lbService.BackColor = System.Drawing.Color.Cyan;
            this.lbService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbService.ForeColor = System.Drawing.Color.Red;
            this.lbService.Location = new System.Drawing.Point(148, 68);
            this.lbService.Name = "lbService";
            this.lbService.Size = new System.Drawing.Size(176, 24);
            this.lbService.TabIndex = 42;
            this.lbService.Text = "-";
            this.lbService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(373, 351);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(187, 25);
            this.btNew.TabIndex = 6;
            this.btNew.Text = "เริ่มใหม่";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // cbAccept
            // 
            this.cbAccept.AutoSize = true;
            this.cbAccept.Location = new System.Drawing.Point(365, 390);
            this.cbAccept.Name = "cbAccept";
            this.cbAccept.Size = new System.Drawing.Size(115, 17);
            this.cbAccept.TabIndex = 7;
            this.cbAccept.Text = "ยืนยันการชำระเงิน";
            this.cbAccept.UseVisualStyleBackColor = true;
            // 
            // btCal
            // 
            this.btCal.Location = new System.Drawing.Point(486, 382);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(74, 25);
            this.btCal.TabIndex = 8;
            this.btCal.Text = "คำนวณ";
            this.btCal.UseVisualStyleBackColor = true;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(373, 413);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(187, 27);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "จบโปรแกรม";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // FrmInternetCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 501);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.cbAccept);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmInternetCafe";
            this.Text = "โปรแกรม Quiz 1 ";
            this.Load += new System.EventHandler(this.FrmInternetCafe_Load);
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
        private System.Windows.Forms.MaskedTextBox mtbIdCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar mcService;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdNotMember;
        private System.Windows.Forms.RadioButton rdStudent;
        private System.Windows.Forms.RadioButton rdMember;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTypeUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbService;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbIdCard;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbHour;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.Label lbTypeUser;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbShowResult;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.CheckBox cbAccept;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Button btExit;
    }
}