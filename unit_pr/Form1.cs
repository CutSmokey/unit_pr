using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unit_pr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();      
        }



        private void malerb_CheckedChanged(object sender, EventArgs e)
        {
            if (malerb.Checked == true)
            {
                armgb.Visible = true;
                fmgb.Visible = false;
            }
            else
            {
                fmgb.Visible = true;
                armgb.Visible = true;

            }
        }



        private void resoultbtn_Click(object sender, EventArgs e)
        {
            double res;
            res = (((Convert.ToDouble(worktimetb.Text)*365) - (Convert.ToDouble(medictimetb.Text)*28) + Convert.ToDouble(armtime.Text)*365 + Convert.ToDouble(dtimetb.Text)*365) / 365) * (Convert.ToDouble(multilbtb.Text)*87.56);
            rsl.Text = Convert.ToString(res);
        }

        private void armtime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
