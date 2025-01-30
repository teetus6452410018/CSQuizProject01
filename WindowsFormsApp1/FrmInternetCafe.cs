using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmInternetCafe : Form
    {
        public FrmInternetCafe()
        {
            InitializeComponent();
        }

        private void FrmInternetCafe_Load(object sender, EventArgs e)
        {
            cbbTypeUser.SelectedIndex = 0;
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            mtbIdCard.Clear();
            tbFullName.Clear();
            
            cbbTypeUser.SelectedIndex = 0;

            tbHour.Clear();
            cbAccept.Checked = false;

            lbService.Text = "-";
            lbIdCard.Text = "-";
            lbFullName.Text = "-";
            lbTypeUser.Text = "-";
            lbHour.Text = "-";
            lbShowResult.Text = "0.00";
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการออกจากโปรแกรมหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void tbHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            // อนุญาตให้กดเฉพาะตัวเลข (0-9) และปุ่ม Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ไม่ให้ป้อนค่าที่ไม่ใช่ตัวเลข
            }
        }
        private void btCal_Click(object sender, EventArgs e)
        {
            if (mtbIdCard.MaskCompleted == false)
            {
                ShareData.showWarningMSG("ป้อนรหัสประจำตัวประชาชน ด้วย...!");
            }
            else if (tbFullName.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนชื่อ-นามสกุลด้วย...!");
            }
            else if (tbHour.Text.Trim().Length == 0 || tbHour.Text.Trim() == "0")
            {
                ShareData.showWarningMSG("ป้อนการใช้บริการด้วย และห้ามเป็น 0...!");
            }
            else if (cbAccept.Checked == false)
            {
                ShareData.showWarningMSG("ยืนยันการชำระเงินด้วย..!");
            }
            else
            {
                lbService.Text = mcService.SelectionStart.ToString("dd/MM/yyyy");
                lbIdCard.Text = mtbIdCard.Text;
                lbFullName.Text = tbFullName.Text;

                lbTypeUser.Text = cbbTypeUser.Text;
                lbHour.Text = tbHour.Text;

                if (cbbTypeUser.SelectedIndex == 0)
                {
                    if (rdMember.Checked == true)
                    {
                        double hourpay = double.Parse(tbHour.Text.Trim()) * 20.50;
                        double discount = hourpay - (hourpay * 0.10);
                        lbShowResult.Text = discount.ToString("#,##0.00");
                    }
                    else if (rdStudent.Checked == true)
                    {
                        double hourpay = double.Parse(tbHour.Text.Trim()) * 20.50;
                        double discount = hourpay - (hourpay * 0.05);
                        lbShowResult.Text = discount.ToString("#,##0.00");
                    }
                    else
                    {
                        double hourpay = double.Parse(tbHour.Text.Trim()) * 20.50;
                        lbShowResult.Text = hourpay.ToString("#,##0.00");
                    }
                }
                else if (cbbTypeUser.SelectedIndex == 1)
                {
                    if (rdMember.Checked == true)
                    {
                        double hourpay = double.Parse(tbHour.Text.Trim()) * 10.50;
                        double discount = hourpay - (hourpay * 0.10);
                        lbShowResult.Text = discount.ToString("#,##0.00");
                    }
                    else if (rdStudent.Checked == true)
                    {
                        double hourpay = double.Parse(tbHour.Text.Trim()) * 10.50;
                        double discount = hourpay - (hourpay * 0.05);
                        lbShowResult.Text = discount.ToString("#,##0.00");
                    }
                    else
                    {
                        double hourpay = double.Parse(tbHour.Text.Trim()) * 10.50;
                        lbShowResult.Text = hourpay.ToString("#,##0.00");
                    }
                }
                else if (cbbTypeUser.SelectedIndex == 2)
                {
                    if (rdMember.Checked == true)
                    {
                        double hourpay = double.Parse(tbHour.Text.Trim()) * 15.50;
                        double discount = hourpay - (hourpay * 0.10);
                        lbShowResult.Text = discount.ToString("#,##0.00");
                    }
                    else if (rdStudent.Checked == true)
                    {
                        double hourpay = double.Parse(tbHour.Text.Trim()) * 15.50;
                        double discount = hourpay - (hourpay * 0.05);
                        lbShowResult.Text = discount.ToString("#,##0.00");
                    }
                    else
                    {
                        double hourpay = double.Parse(tbHour.Text.Trim()) * 15.50;
                        lbShowResult.Text = hourpay.ToString("#,##0.00");
                    }
                }
                else
                {
                    if (rdMember.Checked == true)
                    {
                        double hourpay = double.Parse(tbHour.Text.Trim()) * 25.50;
                        double discount = hourpay - (hourpay * 0.10);
                        lbShowResult.Text = discount.ToString("#,##0.00");
                    }
                    else if (rdStudent.Checked == true)
                    {
                        double hourpay = double.Parse(tbHour.Text.Trim()) * 25.50;
                        double discount = hourpay - (hourpay * 0.05);
                        lbShowResult.Text = discount.ToString("#,##0.00");
                    }
                    else
                    {
                        double hourpay = double.Parse(tbHour.Text.Trim()) * 25.50;
                        lbShowResult.Text = hourpay.ToString("#,##0.00");
                    }
                }
            }
        }
    }
}
