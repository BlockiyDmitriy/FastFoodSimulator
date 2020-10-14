using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodSimulator
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        int timerCount = 0;
        public Form1()
        {
            InitializeComponent(); 
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (btn_start.Text == "Пуск")
            {
                btn_start.Text = "Стоп";
                timer.Start();

            }
            else
            {
                btn_start.Text = "Пуск";
                timer.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            lbl_timer.Text = (++timerCount).ToString();
        }
    }
}
