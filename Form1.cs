using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;


namespace EFWallpaper
{
   
    public partial class Form1 : Form
    {
        string Road = "C:\\Wallpapers";
        string testtime = "2020-7-20";//考试日期，请在Form1和2中同时修改变量以及Form2GUI中的考试时间



        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        public static extern int SystemParametersInfo(
        int uAction,
        int uParam,
        string lpvParam,
        int fuWinIni
);
        public Form1()
        {
            InitializeComponent();
        }
   
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(10000);//一体机开机是真的慢 有时候图标加载不出来所以延时10秒了
            notifyIcon1.Visible = true;
            try
            {
                changewall(Road, datecompare());
            }
           catch
            {
                if (datecompare() >= 0 && datecompare() <= 28)
                {
                    notifyIcon1.ShowBalloonTip(5000, "壁纸自动更换", "壁纸更换失败"+ System.Environment.NewLine + "可能是" + datecompare().ToString() + ".png文件丢失", ToolTipIcon.Error);
                    notifyIcon1.Icon = Properties.Resources.yh_error;
                    notifyIcon1.Text = "Wallpaper - 更换时出现问题";
                }
                else {
                    notifyIcon1.ShowBalloonTip(5000, "壁纸自动更换", "壁纸更换失败" + System.Environment.NewLine + "可能是" + "NULL"+ ".png文件丢失", ToolTipIcon.Error);
                    notifyIcon1.Icon = Properties.Resources.yh_error;
                    notifyIcon1.Text = "Wallpaper - 更换时出现问题";
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
        public int datecompare()
        {
            DateTime datenow = Convert.ToDateTime(DateTime.Now.ToShortDateString().ToString());
            DateTime dateshould = Convert.ToDateTime(testtime);
            TimeSpan span = dateshould.Subtract(datenow);
            int dayoff = span.Days;
            return dayoff;
        }

        public void changewall(string pngroad, int pngnumber)
        {
            if (pngnumber >= 0 && pngnumber <= 28)
            {
                Image image = Image.FromFile(pngroad + "/" + pngnumber.ToString() + ".png");
                image.Save(pngroad + "/" + "now.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                SystemParametersInfo(20, 0, pngroad + "/" + "now.bmp", 0x2);
            }
            else
            {
                Image image = Image.FromFile(pngroad + "/" + "NULL" + ".png");
                image.Save(pngroad + "/" + "now.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                SystemParametersInfo(20, 0, pngroad + "/" + "now.bmp", 0x2);
            }
            this.notifyIcon1.ShowBalloonTip(5000, "壁纸自动更换", "壁纸更换成功，参数值为" + datecompare().ToString()+"天", ToolTipIcon.Info);
            notifyIcon1.Icon = Properties.Resources.yhf;
            notifyIcon1.Text = "Wallpaper";
        }



        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Hide();    }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            
            if (!bools.form2created)
            {
                Form2 form2 = new Form2(this);
                form2.Show();
                bools.form2created = true;
            }
        }


    }
}
