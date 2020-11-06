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
        //默认值
        string destination = "2020年7月20日";
        string red = "10";
        string orange = "25";
        string qipao = "true";



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

            if (File.Exists(bools.setting+ "/")==false) //检测是否存在程序数据目录
            {
                Directory.CreateDirectory(bools.setting);//当前路径下创建一个
            }
            if (File.Exists(bools.setting + "/setting"))//检测配置文件是否存在
            {
                List<string> listLines = new List<string>();
                using (StreamReader reader = new StreamReader(bools.setting + "/setting"))
                {
                    string post = reader.ReadLine();
                    reader.Close();
                    string[] b = post.Split(';');
                    try
                    {
                        bools.testtime = b[0];
                        bools.reddays = Convert.ToInt32(b[1]);
                        bools.orangedays = Convert.ToInt32(b[2]);
                        if (b[3] == "true")
                        {
                            bools.qipao = true;
                        }
                        else if (b[3] == "false")
                        {
                            bools.qipao = false;
                        }
                        else {
                            bools.testtime = destination;
                            bools.reddays = Convert.ToInt32(red);
                            bools.orangedays = Convert.ToInt32(orange);
                            bools.qipao = true;
                            System.IO.File.WriteAllText(bools.setting + "/setting", destination + ";" + red + ";" + orange+";"+"true", Encoding.UTF8);//不存在                
                            MessageBox.Show("配置文件出现问题，已经重置", "EFWallpaper", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            bools.error = true;

                        }
                        if (Convert.ToInt32(b[2]) <= Convert.ToInt32(b[1]))
                        {
                            bools.testtime = destination;
                            bools.reddays = Convert.ToInt32(red);
                            bools.orangedays = Convert.ToInt32(orange);
                            System.IO.File.WriteAllText(bools.setting + "/setting", destination + ";" + red + ";" + orange+";"+"true", Encoding.UTF8);//不存在                
                            MessageBox.Show("配置文件出现问题，已经重置", "EFWallpaper", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            bools.error = true;
                        }
                    }
                    catch {
                        bools.testtime = destination;
                        bools.reddays = Convert.ToInt32(red);
                        bools.orangedays = Convert.ToInt32(orange);
                        System.IO.File.WriteAllText(bools.setting + "/setting", destination + ";" + red + ";" + orange+";"+"true", Encoding.UTF8);//不存在                
                        MessageBox.Show("配置文件出现问题，已经重置", "EFWallpaper", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        bools.error = true;
                    }

                }
            }
            else
            {
                bools.testtime = destination;
                bools.reddays = Convert.ToInt32(red);
                bools.orangedays = Convert.ToInt32(orange);
                System.IO.File.WriteAllText(bools.setting + "/setting", destination+";"+red+";"+orange+";"+"true", Encoding.UTF8);//不存在                
            }
            











            notifyIcon1.Visible = true;
            try
            {
                changewall(Road, datecompare());
            }
           catch
            {
                if (datecompare() >= 0)// && datecompare() <= 28)
                {
                    if (bools.qipao)
                    {
                        notifyIcon1.ShowBalloonTip(5000, "壁纸自动更换", "壁纸更换失败" + System.Environment.NewLine + "可能是" + datecompare().ToString() + ".png文件丢失", ToolTipIcon.Error);
                        notifyIcon1.Icon = Properties.Resources.yh_error;
                        notifyIcon1.Text = "Wallpaper - 更换时出现问题";
                    }
                }
                else {
                    if (bools.qipao)
                    {
                        notifyIcon1.ShowBalloonTip(5000, "壁纸自动更换", "壁纸更换失败" + System.Environment.NewLine + "可能是" + "NULL" + ".png文件丢失", ToolTipIcon.Error);
                        notifyIcon1.Icon = Properties.Resources.yh_error;
                        notifyIcon1.Text = "Wallpaper - 更换时出现问题";
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
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
            if (pngnumber >= 0 )//&& pngnumber <= 28)
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
            if (bools.qipao)
            {
                this.notifyIcon1.ShowBalloonTip(5000, "壁纸自动更换", "壁纸更换成功，参数值为" + datecompare().ToString() + "天", ToolTipIcon.Info);
                notifyIcon1.Icon = Properties.Resources.yhf;
                notifyIcon1.Text = "Wallpaper";
            }
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
