using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Microsoft.Win32;
using System.Diagnostics;

namespace EFWallpaper
{
    public partial class Form4 : Form
    {
        public Form1 frm;
        public Form4()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/LunaroakF/EFWallpaper");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label10.Visible = bools.error;
            date.Value = Convert.ToDateTime(bools.testtime);
            redday.Text = bools.reddays.ToString();
            orangeday.Text = bools.orangedays.ToString();
            if (bools.qipao)
            {
                qipao.Checked = true;
            }
            else if (bools.qipao == false)
            {
                qipao.Checked = false;
            }
        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            bools.form4created = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Text = "保存中";

            if (File.Exists(bools.setting + "/") == false) //检测是否存在程序数据目录
            {
                Directory.CreateDirectory(bools.setting);//当前路径下创建一个
            }



            try
            {
                Thread thread = new Thread(new ThreadStart(check));
                thread.Start();
            }
            catch {
                MessageBox.Show("未知错误", "运行检查子程序时出现错误" + Environment.NewLine + "请尝试重启计算机或者软件", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        public void check()
        {
            try
            {
                int aa = Convert.ToInt32(redday.Text);

            }
            catch
            {
                button1.Text = "保存失败";
                MessageBox.Show("红框日期值不为整数", "EFWallpaper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1.Enabled = true;
                button1.Text = "保存修改";
                return;
            }
            try
            {
                int aa = Convert.ToInt32(orangeday.Text);
            }
            catch
            {
                button1.Text = "保存失败";
                MessageBox.Show("橙框日期值不为整数", "EFWallpaper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1.Enabled = true;
                button1.Text = "保存修改";
                return;
            }
            if (Convert.ToInt32(orangeday.Text) <= Convert.ToInt32(redday.Text))
            {
                button1.Text = "保存失败";
                MessageBox.Show("橙框日期值不得小于等于红框日期值", "EFWallpaper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1.Enabled = true;
                button1.Text = "保存修改";
                return;
            }
            if (Convert.ToInt32(orangeday.Text) < 0)
            {
                button1.Text = "保存失败";
                MessageBox.Show("橙框日期值不为非负整数", "EFWallpaper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1.Enabled = true;
                button1.Text = "保存修改";
                return;
            }
            if (Convert.ToInt32(redday.Text) < 0)
            {
                button1.Text = "保存失败";
                MessageBox.Show("红框日期值不为非负整数", "EFWallpaper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1.Enabled = true;
                button1.Text = "保存修改";
                return;
            }

            if (qipao.Checked)
            {
                bools.qipao = true;
            }
            else if (qipao.Checked == false)
            {
                bools.qipao = false;
            }

            string a = date.Text;
            string[] b = a.Split(' ');
            a = b[0];
            bools.testtime = a;
            bools.reddays = Convert.ToInt32(redday.Text);
            bools.orangedays = Convert.ToInt32(orangeday.Text);

            if (bools.qipao)
            {
                System.IO.File.WriteAllText(bools.setting + "/setting", bools.testtime + ";" + bools.reddays.ToString() + ";" + bools.orangedays.ToString() + ";" + "true", Encoding.UTF8);//不存在                
            }
            else {
                System.IO.File.WriteAllText(bools.setting + "/setting", bools.testtime + ";" + bools.reddays.ToString() + ";" + bools.orangedays.ToString() + ";" + "false", Encoding.UTF8);//不存在                
            }

            button1.Text = "保存成功";
            System.Threading.Thread.Sleep(1000);
            button1.Enabled = true;
            button1.Text = "保存修改";

        }

        private void 常规_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/LunaroakF/EFWallpaper");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
