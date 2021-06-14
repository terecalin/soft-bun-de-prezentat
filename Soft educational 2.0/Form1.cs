using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_educational_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInformatii_Click(object sender, EventArgs e)
        {
            pnlInfo.Visible = true;
            pnlInfo.Size = new Size(965, 626);
            pnlInfo.Location = new Point(122, 0);
            pnlTest.Visible = false;
            panel1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlInfo.Visible = true;
            pnlInfo.Size = new Size(965, 626);
            pnlInfo.Location = new Point(122, 0);
            pnlTest.Visible = false;
            panel1.Visible = false;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            pnlTest.Visible = true;
            pnlTest.Size = new Size(964, 626);
            pnlTest.Location = new Point(122, 0);
            pnlInfo.Visible = false;
            panel1.Visible = false;
        }

        private void btnVerificare_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            if(radAlegere12.Checked==true)
            {
                cnt++;
                if(radAlegere22.Checked==true)
                {
                    cnt++;
                    if(chkAlegere32.Checked==true & chkAlegere33.Checked==true)
                    {
                        cnt++;
                        if(txtRaspuns.Text=="Fall Weiss")
                        {
                            cnt++;
                        }
                    }
                }
            }
            MessageBox.Show("Ai raspuns corect la " + cnt + " intrebari");
        }

        private void btnFacts_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Size = new Size(964, 626);
            panel1.Location = new Point(122, 0);
            pnlInfo.Visible = false;
            pnlTest.Visible = false;
        }
    }
}
