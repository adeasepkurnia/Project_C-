using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        string operasi;
        double nilai1;

        public Form1()
        {
            InitializeComponent();
        }
        private void no1_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0" && txt1.Text != null)
            {
                txt1.Text = "1";
            }
            else
            {
                txt1.Text = txt1.Text + "1";
            }

        }

        private void no2_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0" && txt1.Text != null)
            {
                txt1.Text = "2";
            }
            else
            {
                txt1.Text = txt1.Text + "2";
            }
        }

        private void no3_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0" && txt1.Text != null)
            {
                txt1.Text = "3";
            }
            else
            {
                txt1.Text = txt1.Text + "3";
            }
        }

        private void no4_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0" && txt1.Text != null)
            {
                txt1.Text = "4";
            }
            else
            {
                txt1.Text = txt1.Text + "4";
            }
        }

        private void no5_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0" && txt1.Text != null)
            {
                txt1.Text = "5";
            }
            else
            {
                txt1.Text = txt1.Text + "5";
            }
        }

        private void no6_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0" && txt1.Text != null)
            {
                txt1.Text = "6";
            }
            else
            {
                txt1.Text = txt1.Text + "6";
            }
        }

        private void no7_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0" && txt1.Text != null)
            {
                txt1.Text = "7";
            }
            else
            {
                txt1.Text = txt1.Text + "7";
            }
        }

        private void no8_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0" && txt1.Text != null)
            {
                txt1.Text = "8";
            }
            else
            {
                txt1.Text = txt1.Text + "8";
            }
        }

        private void no9_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0" && txt1.Text != null)
            {
                txt1.Text = "9";
            }
            else
            {
                txt1.Text = txt1.Text + "9";
            }
        }

        private void no0_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0" && txt1.Text != null)
            {
                txt1.Text = "0";
            }
            else
            {
                txt1.Text = txt1.Text + "0";
            }
        }

        private void bdot_Click(object sender, EventArgs e)
        {
          
                txt1.Text = txt1.Text + ".";
        }

        private void btambah_Click(object sender, EventArgs e)
        {
            nilai1 = Convert.ToDouble(txt1.Text);
            txt1.Text = "0";
            operasi = "+";
        }

        private void bhasil_Click(object sender, EventArgs e)
        {
            double nilai2;
            double hasil;
            nilai2 = Convert.ToDouble(txt1.Text);

            if (operasi == "+")
            {
                hasil = nilai1 + nilai2;
                txt1.Text = Convert.ToString(hasil);
            }
            if (operasi == "-")
            {
                hasil = nilai1 - nilai2;
                txt1.Text = Convert.ToString(hasil);
            }
            if (operasi == "/")
            {
                hasil = nilai1 / nilai2;
                txt1.Text = Convert.ToString(hasil);
            }
            if (operasi == "*")
            {
                hasil = nilai1 * nilai2;
                txt1.Text = Convert.ToString(hasil);
            }
        }

    

        private void bc_Click(object sender, EventArgs e)
        {
            txt1.Text = "0";
            operasi = "0";
        }

        private void bkali_Click(object sender, EventArgs e)
        {
           
        }

        private void bbagi_Click(object sender, EventArgs e)
        {
            nilai1 = Convert.ToDouble(txt1.Text);
            txt1.Text = "0";
            operasi = "/";
        }

        private void bkurang_Click(object sender, EventArgs e)
        {
            nilai1 = Convert.ToDouble(txt1.Text);
            txt1.Text = "0";
            operasi = "-";
        }

        private void bkali_Click_1(object sender, EventArgs e)
        {
            nilai1 = Convert.ToDouble(txt1.Text);
            txt1.Text = "0";
            operasi = "*";
        }

        private void bhapus_Click(object sender, EventArgs e)
        {
            if (txt1.Text.Length > 0)
                txt1.Text = txt1.Text.Remove(txt1.Text.Length - 1);
        }
    }
}
