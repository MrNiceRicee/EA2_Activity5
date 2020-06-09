using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {

        public static Stopwatch sw = new Stopwatch();
        int addsec = 0;
        int addmin = 0;
        int addhr = 0;
        int addday = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button sus = (Button)sender;
            if (sus.Equals(this.btn_Start))
            {
                if (!sw.IsRunning)
                {
                    sw.Start();
                    tb_times.Visible = true;
                }
            }
            else if (sus.Equals(this.btn_Stop))
            {
                if (sw.IsRunning)
                {
                    sw.Stop();
                }
            }
            else if (sus.Equals(this.btn_Reset))
            {
                sw.Reset();
                if (sw.IsRunning)
                {
                    tb_times.Visible = false;
                }
            }
            else if (sus.Equals(this.btn_sec))
            {
                if (sw.IsRunning)
                {
                    addsec++;
                }
            }
            else if (sus.Equals(this.btn_min))
            {
                if (sw.IsRunning)
                {
                    addmin++;
                }
            }
            else if (sus.Equals(this.btn_hr))
            {
                if (sw.IsRunning)
                {
                    addhr++;
                }
            }
            else if (sus.Equals(this.btn_day))
            {
                if (sw.IsRunning)
                {
                    addday++;
                }
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            int customelapse=(addsec*1000)+(addmin*60000)+(addhr* 3600000) +(addday* 86400000)+(int)sw.ElapsedMilliseconds;
            if (customelapse < 60000)
            {
                //show only second and mili
                tb_times.Text = String.Format("{0:00}.{1:00}",(sw.Elapsed.Seconds+addsec),(sw.ElapsedMilliseconds));
            }
            else if (customelapse > 60000 && customelapse < 3600000)
            {
                //show min, second and mili
                tb_times.Text = String.Format("{0:00}:{1:00}.{2:00}",(sw.Elapsed.Minutes + addmin), (sw.Elapsed.Seconds + addsec), (sw.Elapsed.Milliseconds));
            }
            else if (customelapse > 3600000 && customelapse < 86400000)
            {
                //show hour, second and mili
                tb_times.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",(sw.Elapsed.Hours + addhr),
                                                (sw.Elapsed.Minutes + addmin), (sw.Elapsed.Seconds + addsec), (sw.Elapsed.Milliseconds));
            }
            else if (customelapse > 86400000)
            {
                //show day, hour, second and mili
                tb_times.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}.{4:00}", (sw.Elapsed.Days + addday), (sw.Elapsed.Hours + addhr),
                                                (sw.Elapsed.Minutes + addmin), (sw.Elapsed.Seconds + addsec), (sw.Elapsed.Milliseconds));
            }
            //decided not to add more because, this is only practice and not sure who would keep a stopwatch running for years. unless someone wants to time their lifetime.
        }
    }
}
