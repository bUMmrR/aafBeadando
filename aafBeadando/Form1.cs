using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aafBeadando
{
    public partial class listak : Form
    {
        public listak()
        {
            InitializeComponent();
        }

        private void listak_Load(object sender, EventArgs e)
        {
            torol1.Enabled = false;
            torol2.Enabled = false;
            fel1.Enabled = false;
            fel2.Enabled = false;
            felulre1.Enabled = false;
            felulre2.Enabled = false;
            le1.Enabled = false;
            le2.Enabled = false;
            alulra1.Enabled = false;
            alulra2.Enabled = false;
            jobraKuld.Enabled = false;
            balraKuld.Enabled = false;
        }

        public void addNewItem(int szam)
        {
            if (szam == 1)
            {
                if (text1.Text != "")
                {
                    string szoveg = text1.Text;
                    lb1.Items.Add(szoveg);
                }
            }
            else
            {
                if (text2.Text != "")
                {
                    string szoveg = text2.Text;
                    lb2.Items.Add(szoveg);
                }
            }
        }

        public void removeItem(int szam)
        {
            if (szam == 1)
            {
                if (lb1.SelectedIndex != -1)
                {
                    lb1.Items.RemoveAt(lb1.SelectedIndex);
                }
            }
            else
            {
                if (lb2.SelectedIndex != -1)
                {
                    lb2.Items.RemoveAt(lb2.SelectedIndex);
                }
            }
        }

        private void hozzaad1_Click(object sender, EventArgs e)
        {
            if (text1.Text != "")
            {
                addNewItem(1);
            }
        }

        private void hozzaad2_Click(object sender, EventArgs e)
        {
            if (text2.Text != "")
            {
                addNewItem(2);
            }

        }

        private void torol1_Click(object sender, EventArgs e)
        {
            removeItem(1);
            torol1.Enabled = false;
            fel1.Enabled = false;
            felulre1.Enabled = false;
            le1.Enabled = false;
            alulra1.Enabled = false;
        }

        private void torol2_Click(object sender, EventArgs e)
        {
            removeItem(2);
            torol2.Enabled = false;
            fel2.Enabled = false;
            felulre2.Enabled = false;
            le2.Enabled = false;
            alulra2.Enabled = false;
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            torol1.Enabled = true;
            jobraKuld.Enabled = true;

            if (lb1.SelectedIndex != 0)
            {
                fel1.Enabled = true;
                felulre1.Enabled = true;
            }
            else
            {
                fel1.Enabled = false;
                felulre1.Enabled = false;
            }
            if (lb1.SelectedIndex == lb1.Items.Count-1)
            {
                le1.Enabled = false;
                alulra1.Enabled = false;
            }
            else
            {
                le1.Enabled = true;
                alulra1.Enabled = true;
            }

        }

        private void lb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            torol2.Enabled = true;
            balraKuld.Enabled = true;

            if (lb2.SelectedIndex != 0)
            {
                fel2.Enabled = true;
                felulre2.Enabled = true;
            }
            else
            {
                fel2.Enabled = false;
                felulre2.Enabled = false;
            }
            if (lb2.SelectedIndex == lb2.Items.Count - 1)
            {
                le2.Enabled = false;
                alulra2.Enabled = false;
            }
            else
            {
                le2.Enabled = true;
                alulra2.Enabled = true;
            }
        }

        private void felulre1_Click(object sender, EventArgs e)
        {
            string sv = lb1.Items[lb1.SelectedIndex].ToString();
            lb1.Items[lb1.SelectedIndex] = lb1.Items[0];
            lb1.Items[0] = sv;
        }

        private void felulre2_Click(object sender, EventArgs e)
        {
            string sv = lb2.Items[lb2.SelectedIndex].ToString();
            lb2.Items[lb2.SelectedIndex] = lb2.Items[0];
            lb2.Items[0] = sv;
        }

        private void fel1_Click(object sender, EventArgs e)
        {
            string sv = lb1.Items[lb1.SelectedIndex].ToString();
            lb1.Items[lb1.SelectedIndex] = lb1.Items[lb1.SelectedIndex-1];
            lb1.Items[lb1.SelectedIndex - 1] = sv;
        }

        private void fel2_Click(object sender, EventArgs e)
        {
            string sv = lb2.Items[lb2.SelectedIndex].ToString();
            lb2.Items[lb2.SelectedIndex] = lb2.Items[lb2.SelectedIndex - 1];
            lb2.Items[lb2.SelectedIndex - 1] = sv;
        }

        private void le1_Click(object sender, EventArgs e)
        {
            string sv = lb1.Items[lb1.SelectedIndex].ToString();
            lb1.Items[lb1.SelectedIndex] = lb1.Items[lb1.SelectedIndex + 1];
            lb1.Items[lb1.SelectedIndex + 1] = sv;
        }

        private void le2_Click(object sender, EventArgs e)
        {
            string sv = lb2.Items[lb2.SelectedIndex].ToString();
            lb2.Items[lb2.SelectedIndex] = lb2.Items[lb2.SelectedIndex + 1];
            lb2.Items[lb2.SelectedIndex + 1] = sv;
        }

        private void alulra1_Click(object sender, EventArgs e)
        {
            string sv = lb1.Items[lb1.SelectedIndex].ToString();
            lb1.Items[lb1.SelectedIndex] = lb1.Items[lb1.Items.Count-1];
            lb1.Items[lb1.Items.Count-1] = sv;
        }

        private void alulra2_Click(object sender, EventArgs e)
        {
            string sv = lb2.Items[lb2.SelectedIndex].ToString();
            lb2.Items[lb2.SelectedIndex] = lb2.Items[lb2.Items.Count - 1];
            lb2.Items[lb2.Items.Count - 1] = sv;
        }

        private void balraKuld_Click(object sender, EventArgs e)
        {
            string text = lb2.Items[lb2.SelectedIndex].ToString();
            lb2.Items.RemoveAt(lb2.SelectedIndex);
            lb1.Items.Add(text);
        }

        private void jobraKuld_Click(object sender, EventArgs e)
        {
            string text = lb1.Items[lb1.SelectedIndex].ToString();
            lb1.Items.RemoveAt(lb1.SelectedIndex);
            lb2.Items.Add(text);
        }
    }
}
