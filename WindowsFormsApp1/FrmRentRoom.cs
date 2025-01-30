using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmRentRoom : Form
    {
        public FrmRentRoom()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            dtpDatePay.Value = DateTime.Now;

            mtbIdCard.Clear();
            rdMr.Checked = true;
            tbName.Clear();
            tbSurname.Clear();

            cbbRoomType.SelectedIndex = 0;

            lbDatePay.Text = "-";
            lbIdCard.Text = "-";
            lbFullname.Text = "-";
            lbRoomType.Text = "-";

            cbPhone.Checked = false;
            tbPhone.Clear();
            lbPhone.Text = "0";
            lbPhonePrice.Text = "0.00";

            cbInternet.Checked = false;
            tbInternet.Clear();
            lbInternet.Text = "0";
            lbInternetPrice.Text = "0.00";

            cbWater.Checked = false;
            tbWater.Clear();
            lbWater.Text = "0";
            lbWaterPrice.Text = "0.00";

            cbElectric.Checked = false;
            tbElectric.Clear();
            lbElectric.Text = "0";
            lbElecPrice.Text = "0.00";

            lbShowResult.Text = "0.00";
        }

        private void cbPhone_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPhone.Checked == true)
            {
                tbPhone.Enabled = true;
            }
            else
            {
                tbPhone.Enabled = false;
            }
        }

        private void cbInternet_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInternet.Checked == true)
            {
                tbInternet.Enabled = true;
            }
            else
            {
                tbInternet.Enabled = false;
            }
        }

        private void cbWater_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWater.Checked == true)
            {
                tbWater.Enabled = true;
            }
            else
            {
                tbWater.Enabled = false;
            }
        }

        private void cbElectric_CheckedChanged(object sender, EventArgs e)
        {
            if (cbElectric.Checked == true)
            {
                tbElectric.Enabled = true;
            }
            else
            {
                tbElectric.Enabled = false;
            }
        }

        private void tbPhone_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbPhone.Text.Trim().Length > 0)
            {
                lbPhone.Text = tbPhone.Text.Trim();
                lbPhonePrice.Text = (int.Parse(tbPhone.Text) * 1.5).ToString("0.00");
            }
            else
            {
                lbPhone.Text = "0";
                lbPhonePrice.Text = "0.00";
            }
        }

        private void tbInternet_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbInternet.Text.Trim().Length > 0)
            {
                lbInternet.Text = tbInternet.Text.Trim();
                lbInternetPrice.Text = (int.Parse(tbInternet.Text) * 0.5).ToString("0.00");
            }
            else
            {
                lbInternet.Text = "0";
                lbInternetPrice.Text = "0.00";
            }
        }

        private void tbWater_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbWater.Text.Trim().Length > 0)
            {
                lbWater.Text = tbWater.Text.Trim();
                lbWaterPrice.Text = (int.Parse(tbWater.Text) * 1.5).ToString("0.00");
            }
            else
            {
                lbWater.Text = "0"; 
                lbWaterPrice.Text = "0.00";
            }
        }

        private void tbElectric_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbElectric.Text.Trim().Length > 0)
            {
                lbElectric.Text = tbElectric.Text.Trim();
                lbElecPrice.Text = (int.Parse(tbElectric.Text) * 1.5).ToString("0.00");
            }
            else
            {
                lbElectric.Text = "0";
                lbElecPrice.Text = "0.00";
            }
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            if (dtpDatePay.Value.Date.Day < DateTime.Now.Day)
            {
                ShareData.showWarningMSG("กรุณาตรวจสอบวันชำระเงินต้องมากกว่าปีปัจจุบัน...!");
            }
            else if (mtbIdCard.MaskCompleted == false)
            {
                ShareData.showWarningMSG("ป้อนรหัสประจำตัวประชาชน ด้วย...!");
            }
            else if (tbName.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนชื่อด้วย...!");
            }
            else if (tbSurname.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนนามสกุลด้วย...!");
            }
            else
            {
                CultureInfo culture = new CultureInfo("th-TH");
                lbDatePay.Text = dtpDatePay.Value.Date.ToString("d MMMM yyyy", culture);

                lbIdCard.Text = mtbIdCard.Text;

                if (rdMr.Checked == true)
                {
                    lbFullname.Text = rdMr.Text + tbName.Text + " " + tbSurname.Text;
                }
                else if (rdMrs.Checked == true)
                {
                    lbFullname.Text = rdMrs.Text + tbName.Text + " " + tbSurname.Text;
                }
                else
                {
                    lbFullname.Text = rdMiss.Text + tbName.Text + " " + tbSurname.Text;
                }

                lbRoomType.Text = cbbRoomType.Text;

                double totalpay;
                totalpay = double.Parse(lbPhonePrice.Text) +
                           double.Parse(lbInternetPrice.Text) +
                           double.Parse(lbWaterPrice.Text) +
                           double.Parse(lbElecPrice.Text);
                if (cbbRoomType.SelectedIndex == 0)
                {
                    totalpay = totalpay + 4500;
                }
                else if (cbbRoomType.SelectedIndex == 1)
                {
                    totalpay = totalpay + 4000;
                }
                else if (cbbRoomType.SelectedIndex == 2)
                {
                    totalpay = totalpay + 3500;
                }
                else
                {
                    totalpay = totalpay + 3000;
                }
                lbShowResult.Text = totalpay.ToString("0.00");
            }
        }

        private void FrmRentRoom_Load(object sender, EventArgs e)
        {
            cbbRoomType.SelectedIndex = 0;
        }
    }
}
