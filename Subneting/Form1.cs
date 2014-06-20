using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subneting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ip1.Text == "" || ip2.Text == "" || ip3.Text == "" || ip4.Text == "" || cdir.Text == "" || jlh_Subnet.Text == "")
                MessageBox.Show("Ada yang Kosong...!!!");
            else
            {
                int IP1 = Convert.ToInt32(ip1.Text), IP2 = Convert.ToInt32(ip2.Text), IP3 = Convert.ToInt32(ip3.Text), IP4 = Convert.ToInt32(ip4.Text);
                Double pangkat_subnet = Math.Round(Math.Sqrt(Convert.ToDouble(jlh_Subnet.Text)), 0);
                int subnetMask = Convert.ToInt32(cdir.Text) + Convert.ToInt32(pangkat_subnet);
                Dictionary<int, int> dic = new Dictionary<int, int>();
                string subnet = "";
                double j = 7;
                double hasil = 0;
                for (int i = 1; i <= subnetMask; i++)
                {
                    if (Convert.ToInt32(j) < 0)
                    {
                        subnet += Convert.ToInt32(hasil).ToString() + ".";
                        j = 7;
                        hasil = 0;
                    }
                    hasil += Math.Pow(2, j);
                    j--;
                }
                if (hasil != 0)
                    subnet += Convert.ToInt32(hasil).ToString();

                int host = 32 - subnetMask;
                int tmpIP1 = 0, tmpIP2 = 0, tmpIP3 = 0, tmpIP4 = 0;
                List<string> network = new List<string>();
                List<string> broadcast = new List<string>();

                for (int m = 0; m < host; m++)
                {
                    if (m <= 7)
                    {
                        tmpIP4 += Convert.ToInt32(Math.Pow(2, Convert.ToDouble(m % 8)));
                    }
                    else if (m <= 15)
                    {
                        tmpIP3 += Convert.ToInt32(Math.Pow(2, Convert.ToDouble(m % 8)));
                    }
                    else if (m <= 23)
                    {
                        tmpIP2 += Convert.ToInt32(Math.Pow(2, Convert.ToDouble(m % 8)));
                    }
                    else if (m <= 31)
                    {
                        tmpIP1 += Convert.ToInt32(Math.Pow(2, Convert.ToDouble(m % 8)));
                    }
                }

                for (int i = 1; i <= Convert.ToInt32(jlh_Subnet.Text); i++)
                {
                    network.Add(string.Format("{0}.{1}.{2}.{3}", IP1.ToString(), IP2.ToString(), IP3.ToString(), IP4.ToString()));

                    if (IP4 + tmpIP4 > 255)
                    {
                        IP4 = (IP4 + tmpIP4) % 255;
                        IP3++;
                    }
                    else
                        IP4 += tmpIP4;
                    if (IP3 + tmpIP3 > 255)
                    {
                        IP3 = (IP3 + tmpIP3) % 255;
                        IP2++;
                    }
                    else
                        IP3 += tmpIP3;
                    if (IP2 + tmpIP2 > 255)
                    {
                        IP2 = (IP2 + tmpIP2) % 255;
                        IP1++;
                    }
                    else
                        IP2 += tmpIP2;
                    if (IP1 + tmpIP1 > 255)
                    {
                        IP1 = (IP1 + tmpIP1) % 255;
                    }
                    else
                        IP1 += tmpIP1;

                    broadcast.Add(string.Format("{0}.{1}.{2}.{3}", IP1.ToString(), IP2.ToString(), IP3.ToString(), IP4.ToString()));

                    if (IP4 + 1 > 255)
                    {
                        IP4 = 0;
                        IP3++;
                    }
                    else
                        IP4++;
                    if (IP3 > 255)
                    {
                        IP3 = 0;
                        IP2++;
                    }
                    if (IP2 > 255)
                    {
                        IP2 = 0;
                        IP1++;
                    }
                    if (IP1 > 255)
                    {
                        IP1 = 0;
                    }
                }
                listHasil.Items.Clear();
                listHasil.Items.Add(string.Format("   SubnetMask = {0}\n", subnet));
                for (int i = 0; i < network.Count; i++)
                {
                    listHasil.Items.Add(string.Format("{0,2}. Network   = {1}/{2}", i + 1, network[i], subnetMask));
                    listHasil.Items.Add(string.Format("    Broadcast = {0}", broadcast[i]));
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ip1.Clear();
            ip2.Clear();
            ip3.Clear();
            ip4.Clear();
            cdir.Clear();
            jlh_Subnet.Clear();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create by SURYADI...!!!");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikasi ini untuk mencari subneting dengan jumlah host yang sama...!!!");
        }

        private void ip1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Keys)e.KeyChar >= Keys.D0 && (Keys)e.KeyChar <= Keys.D9))
                e.KeyChar = (char)Keys.None;
        }

        private void ip2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Keys)e.KeyChar >= Keys.D0 && (Keys)e.KeyChar <= Keys.D9))
                e.KeyChar = (char)Keys.None;
        }

        private void ip3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Keys)e.KeyChar >= Keys.D0 && (Keys)e.KeyChar <= Keys.D9))
                e.KeyChar = (char)Keys.None;
        }

        private void ip4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Keys)e.KeyChar >= Keys.D0 && (Keys)e.KeyChar <= Keys.D9))
                e.KeyChar = (char)Keys.None;
        }

        private void cdir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Keys)e.KeyChar >= Keys.D0 && (Keys)e.KeyChar <= Keys.D9))
                e.KeyChar = (char)Keys.None;
        }

        private void jlh_Subnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Keys)e.KeyChar >= Keys.D0 && (Keys)e.KeyChar <= Keys.D9))
                e.KeyChar = (char)Keys.None;
        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tutor = MessageBox.Show("Masukkan IP mis. 202.10.7.0/24 dan jlh subnet 4\nMaka akan ditampilkan hasil dari Subneting", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
