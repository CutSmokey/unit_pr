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
                dtimetb.Text =  Convert.ToString(0);
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
            double worktime = Convert.ToDouble(worktimetb.Text);
            double dtime = Convert.ToDouble(dtimetb.Text);
            double artime = Convert.ToDouble(armtime.Text);
            double multilb = Convert.ToDouble(multilbtb.Text);
            if (worktime <10)
            {
                MessageBox.Show("Ваш трудовой стаж менее 10 лет! Расчёт не возможен");
            }
            if (fmgb.Visible == true && dtime > 6)
            {
                MessageBox.Show("Указан неверный декретный отпуск! Указывается не более 6 лет. Расчёт не возможен");
            }

            res = (worktime*365 + dtime*365 + artime*2*365)/365 * multilb*87.56;
            if (res < 11500)
            {
                rsl.Text = Convert.ToString("Ваша минимальная пенсия составит = 11500");
            }
            else
            {
                rsl.Text = Convert.ToString("Пенсия составит = ") + Convert.ToString(res);
            }
        }

        private void armtime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
