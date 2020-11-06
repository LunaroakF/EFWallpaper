using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace EFWallpaper
{
    public partial class Form2 : Form
    {
        string Road = "C:\\Wallpapers";


        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        public static extern int SystemParametersInfo(
        int uAction,
        int uParam,
        string lpvParam,
         int fuWinIni
 );
        public Form1 frm;
        public Form2(Form1 form1)
        {
            frm = form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            label2.Text = "目标日:" + bools.testtime;
            label1.Text = "中考剩余日期:" + datecompare().ToString()+"天";
            bt3cg(datecompare());
        }
        public void bt3cg(int nb) {
            if (nb < 1000 && nb >= 0)
            {
                button3.Text = nb.ToString();
                if (nb < bools.reddays)
                {
                    button3.BackgroundImage = Properties.Resources.red;
                }
                else if (nb < bools.orangedays)
                {
                    button3.BackgroundImage = Properties.Resources.yellow;
                }
                else if (nb >= bools.orangedays)
                { 
                    button3.BackgroundImage = Properties.Resources.green;
                }
            }
            else if (nb < 0)
            {
                button3.Text = "0";
                if (nb < bools.reddays)
                {
                    button3.BackgroundImage = Properties.Resources.red;
                }
                else if (nb < bools.orangedays)
                {
                    button3.BackgroundImage = Properties.Resources.yellow;
                }
                else if (nb >= bools.orangedays)
                {
                    button3.BackgroundImage = Properties.Resources.green;
                }
            }
            else
            {
                button3.Text = "999";
                if (nb < bools.reddays)
                {
                    button3.BackgroundImage = Properties.Resources.red;
                }
                else if (nb < bools.orangedays)
                {
                    button3.BackgroundImage = Properties.Resources.yellow;
                }
                else if (nb >= bools.orangedays)
                {
                    button3.BackgroundImage = Properties.Resources.green;
                }
            }
        }
        public int datecompare()
        {
            DateTime datenow = Convert.ToDateTime(DateTime.Now.ToShortDateString().ToString());
            DateTime dateshould = Convert.ToDateTime(bools.testtime);
            TimeSpan span = dateshould.Subtract(datenow);
            int dayoff = span.Days;
            return dayoff;
        }
        public void changewall(string pngroad, int pngnumber)
        {
            if (pngnumber >= 0)//&&pngnumber<=28)
            {
                Image image = Image.FromFile(pngroad + "/" + pngnumber.ToString() + ".png");
                image.Save(pngroad + "/" + "now.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                SystemParametersInfo(20, 0, pngroad + "/" + "now.bmp", 0x2);
            }
            else {
                Image image = Image.FromFile(pngroad + "/" + "NULL" + ".png");
                image.Save(pngroad + "/" + "now.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                SystemParametersInfo(20, 0, pngroad + "/" + "now.bmp", 0x2);
            }
            if (bools.qipao)
            {
                frm.notifyIcon1.ShowBalloonTip(5000, "壁纸自动更换", "壁纸更换成功，参数值为" + datecompare().ToString(), ToolTipIcon.Info);
                frm.notifyIcon1.Icon = Properties.Resources.yhf;
                frm.notifyIcon1.Text = "Wallpaper";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = false;
                button1.Text = "处理中";
                label2.Text = "目标日:" + bools.testtime;
                bt3cg(datecompare());

                Thread thread = new Thread(new ThreadStart(changewalluser));
                thread.Start();
            }
            catch
            {
                if (bools.qipao)
                {
                    frm.notifyIcon1.ShowBalloonTip(5000, "壁纸自动更换", "壁纸更换失败" + System.Environment.NewLine + "可能是" + datecompare().ToString() + ".png文件丢失", ToolTipIcon.Error);
                    frm.notifyIcon1.Icon = Properties.Resources.yh_error;
                    frm.notifyIcon1.Text = "Wallpaper - 更换时出现问题";
                }
            }
        }

        public void changewalluser()
        {
            label1.Text = "中考剩余日期:" + datecompare().ToString() + "天";
            bt3cg(datecompare());
            try
            {
                changewall(Road, datecompare());
                button1.Text = "已更新";
                System.Threading.Thread.Sleep(1000);
            }
            catch {
                button1.Text = "失败";
                if (datecompare() >= 0)// && datecompare() <= 28)
                {
                    if (bools.qipao)
                    {
                        frm.notifyIcon1.ShowBalloonTip(5000, "壁纸自动更换", "壁纸更换失败" + System.Environment.NewLine + "可能是" + datecompare().ToString() + ".png文件丢失", ToolTipIcon.Error);
                        frm.notifyIcon1.Icon = Properties.Resources.yh_error;
                        frm.notifyIcon1.Text = "Wallpaper - 更换时出现问题";
                    }
                }
                else
                {
                    if (bools.qipao)
                    {
                        frm.notifyIcon1.ShowBalloonTip(5000, "壁纸自动更换", "壁纸更换失败" + System.Environment.NewLine + "可能是" + "NULL" + ".png文件丢失", ToolTipIcon.Error);
                        frm.notifyIcon1.Icon = Properties.Resources.yh_error;
                        frm.notifyIcon1.Text = "Wallpaper - 更换时出现问题";
                    }
                }
                System.Threading.Thread.Sleep(1000);
            }
                button1.Text = "立即刷新";
                button1.Enabled = true;
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            if (!bools.form4created)
            {
                form4.Show();
                bools.form4created = true;
                
            }
            this.Close();
        }
        public Form1 F1;
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            bools.form2created = false;
            
        }
    }
}
