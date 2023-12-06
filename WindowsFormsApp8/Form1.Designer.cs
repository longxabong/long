using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsApp8
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txbDetail = new System.Windows.Forms.TextBox();
            this.rtbDetail = new System.Windows.Forms.RichTextBox();
            this.lbNhapDiaDiem = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.Location2 = new System.Windows.Forms.TextBox();
            this.Location1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MLocation5 = new System.Windows.Forms.Label();
            this.MLocation18 = new System.Windows.Forms.Label();
            this.MLocation17 = new System.Windows.Forms.Label();
            this.MLocation15 = new System.Windows.Forms.Label();
            this.MLocation19 = new System.Windows.Forms.Label();
            this.MLocation13 = new System.Windows.Forms.Label();
            this.MLocation14 = new System.Windows.Forms.Label();
            this.MLocation3 = new System.Windows.Forms.Label();
            this.MLocation6 = new System.Windows.Forms.Label();
            this.MLocation4 = new System.Windows.Forms.Label();
            this.MLocation8 = new System.Windows.Forms.Label();
            this.MLocation16 = new System.Windows.Forms.Label();
            this.MLocation2 = new System.Windows.Forms.Label();
            this.MLocation1 = new System.Windows.Forms.Label();
            this.MLocation11 = new System.Windows.Forms.Label();
            this.MLocation10 = new System.Windows.Forms.Label();
            this.MLocation12 = new System.Windows.Forms.Label();
            this.MLocation0 = new System.Windows.Forms.Label();
            this.MLocation9 = new System.Windows.Forms.Label();
            this.MLocation7 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.splitContainer1.Panel1.Controls.Add(this.txbDetail);
            this.splitContainer1.Panel1.Controls.Add(this.rtbDetail);
            this.splitContainer1.Panel1.Controls.Add(this.lbNhapDiaDiem);
            this.splitContainer1.Panel1.Controls.Add(this.Search);
            this.splitContainer1.Panel1.Controls.Add(this.Location2);
            this.splitContainer1.Panel1.Controls.Add(this.Location1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonExit);
            this.splitContainer1.Size = new System.Drawing.Size(1772, 853);
            this.splitContainer1.SplitterDistance = 590;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // txbDetail
            // 
            this.txbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbDetail.Location = new System.Drawing.Point(111, 422);
            this.txbDetail.Name = "txbDetail";
            this.txbDetail.Size = new System.Drawing.Size(177, 34);
            this.txbDetail.TabIndex = 9;
            this.txbDetail.Text = "Chi tiết địa điểm";
            // 
            // rtbDetail
            // 
            this.rtbDetail.Location = new System.Drawing.Point(111, 465);
            this.rtbDetail.Name = "rtbDetail";
            this.rtbDetail.Size = new System.Drawing.Size(348, 190);
            this.rtbDetail.TabIndex = 8;
            this.rtbDetail.Text = "";
            // 
            // lbNhapDiaDiem
            // 
            this.lbNhapDiaDiem.AutoSize = true;
            this.lbNhapDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhapDiaDiem.Location = new System.Drawing.Point(77, 199);
            this.lbNhapDiaDiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNhapDiaDiem.Name = "lbNhapDiaDiem";
            this.lbNhapDiaDiem.Size = new System.Drawing.Size(392, 31);
            this.lbNhapDiaDiem.TabIndex = 7;
            this.lbNhapDiaDiem.Text = "Hãy nhập địa điểm bạn muốn đi";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.LightGray;
            this.Search.ForeColor = System.Drawing.Color.Red;
            this.Search.Location = new System.Drawing.Point(407, 275);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(131, 54);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Location2
            // 
            this.Location2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location2.Location = new System.Drawing.Point(111, 315);
            this.Location2.Margin = new System.Windows.Forms.Padding(4);
            this.Location2.Multiline = true;
            this.Location2.Name = "Location2";
            this.Location2.Size = new System.Drawing.Size(268, 40);
            this.Location2.TabIndex = 5;
            // 
            // Location1
            // 
            this.Location1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location1.Location = new System.Drawing.Point(111, 240);
            this.Location1.Margin = new System.Windows.Forms.Padding(4);
            this.Location1.Multiline = true;
            this.Location1.Name = "Location1";
            this.Location1.Size = new System.Drawing.Size(268, 40);
            this.Location1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(105, 378);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Distance: 0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(103, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "DIJKSTRA ALGORITHM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(167, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.MLocation5);
            this.panel1.Controls.Add(this.MLocation18);
            this.panel1.Controls.Add(this.MLocation17);
            this.panel1.Controls.Add(this.MLocation15);
            this.panel1.Controls.Add(this.MLocation19);
            this.panel1.Controls.Add(this.MLocation13);
            this.panel1.Controls.Add(this.MLocation14);
            this.panel1.Controls.Add(this.MLocation3);
            this.panel1.Controls.Add(this.MLocation6);
            this.panel1.Controls.Add(this.MLocation4);
            this.panel1.Controls.Add(this.MLocation8);
            this.panel1.Controls.Add(this.MLocation16);
            this.panel1.Controls.Add(this.MLocation2);
            this.panel1.Controls.Add(this.MLocation1);
            this.panel1.Controls.Add(this.MLocation11);
            this.panel1.Controls.Add(this.MLocation10);
            this.panel1.Controls.Add(this.MLocation12);
            this.panel1.Controls.Add(this.MLocation0);
            this.panel1.Controls.Add(this.MLocation9);
            this.panel1.Controls.Add(this.MLocation7);
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.button18);
            this.panel1.Controls.Add(this.button17);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button0);
            this.panel1.Location = new System.Drawing.Point(38, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 788);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MLocation5
            // 
            this.MLocation5.AutoSize = true;
            this.MLocation5.BackColor = System.Drawing.Color.Transparent;
            this.MLocation5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation5.Location = new System.Drawing.Point(169, 574);
            this.MLocation5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLocation5.Name = "MLocation5";
            this.MLocation5.Size = new System.Drawing.Size(120, 20);
            this.MLocation5.TabIndex = 41;
            this.MLocation5.Text = "Hồ bơi Phú Lợi";
            // 
            // MLocation18
            // 
            this.MLocation18.AutoSize = true;
            this.MLocation18.BackColor = System.Drawing.Color.Transparent;
            this.MLocation18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation18.Location = new System.Drawing.Point(788, 597);
            this.MLocation18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLocation18.Name = "MLocation18";
            this.MLocation18.Size = new System.Drawing.Size(115, 20);
            this.MLocation18.TabIndex = 40;
            this.MLocation18.Text = "Katinat Coffee";
            // 
            // MLocation17
            // 
            this.MLocation17.AutoSize = true;
            this.MLocation17.BackColor = System.Drawing.Color.Transparent;
            this.MLocation17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation17.Location = new System.Drawing.Point(715, 683);
            this.MLocation17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLocation17.Name = "MLocation17";
            this.MLocation17.Size = new System.Drawing.Size(134, 20);
            this.MLocation17.TabIndex = 39;
            this.MLocation17.Text = "KDL Tháp Chàm";
            // 
            // MLocation15
            // 
            this.MLocation15.AutoSize = true;
            this.MLocation15.BackColor = System.Drawing.Color.Transparent;
            this.MLocation15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation15.Location = new System.Drawing.Point(643, 473);
            this.MLocation15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLocation15.Name = "MLocation15";
            this.MLocation15.Size = new System.Drawing.Size(142, 20);
            this.MLocation15.TabIndex = 38;
            this.MLocation15.Text = "Quán ăn Gia Đình";
            // 
            // MLocation19
            // 
            this.MLocation19.AutoSize = true;
            this.MLocation19.BackColor = System.Drawing.Color.Transparent;
            this.MLocation19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation19.Location = new System.Drawing.Point(769, 373);
            this.MLocation19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLocation19.Name = "MLocation19";
            this.MLocation19.Size = new System.Drawing.Size(129, 20);
            this.MLocation19.TabIndex = 37;
            this.MLocation19.Text = "Highland Coffee";
            // 
            // MLocation13
            // 
            this.MLocation13.AutoSize = true;
            this.MLocation13.BackColor = System.Drawing.Color.Transparent;
            this.MLocation13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation13.Location = new System.Drawing.Point(687, 192);
            this.MLocation13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLocation13.Name = "MLocation13";
            this.MLocation13.Size = new System.Drawing.Size(146, 20);
            this.MLocation13.TabIndex = 36;
            this.MLocation13.Text = "Nhà nghỉ Mộc Sơn";
            // 
            // MLocation14
            // 
            this.MLocation14.AutoSize = true;
            this.MLocation14.BackColor = System.Drawing.Color.Transparent;
            this.MLocation14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation14.Location = new System.Drawing.Point(623, 329);
            this.MLocation14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLocation14.Name = "MLocation14";
            this.MLocation14.Size = new System.Drawing.Size(167, 20);
            this.MLocation14.TabIndex = 35;
            this.MLocation14.Text = "Nhà thờ Vĩnh Nghiêm";
            // 
            // MLocation3
            // 
            this.MLocation3.AutoSize = true;
            this.MLocation3.BackColor = System.Drawing.Color.Transparent;
            this.MLocation3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation3.Location = new System.Drawing.Point(473, 334);
            this.MLocation3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLocation3.Name = "MLocation3";
            this.MLocation3.Size = new System.Drawing.Size(109, 20);
            this.MLocation3.TabIndex = 34;
            this.MLocation3.Text = "Công viên B5";
            // 
            // MLocation6
            // 
            this.MLocation6.AutoSize = true;
            this.MLocation6.BackColor = System.Drawing.Color.Transparent;
            this.MLocation6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation6.Location = new System.Drawing.Point(49, 501);
            this.MLocation6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLocation6.Name = "MLocation6";
            this.MLocation6.Size = new System.Drawing.Size(151, 20);
            this.MLocation6.TabIndex = 33;
            this.MLocation6.Text = "Hồ câu cá Đinh Ba";
            // 
            // MLocation4
            // 
            this.MLocation4.AutoSize = true;
            this.MLocation4.BackColor = System.Drawing.Color.Transparent;
            this.MLocation4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation4.Location = new System.Drawing.Point(61, 370);
            this.MLocation4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLocation4.Name = "MLocation4";
            this.MLocation4.Size = new System.Drawing.Size(164, 20);
            this.MLocation4.TabIndex = 32;
            this.MLocation4.Text = "Nhà hàng Đại Dương";
            // 
            // MLocation8
            // 
            this.MLocation8.AutoSize = true;
            this.MLocation8.BackColor = System.Drawing.Color.Transparent;
            this.MLocation8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation8.Location = new System.Drawing.Point(108, 203);
            this.MLocation8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLocation8.Name = "MLocation8";
            this.MLocation8.Size = new System.Drawing.Size(181, 20);
            this.MLocation8.TabIndex = 31;
            this.MLocation8.Text = "Phố đi bộ Phan Văn Trị";
            // 
            // MLocation16
            // 
            this.MLocation16.AutoSize = true;
            this.MLocation16.BackColor = System.Drawing.Color.Transparent;
            this.MLocation16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation16.Location = new System.Drawing.Point(473, 756);
            this.MLocation16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLocation16.Name = "MLocation16";
            this.MLocation16.Size = new System.Drawing.Size(208, 20);
            this.MLocation16.TabIndex = 30;
            this.MLocation16.Text = "Khu công nghiệp Biên Hòa";
            // 
            // MLocation2
            // 
            this.MLocation2.AutoSize = true;
            this.MLocation2.BackColor = System.Drawing.Color.Transparent;
            this.MLocation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation2.Location = new System.Drawing.Point(399, 709);
            this.MLocation2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLocation2.Name = "MLocation2";
            this.MLocation2.Size = new System.Drawing.Size(130, 20);
            this.MLocation2.TabIndex = 29;
            this.MLocation2.Text = "Trendora Coffee";
            // 
            // MLocation1
            // 
            this.MLocation1.AutoSize = true;
            this.MLocation1.BackColor = System.Drawing.Color.Transparent;
            this.MLocation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation1.Location = new System.Drawing.Point(269, 683);
            this.MLocation1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLocation1.Name = "MLocation1";
            this.MLocation1.Size = new System.Drawing.Size(139, 20);
            this.MLocation1.TabIndex = 28;
            this.MLocation1.Text = "Nhà hàng Cù Lao";
            // 
            // MLocation11
            // 
            this.MLocation11.AutoSize = true;
            this.MLocation11.BackColor = System.Drawing.Color.Transparent;
            this.MLocation11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation11.Location = new System.Drawing.Point(489, 203);
            this.MLocation11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLocation11.Name = "MLocation11";
            this.MLocation11.Size = new System.Drawing.Size(118, 20);
            this.MLocation11.TabIndex = 27;
            this.MLocation11.Text = "Thảo cầm viên";
            // 
            // MLocation10
            // 
            this.MLocation10.AutoSize = true;
            this.MLocation10.BackColor = System.Drawing.Color.Transparent;
            this.MLocation10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation10.Location = new System.Drawing.Point(387, 161);
            this.MLocation10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLocation10.Name = "MLocation10";
            this.MLocation10.Size = new System.Drawing.Size(120, 20);
            this.MLocation10.TabIndex = 26;
            this.MLocation10.Text = "Vincom Center";
            // 
            // MLocation12
            // 
            this.MLocation12.AutoSize = true;
            this.MLocation12.BackColor = System.Drawing.Color.Transparent;
            this.MLocation12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation12.Location = new System.Drawing.Point(561, 60);
            this.MLocation12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLocation12.Name = "MLocation12";
            this.MLocation12.Size = new System.Drawing.Size(120, 20);
            this.MLocation12.TabIndex = 25;
            this.MLocation12.Text = "KDL Cửu Long";
            // 
            // MLocation0
            // 
            this.MLocation0.AutoSize = true;
            this.MLocation0.BackColor = System.Drawing.Color.Transparent;
            this.MLocation0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation0.Location = new System.Drawing.Point(321, 478);
            this.MLocation0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLocation0.Name = "MLocation0";
            this.MLocation0.Size = new System.Drawing.Size(107, 20);
            this.MLocation0.TabIndex = 24;
            this.MLocation0.Text = "CGV Cinema";
            // 
            // MLocation9
            // 
            this.MLocation9.AutoSize = true;
            this.MLocation9.BackColor = System.Drawing.Color.Transparent;
            this.MLocation9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation9.Location = new System.Drawing.Point(217, 137);
            this.MLocation9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLocation9.Name = "MLocation9";
            this.MLocation9.Size = new System.Drawing.Size(142, 20);
            this.MLocation9.TabIndex = 23;
            this.MLocation9.Text = "Quảng trường tỉnh";
            // 
            // MLocation7
            // 
            this.MLocation7.AutoSize = true;
            this.MLocation7.BackColor = System.Drawing.Color.Transparent;
            this.MLocation7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation7.Location = new System.Drawing.Point(308, 265);
            this.MLocation7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLocation7.Name = "MLocation7";
            this.MLocation7.Size = new System.Drawing.Size(163, 20);
            this.MLocation7.TabIndex = 22;
            this.MLocation7.Text = "Trung tâm thành phố";
            // 
            // button19
            // 
            this.button19.AutoSize = true;
            this.button19.BackColor = System.Drawing.Color.Transparent;
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button19.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button19.Location = new System.Drawing.Point(823, 396);
            this.button19.Margin = new System.Windows.Forms.Padding(4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(56, 48);
            this.button19.TabIndex = 21;
            this.button19.Text = "☻";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button21_Click);
            this.button19.Tag = " COM GA XOI MO \n CAM TAM BA GHIEN \n BANH CANH CA LOC";
            // 
            // button18
            // 
            this.button18.AutoSize = true;
            this.button18.BackColor = System.Drawing.Color.Transparent;
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button18.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button18.Location = new System.Drawing.Point(823, 550);
            this.button18.Margin = new System.Windows.Forms.Padding(4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(56, 48);
            this.button18.TabIndex = 20;
            this.button18.Text = "☻";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button20_Click);
            this.button18.Tag = "CUA HANG NOI THAT \n DIAN MAY XANH \n  FPT SHOP";
            // 
            // button17
            // 
            this.button17.AutoSize = true;
            this.button17.BackColor = System.Drawing.Color.Transparent;
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button17.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button17.Location = new System.Drawing.Point(719, 645);
            this.button17.Margin = new System.Windows.Forms.Padding(4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(56, 48);
            this.button17.TabIndex = 19;
            this.button17.Text = "☻";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button19_Click);
            this.button17.Tag = " DAI HOC KINH TE TPHCM CS A \n BANH CANH CUA DI BA \n PET SHOP";
            // 
            // button16
            // 
            this.button16.AutoSize = true;
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button16.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button16.Location = new System.Drawing.Point(565, 709);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(56, 48);
            this.button16.TabIndex = 18;
            this.button16.Text = "☻";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button18_Click);
            this.button16.Tag = " BUN BO VUONG \n MI TRON CO HUYEN";
            // 
            // button15
            // 
            this.button15.AutoSize = true;
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button15.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button15.Location = new System.Drawing.Point(691, 496);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(56, 48);
            this.button15.TabIndex = 17;
            this.button15.Text = "☻";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button17_Click);
            this.button15.Tag = " NHA SACH LONGLE \n RAP CGV";
            // 
            // button14
            // 
            this.button14.AutoSize = true;
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button14.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button14.Location = new System.Drawing.Point(673, 345);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(56, 48);
            this.button14.TabIndex = 16;
            this.button14.Text = "☻";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button16_Click);
            this.button14.Tag = " QUAN NUOC TRIEU KHUC \n NHU YEU PHAM";
            // 
            // button13
            // 
            this.button13.AutoSize = true;
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button13.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button13.Location = new System.Drawing.Point(705, 214);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(56, 48);
            this.button13.TabIndex = 15;
            this.button13.Text = "☻";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button15_Click);
            this.button13.Tag = " BANH CANH CA LOC \n BUN THIT NUONG KIEU BAO";
            // 
            // button12
            // 
            this.button12.AutoSize = true;
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button12.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button12.Location = new System.Drawing.Point(585, 79);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(56, 48);
            this.button12.TabIndex = 14;
            this.button12.Text = "☻";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button14_Click);
            this.button12.Tag = " BUN MAM MIEN TAY \n BIDA 79";
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button11.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button11.Location = new System.Drawing.Point(523, 214);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(56, 48);
            this.button11.TabIndex = 13;
            this.button11.Text = "☻";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button13_Click);
            this.button11.Tag = " BANH UOT LONG GA \n BANH TRANG TAY NINH";
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button10.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button10.Location = new System.Drawing.Point(425, 169);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(56, 48);
            this.button10.TabIndex = 12;
            this.button10.Text = "☻";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button12_Click);
            this.button10.Tag = " PHIM TRUONG \n PHO DI BO SE001";
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button9.Location = new System.Drawing.Point(275, 148);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 48);
            this.button9.TabIndex = 11;
            this.button9.Text = "☻";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button11_Click);
            this.button9.Tag = " NHA HANG TUBAO \n TEO EM COFFEE";
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button8.Location = new System.Drawing.Point(173, 214);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 48);
            this.button8.TabIndex = 10;
            this.button8.Text = "☻";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button10_Click);
            this.button8.Tag = " QUAN NET LONGCHAU\n BIDA KYTHUATPHANMEM";
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button7.Location = new System.Drawing.Point(364, 287);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 48);
            this.button7.TabIndex = 9;
            this.button7.Text = "☻";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button9_Click);
            this.button7.Tag = " SAN BAY LONG THANH \n BEN XE AN SUONG";
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button6.Location = new System.Drawing.Point(112, 454);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 48);
            this.button6.TabIndex = 8;
            this.button6.Text = "☻";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button8_Click);
            this.button6.Tag = " THE GIOI DI DONG \n DIEN MAY XANH";
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button5.Location = new System.Drawing.Point(192, 534);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 48);
            this.button5.TabIndex = 7;
            this.button5.Text = "☻";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button7_Click);
            this.button5.Tag = " SHOP DO DIEN TU \n NOI THAT DECOR";
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(128, 329);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 48);
            this.button4.TabIndex = 6;
            this.button4.Text = "☻";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button6_Click);
            this.button4.Tag = " NHA NGHI TUY ANH \n KHACH SAN SAOCUNGDUOC";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(503, 357);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 48);
            this.button3.TabIndex = 5;
            this.button3.Tag = " CHO NOI CAI RANG \n CHUA THIEN MU";
            this.button3.Text = "☻";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(440, 670);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 48);
            this.button2.TabIndex = 4;
            this.button2.Tag = " CHAO LONG PHUNGCHAU \n BUN MAM NEM THIENBAO";
            this.button2.Text = "☻";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(312, 645);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 48);
            this.button1.TabIndex = 3;
            this.button1.Tag = " CHAO LONG ANH LONG \n HADILAO LONGXABONG";
            this.button1.Text = "☻";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // button0
            // 
            this.button0.AutoSize = true;
            this.button0.BackColor = System.Drawing.Color.Transparent;
            this.button0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button0.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.button0.FlatAppearance.BorderSize = 0;
            this.button0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button0.Location = new System.Drawing.Point(343, 496);
            this.button0.Margin = new System.Windows.Forms.Padding(4);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(56, 48);
            this.button0.TabIndex = 2;
            this.button0.Tag = " XE OM SHOP \n MY CAY 7 CAP DO";
            this.button0.Text = "☻";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Verdana", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonExit.Location = new System.Drawing.Point(1121, 0);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(55, 52);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1772, 853);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button0;
        public System.Windows.Forms.Panel panel1;
        static public void Painting(Graphics g, int a, int b, int c, int d)
        {
            Pen blackPen = new Pen(Color.MediumBlue, 3);
            Point point1 = new Point(a, b);
            Point point2 = new Point(c, d);
            g.DrawLine(blackPen, point1, point2);
        }
        static public void Marking(Graphics g, int a, int b, int c, int d)
        {
            Pen blackPen = new Pen(Color.Red, 5);
            Point point1 = new Point(a, b);
            Point point2 = new Point(c, d);
            g.DrawLine(blackPen, point1, point2);
        }
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private TextBox Location1;
        private Label MLocation7;
        private TextBox Location2;
        private Label MLocation9;
        private Button Search;
        private Label MLocation0;
        private Label lbNhapDiaDiem;
        private Label MLocation12;
        private Label MLocation5;
        private Label MLocation18;
        private Label MLocation17;
        private Label MLocation15;
        private Label MLocation19;
        private Label MLocation13;
        private Label MLocation14;
        private Label MLocation3;
        private Label MLocation6;
        private Label MLocation4;
        private Label MLocation8;
        private Label MLocation16;
        private Label MLocation2;
        private Label MLocation1;
        private Label MLocation11;
        private Label MLocation10;
        private TextBox txbDetail;
        public RichTextBox rtbDetail;
    }
}

