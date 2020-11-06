namespace EFWallpaper
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.常规 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.qipao = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.orangeday = new System.Windows.Forms.TextBox();
            this.redday = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.常规.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(347, 301);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "关于";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(9, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 138);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "4班的主科老师们";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(226, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 102);
            this.label9.TabIndex = 3;
            this.label9.Text = "历史：\r\n李老师\r\n地理：\r\n孙老师\r\n生物：\r\n周老师、杨老师";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 102);
            this.label6.TabIndex = 1;
            this.label6.Text = "化学：\r\n陈老师\r\n物理：\r\n郑老师\r\n政治：\r\n张老师、叶老师";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 102);
            this.label5.TabIndex = 0;
            this.label5.Text = "语文：\r\n梁老师、谢老师\r\n数学：\r\n陈老师、王老师\r\n英语：\r\n游老师\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(95, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "开放源代码-若需二次使用";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(42, 283);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(258, 17);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/LunaroakF/EFWallpaper";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.Location = new System.Drawing.Point(6, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 301);
            this.label1.TabIndex = 1;
            this.label1.Text = "此软件负责为2017级4班中考倒计时壁纸的每日自动更换工作\r\n壁纸存储于C:/Wallpapers\r\n软件在沙市六中一体机被使用\r\n程序运行时会故意延迟10秒再运" +
    "行以确保图标被正常加载\r\n若要开机自启请手动设置\r\n作者:何狐-GeometryFox\r\n作者:狐冥栎-LunaroakF";
            // 
            // 常规
            // 
            this.常规.Controls.Add(this.label10);
            this.常规.Controls.Add(this.qipao);
            this.常规.Controls.Add(this.button1);
            this.常规.Controls.Add(this.orangeday);
            this.常规.Controls.Add(this.redday);
            this.常规.Controls.Add(this.lb);
            this.常规.Controls.Add(this.label4);
            this.常规.Controls.Add(this.date);
            this.常规.Controls.Add(this.label3);
            this.常规.Location = new System.Drawing.Point(4, 26);
            this.常规.Name = "常规";
            this.常规.Padding = new System.Windows.Forms.Padding(3);
            this.常规.Size = new System.Drawing.Size(347, 301);
            this.常规.TabIndex = 0;
            this.常规.Text = "常规";
            this.常规.UseVisualStyleBackColor = true;
            this.常规.Click += new System.EventHandler(this.常规_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(4, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(272, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "本次程序启动配置文件出错，配置信息重置过一次";
            this.label10.Visible = false;
            // 
            // qipao
            // 
            this.qipao.AutoSize = true;
            this.qipao.Checked = true;
            this.qipao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.qipao.Location = new System.Drawing.Point(7, 178);
            this.qipao.Name = "qipao";
            this.qipao.Size = new System.Drawing.Size(229, 21);
            this.qipao.TabIndex = 6;
            this.qipao.Text = "操作后显示右下角气泡/弹窗/图标提醒\r\n";
            this.qipao.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "保存修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // orangeday
            // 
            this.orangeday.Location = new System.Drawing.Point(7, 135);
            this.orangeday.Name = "orangeday";
            this.orangeday.Size = new System.Drawing.Size(130, 23);
            this.orangeday.TabIndex = 4;
            this.orangeday.Text = "25";
            // 
            // redday
            // 
            this.redday.Location = new System.Drawing.Point(7, 78);
            this.redday.Name = "redday";
            this.redday.Size = new System.Drawing.Size(130, 23);
            this.redday.TabIndex = 3;
            this.redday.Text = "10";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lb.Location = new System.Drawing.Point(4, 115);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(344, 17);
            this.lb.TabIndex = 5;
            this.lb.Text = "当日期小于多少天时，主界面圆框将为橙色，大于该值则为绿色";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label4.Location = new System.Drawing.Point(4, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "当日期小于多少天时，主界面圆框将为红色";
            // 
            // date
            // 
            this.date.CustomFormat = "";
            this.date.Location = new System.Drawing.Point(7, 23);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(130, 23);
            this.date.TabIndex = 2;
            this.date.Value = new System.DateTime(2020, 11, 6, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label3.Location = new System.Drawing.Point(4, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "中考日期";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.常规);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(355, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EFWallpaper.Properties.Resources.inf;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(208, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 65);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 333);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EFWallpaper - Setting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.常规.ResumeLayout(false);
            this.常规.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage 常规;
        private System.Windows.Forms.TextBox orangeday;
        private System.Windows.Forms.TextBox redday;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox qipao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}