using DevExpress.Data.PLinq;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DXApplication3
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
            this.components = new System.ComponentModel.Container();
            this.Ayarlar = new DevExpress.XtraEditors.SimpleButton();
            this.SiparisYonetimi = new DevExpress.XtraEditors.SimpleButton();
            this.Planlama = new DevExpress.XtraEditors.SimpleButton();
            this.DepoYonetimi = new DevExpress.XtraEditors.SimpleButton();
            this.Raporlar = new DevExpress.XtraEditors.SimpleButton();
            this.CPS = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton25 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton26 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton12 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton14 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton16 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton37 = new DevExpress.XtraEditors.SimpleButton();
            this.kaliteler = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton15 = new DevExpress.XtraEditors.SimpleButton();
            this.desenler = new DevExpress.XtraEditors.SimpleButton();
            this.renkpaletleri = new DevExpress.XtraEditors.SimpleButton();
            this.renkler = new DevExpress.XtraEditors.SimpleButton();
            this.ebatşekiltanimlari = new DevExpress.XtraEditors.SimpleButton();
            this.ebattiptanimlari = new DevExpress.XtraEditors.SimpleButton();
            this.ebatlar = new DevExpress.XtraEditors.SimpleButton();
            this.kenarformlari = new DevExpress.XtraEditors.SimpleButton();
            this.etiketformlari = new DevExpress.XtraEditors.SimpleButton();
            this.Tanımlamalar = new DevExpress.XtraEditors.SimpleButton();
            this.radialMenu1 = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.sidePanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ayarlar
            // 
            this.Ayarlar.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.Ayarlar.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ayarlar.Appearance.Options.UseBackColor = true;
            this.Ayarlar.Appearance.Options.UseFont = true;
            this.Ayarlar.Location = new System.Drawing.Point(2252, 993);
            this.Ayarlar.Name = "Ayarlar";
            this.Ayarlar.Size = new System.Drawing.Size(156, 106);
            this.Ayarlar.TabIndex = 1;
            this.Ayarlar.Text = "AYARLAR";
            this.Ayarlar.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // SiparisYonetimi
            // 
            this.SiparisYonetimi.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(189)))));
            this.SiparisYonetimi.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiparisYonetimi.Appearance.Options.UseBackColor = true;
            this.SiparisYonetimi.Appearance.Options.UseFont = true;
            this.SiparisYonetimi.Location = new System.Drawing.Point(515, 125);
            this.SiparisYonetimi.Name = "SiparisYonetimi";
            this.SiparisYonetimi.Size = new System.Drawing.Size(505, 306);
            this.SiparisYonetimi.TabIndex = 2;
            this.SiparisYonetimi.Text = "SİPARİŞ YÖNETİMİ";
            this.SiparisYonetimi.Click += new System.EventHandler(this.simpleButton3_Click);
            this.SiparisYonetimi.MouseLeave += new System.EventHandler(this.simpleButton3_MouseLeave);
            this.SiparisYonetimi.MouseHover += new System.EventHandler(this.simpleButton3_MouseHover);
            // 
            // Planlama
            // 
            this.Planlama.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(247)))));
            this.Planlama.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Planlama.Appearance.Options.UseBackColor = true;
            this.Planlama.Appearance.Options.UseFont = true;
            this.Planlama.Location = new System.Drawing.Point(515, 459);
            this.Planlama.Name = "Planlama";
            this.Planlama.Size = new System.Drawing.Size(505, 258);
            this.Planlama.TabIndex = 3;
            this.Planlama.Text = "PLANLAMA";
            this.Planlama.Click += new System.EventHandler(this.simpleButton4_Click);
            this.Planlama.MouseLeave += new System.EventHandler(this.simpleButton4_MouseLeave);
            this.Planlama.MouseHover += new System.EventHandler(this.simpleButton4_MouseHover);
            // 
            // DepoYonetimi
            // 
            this.DepoYonetimi.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(207)))), ((int)(((byte)(243)))));
            this.DepoYonetimi.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepoYonetimi.Appearance.Options.UseBackColor = true;
            this.DepoYonetimi.Appearance.Options.UseFont = true;
            this.DepoYonetimi.Location = new System.Drawing.Point(22, 751);
            this.DepoYonetimi.Name = "DepoYonetimi";
            this.DepoYonetimi.Size = new System.Drawing.Size(453, 273);
            this.DepoYonetimi.TabIndex = 4;
            this.DepoYonetimi.Text = "DEPO YÖNETİMİ ";
            this.DepoYonetimi.Click += new System.EventHandler(this.simpleButton5_Click);
            this.DepoYonetimi.MouseLeave += new System.EventHandler(this.simpleButton5_MouseLeave);
            this.DepoYonetimi.MouseHover += new System.EventHandler(this.simpleButton5_MouseHover);
            // 
            // Raporlar
            // 
            this.Raporlar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.Raporlar.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Raporlar.Appearance.Options.UseBackColor = true;
            this.Raporlar.Appearance.Options.UseFont = true;
            this.Raporlar.Location = new System.Drawing.Point(25, 459);
            this.Raporlar.Name = "Raporlar";
            this.Raporlar.Size = new System.Drawing.Size(450, 258);
            this.Raporlar.TabIndex = 5;
            this.Raporlar.Text = "RAPORLAR";
            this.Raporlar.Click += new System.EventHandler(this.simpleButton6_Click);
            this.Raporlar.MouseLeave += new System.EventHandler(this.simpleButton6_MouseLeave);
            this.Raporlar.MouseHover += new System.EventHandler(this.simpleButton6_MouseHover);
            // 
            // CPS
            // 
            this.CPS.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(206)))), ((int)(((byte)(221)))));
            this.CPS.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPS.Appearance.Options.UseBackColor = true;
            this.CPS.Appearance.Options.UseFont = true;
            this.CPS.Location = new System.Drawing.Point(2105, 993);
            this.CPS.Name = "CPS";
            this.CPS.Size = new System.Drawing.Size(141, 106);
            this.CPS.TabIndex = 6;
            this.CPS.Text = "CPS";
            this.CPS.Click += new System.EventHandler(this.simpleButton7_Click);
            this.CPS.MouseLeave += new System.EventHandler(this.simpleButton7_MouseLeave);
            this.CPS.MouseHover += new System.EventHandler(this.simpleButton7_MouseHover);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.White;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.textBox1);
            this.sidePanel1.Location = new System.Drawing.Point(2205, 81);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(219, 59);
            this.sidePanel1.TabIndex = 7;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(78, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 48);
            this.textBox1.TabIndex = 0;
            // 
            // simpleButton8
            // 
            this.simpleButton8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(139)))), ((int)(((byte)(72)))));
            this.simpleButton8.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton8.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton8.Appearance.Options.UseBackColor = true;
            this.simpleButton8.Appearance.Options.UseFont = true;
            this.simpleButton8.Appearance.Options.UseForeColor = true;
            this.simpleButton8.Location = new System.Drawing.Point(2205, 4);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(232, 71);
            this.simpleButton8.TabIndex = 8;
            this.simpleButton8.Text = "ARAMA";
            this.simpleButton8.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanel1.Controls.Add(this.simpleButton9);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton10);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton11);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton25);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton26);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(2177, 58);
            this.flowLayoutPanel1.TabIndex = 9;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // simpleButton9
            // 
            this.simpleButton9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(206)))), ((int)(((byte)(221)))));
            this.simpleButton9.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton9.Appearance.Options.UseBackColor = true;
            this.simpleButton9.Appearance.Options.UseFont = true;
            this.simpleButton9.Location = new System.Drawing.Point(3, 3);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(375, 55);
            this.simpleButton9.TabIndex = 0;
            this.simpleButton9.Text = "CPS";
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // simpleButton10
            // 
            this.simpleButton10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(222)))));
            this.simpleButton10.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton10.Appearance.Options.UseBackColor = true;
            this.simpleButton10.Appearance.Options.UseFont = true;
            this.simpleButton10.Location = new System.Drawing.Point(384, 3);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Size = new System.Drawing.Size(371, 55);
            this.simpleButton10.TabIndex = 1;
            this.simpleButton10.Text = "MSM";
            this.simpleButton10.Click += new System.EventHandler(this.simpleButton10_Click);
            // 
            // simpleButton11
            // 
            this.simpleButton11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.simpleButton11.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton11.Appearance.Options.UseBackColor = true;
            this.simpleButton11.Appearance.Options.UseFont = true;
            this.simpleButton11.Location = new System.Drawing.Point(761, 3);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(360, 55);
            this.simpleButton11.TabIndex = 2;
            this.simpleButton11.Text = "İDY";
            // 
            // simpleButton25
            // 
            this.simpleButton25.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton25.Appearance.Options.UseFont = true;
            this.simpleButton25.Location = new System.Drawing.Point(1127, 3);
            this.simpleButton25.Name = "simpleButton25";
            this.simpleButton25.Size = new System.Drawing.Size(371, 55);
            this.simpleButton25.TabIndex = 3;
            this.simpleButton25.Text = "XPS";
            // 
            // simpleButton26
            // 
            this.simpleButton26.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton26.Appearance.Options.UseFont = true;
            this.simpleButton26.Location = new System.Drawing.Point(1504, 3);
            this.simpleButton26.Name = "simpleButton26";
            this.simpleButton26.Size = new System.Drawing.Size(371, 55);
            this.simpleButton26.TabIndex = 4;
            this.simpleButton26.Text = "YPS";
            // 
            // simpleButton12
            // 
            this.simpleButton12.Appearance.BackColor = System.Drawing.Color.Indigo;
            this.simpleButton12.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton12.Appearance.Options.UseBackColor = true;
            this.simpleButton12.Appearance.Options.UseFont = true;
            this.simpleButton12.Location = new System.Drawing.Point(122, 132);
            this.simpleButton12.Name = "simpleButton12";
            this.simpleButton12.Size = new System.Drawing.Size(256, 112);
            this.simpleButton12.TabIndex = 12;
            this.simpleButton12.Text = "DEPO KARTLARI";
            this.simpleButton12.Visible = false;
            this.simpleButton12.Click += new System.EventHandler(this.simpleButton12_Click);
            // 
            // simpleButton14
            // 
            this.simpleButton14.Appearance.BackColor = System.Drawing.Color.Indigo;
            this.simpleButton14.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton14.Appearance.Options.UseBackColor = true;
            this.simpleButton14.Appearance.Options.UseFont = true;
            this.simpleButton14.Location = new System.Drawing.Point(122, 135);
            this.simpleButton14.Name = "simpleButton14";
            this.simpleButton14.Size = new System.Drawing.Size(278, 102);
            this.simpleButton14.TabIndex = 13;
            this.simpleButton14.Text = "BİLGİ TANIMLARI";
            this.simpleButton14.Visible = false;
            this.simpleButton14.Click += new System.EventHandler(this.simpleButton14_Click);
            // 
            // simpleButton16
            // 
            this.simpleButton16.Appearance.BackColor = System.Drawing.Color.Indigo;
            this.simpleButton16.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton16.Appearance.Options.UseBackColor = true;
            this.simpleButton16.Appearance.Options.UseFont = true;
            this.simpleButton16.Location = new System.Drawing.Point(120, 120);
            this.simpleButton16.Name = "simpleButton16";
            this.simpleButton16.Size = new System.Drawing.Size(323, 97);
            this.simpleButton16.TabIndex = 15;
            this.simpleButton16.Text = "MÜŞTERİ KARTLARI";
            this.simpleButton16.Visible = false;
            this.simpleButton16.Click += new System.EventHandler(this.simpleButton16_Click);
            // 
            // simpleButton37
            // 
            this.simpleButton37.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.simpleButton37.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton37.Appearance.Options.UseBackColor = true;
            this.simpleButton37.Appearance.Options.UseFont = true;
            this.simpleButton37.Location = new System.Drawing.Point(2066, 65);
            this.simpleButton37.Name = "simpleButton37";
            this.simpleButton37.Size = new System.Drawing.Size(133, 105);
            this.simpleButton37.TabIndex = 36;
            this.simpleButton37.Text = "X";
            this.simpleButton37.Visible = false;
            this.simpleButton37.Click += new System.EventHandler(this.simpleButton37_Click);
            // 
            // kaliteler
            // 
            this.kaliteler.Appearance.BackColor = System.Drawing.Color.Indigo;
            this.kaliteler.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaliteler.Appearance.Options.UseBackColor = true;
            this.kaliteler.Appearance.Options.UseFont = true;
            this.kaliteler.Location = new System.Drawing.Point(172, 154);
            this.kaliteler.Name = "kaliteler";
            this.kaliteler.Size = new System.Drawing.Size(150, 64);
            this.kaliteler.TabIndex = 37;
            this.kaliteler.Text = "KALİTELER";
            this.kaliteler.Visible = false;
            this.kaliteler.Click += new System.EventHandler(this.simpleButton13_Click);
            // 
            // simpleButton15
            // 
            this.simpleButton15.Appearance.BackColor = System.Drawing.Color.Indigo;
            this.simpleButton15.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton15.Appearance.Options.UseBackColor = true;
            this.simpleButton15.Appearance.Options.UseFont = true;
            this.simpleButton15.Location = new System.Drawing.Point(172, 163);
            this.simpleButton15.Name = "simpleButton15";
            this.simpleButton15.Size = new System.Drawing.Size(150, 64);
            this.simpleButton15.TabIndex = 38;
            this.simpleButton15.Text = "TEZGAH TANIMLARI";
            this.simpleButton15.Visible = false;
            // 
            // desenler
            // 
            this.desenler.Appearance.BackColor = System.Drawing.Color.Indigo;
            this.desenler.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desenler.Appearance.Options.UseBackColor = true;
            this.desenler.Appearance.Options.UseFont = true;
            this.desenler.Location = new System.Drawing.Point(172, 154);
            this.desenler.Name = "desenler";
            this.desenler.Size = new System.Drawing.Size(150, 64);
            this.desenler.TabIndex = 39;
            this.desenler.Text = "DESENLER";
            this.desenler.Visible = false;
            // 
            // renkpaletleri
            // 
            this.renkpaletleri.Appearance.BackColor = System.Drawing.Color.Indigo;
            this.renkpaletleri.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renkpaletleri.Appearance.Options.UseBackColor = true;
            this.renkpaletleri.Appearance.Options.UseFont = true;
            this.renkpaletleri.Location = new System.Drawing.Point(172, 154);
            this.renkpaletleri.Name = "renkpaletleri";
            this.renkpaletleri.Size = new System.Drawing.Size(150, 64);
            this.renkpaletleri.TabIndex = 40;
            this.renkpaletleri.Text = "RENK PALETLERİ";
            this.renkpaletleri.Visible = false;
            // 
            // renkler
            // 
            this.renkler.Appearance.BackColor = System.Drawing.Color.Indigo;
            this.renkler.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renkler.Appearance.Options.UseBackColor = true;
            this.renkler.Appearance.Options.UseFont = true;
            this.renkler.Location = new System.Drawing.Point(172, 154);
            this.renkler.Name = "renkler";
            this.renkler.Size = new System.Drawing.Size(150, 66);
            this.renkler.TabIndex = 41;
            this.renkler.Text = "RENKLER";
            this.renkler.Visible = false;
            // 
            // ebatşekiltanimlari
            // 
            this.ebatşekiltanimlari.Appearance.BackColor = System.Drawing.Color.Indigo;
            this.ebatşekiltanimlari.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ebatşekiltanimlari.Appearance.Options.UseBackColor = true;
            this.ebatşekiltanimlari.Appearance.Options.UseFont = true;
            this.ebatşekiltanimlari.Location = new System.Drawing.Point(172, 156);
            this.ebatşekiltanimlari.Name = "ebatşekiltanimlari";
            this.ebatşekiltanimlari.Size = new System.Drawing.Size(150, 64);
            this.ebatşekiltanimlari.TabIndex = 42;
            this.ebatşekiltanimlari.Text = "EBAT ŞEKİL TANIMLARI";
            this.ebatşekiltanimlari.Visible = false;
            // 
            // ebattiptanimlari
            // 
            this.ebattiptanimlari.Appearance.BackColor = System.Drawing.Color.Indigo;
            this.ebattiptanimlari.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ebattiptanimlari.Appearance.Options.UseBackColor = true;
            this.ebattiptanimlari.Appearance.Options.UseFont = true;
            this.ebattiptanimlari.Location = new System.Drawing.Point(181, 154);
            this.ebattiptanimlari.Name = "ebattiptanimlari";
            this.ebattiptanimlari.Size = new System.Drawing.Size(150, 64);
            this.ebattiptanimlari.TabIndex = 43;
            this.ebattiptanimlari.Text = "EBAT TİP TANIMLARI";
            this.ebattiptanimlari.Visible = false;
            // 
            // ebatlar
            // 
            this.ebatlar.Appearance.BackColor = System.Drawing.Color.Indigo;
            this.ebatlar.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ebatlar.Appearance.Options.UseBackColor = true;
            this.ebatlar.Appearance.Options.UseFont = true;
            this.ebatlar.Location = new System.Drawing.Point(172, 156);
            this.ebatlar.Name = "ebatlar";
            this.ebatlar.Size = new System.Drawing.Size(150, 64);
            this.ebatlar.TabIndex = 44;
            this.ebatlar.Text = "EBATLAR";
            this.ebatlar.Visible = false;
            // 
            // kenarformlari
            // 
            this.kenarformlari.Appearance.BackColor = System.Drawing.Color.Indigo;
            this.kenarformlari.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kenarformlari.Appearance.Options.UseBackColor = true;
            this.kenarformlari.Appearance.Options.UseFont = true;
            this.kenarformlari.Location = new System.Drawing.Point(172, 159);
            this.kenarformlari.Name = "kenarformlari";
            this.kenarformlari.Size = new System.Drawing.Size(150, 64);
            this.kenarformlari.TabIndex = 45;
            this.kenarformlari.Text = "KENAR FORMLARI";
            this.kenarformlari.Visible = false;
            // 
            // etiketformlari
            // 
            this.etiketformlari.Appearance.BackColor = System.Drawing.Color.Indigo;
            this.etiketformlari.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiketformlari.Appearance.Options.UseBackColor = true;
            this.etiketformlari.Appearance.Options.UseFont = true;
            this.etiketformlari.Location = new System.Drawing.Point(172, 164);
            this.etiketformlari.Name = "etiketformlari";
            this.etiketformlari.Size = new System.Drawing.Size(150, 64);
            this.etiketformlari.TabIndex = 46;
            this.etiketformlari.Text = "ETİKET FORMLARI";
            this.etiketformlari.Visible = false;
            this.etiketformlari.Click += new System.EventHandler(this.simpleButton24_Click);
            // 
            // Tanımlamalar
            // 
            this.Tanımlamalar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.Tanımlamalar.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tanımlamalar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Tanımlamalar.Appearance.Options.UseBackColor = true;
            this.Tanımlamalar.Appearance.Options.UseFont = true;
            this.Tanımlamalar.Appearance.Options.UseForeColor = true;
            this.Tanımlamalar.Location = new System.Drawing.Point(25, 121);
            this.Tanımlamalar.Name = "Tanımlamalar";
            this.Tanımlamalar.Size = new System.Drawing.Size(450, 306);
            this.Tanımlamalar.TabIndex = 47;
            this.Tanımlamalar.Text = "TANIMLAMALAR";
            this.Tanımlamalar.Click += new System.EventHandler(this.Tanımlamalar_Click);
            // 
            // radialMenu1
            // 
            this.radialMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem8),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem10),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem11),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem12)});
            this.radialMenu1.Manager = this.barManager1;
            this.radialMenu1.Name = "radialMenu1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "barButtonItem8";
            this.barButtonItem8.Id = 7;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "barButtonItem9";
            this.barButtonItem9.Id = 8;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "barButtonItem10";
            this.barButtonItem10.Id = 9;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "barButtonItem11";
            this.barButtonItem11.Id = 10;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "barButtonItem12";
            this.barButtonItem12.Id = 11;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12});
            this.barManager1.MaxItemId = 12;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(2436, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1250);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(2436, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1250);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(2436, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1250);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2436, 1250);
            this.Controls.Add(this.Tanımlamalar);
            this.Controls.Add(this.etiketformlari);
            this.Controls.Add(this.kenarformlari);
            this.Controls.Add(this.ebatlar);
            this.Controls.Add(this.ebattiptanimlari);
            this.Controls.Add(this.ebatşekiltanimlari);
            this.Controls.Add(this.renkler);
            this.Controls.Add(this.renkpaletleri);
            this.Controls.Add(this.desenler);
            this.Controls.Add(this.simpleButton15);
            this.Controls.Add(this.kaliteler);
            this.Controls.Add(this.simpleButton37);
            this.Controls.Add(this.simpleButton8);
            this.Controls.Add(this.simpleButton16);
            this.Controls.Add(this.simpleButton14);
            this.Controls.Add(this.simpleButton12);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.CPS);
            this.Controls.Add(this.Raporlar);
            this.Controls.Add(this.DepoYonetimi);
            this.Controls.Add(this.Planlama);
            this.Controls.Add(this.SiparisYonetimi);
            this.Controls.Add(this.Ayarlar);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "CPS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton37_Click(object sender, EventArgs e)
        {
            // TO DO
            simpleButton12.Visible = false;
            simpleButton14.Visible = false;
            //simpleButton15.Visible = true; to the settings section 
            simpleButton16.Visible = false;
            simpleButton37.Visible = false;
            // left
            Tanımlamalar.Visible = true;
            Ayarlar.Visible = true;
            SiparisYonetimi.Visible = true;
            DepoYonetimi.Visible = true;
            Raporlar.Visible = true;
            CPS.Visible = true;
            Planlama.Visible = true;
            locateTanımlamalarButtonBack(Tanımlamalar);

            // right
            //tanımlamalarLabel.Visible = false;
            kaliteler.Visible = false;
            simpleButton14.Visible = false;
            simpleButton15.Visible = false;
            simpleButton16.Visible = false;
            desenler.Visible = false;
            renkpaletleri.Visible = false;
            renkler.Visible = false;
            ebatşekiltanimlari.Visible = false;
            ebattiptanimlari.Visible = false;
            ebatlar.Visible = false;
            kenarformlari.Visible = false;
            etiketformlari.Visible = false;
        }

        private void locateTanımlamalarButtonBack(SimpleButton button)
        {
            int newWidth = 1000;  // Adjust the desired width
            int newHeight = 500;  // Adjust the desired height

            button.Size = new Size(newWidth, newHeight);
            button.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


            button.Location = new System.Drawing.Point(25, 125);
            button.Size = new System.Drawing.Size(450, 306);

            // Set button's location to the center

        }

        private void simpleButton6_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void simpleButton6_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void simpleButton3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void simpleButton3_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void simpleButton4_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void simpleButton4_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void simpleButton5_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void simpleButton5_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void simpleButton7_MouseHover(object sender, EventArgs e)
        {
            ;
        }

        private void simpleButton7_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_MouseLeave(object sender, EventArgs e)
        {
            //TODO
            //simpleButton13.Visible = false;
            //simpleButton12.Visible = false;
            //simpleButton14.Visible = false;
            //simpleButton15.Visible = false;
            //simpleButton16.Visible = false;
        }

        private void simpleButton1_MouseHover(object sender, EventArgs e)
        {
            //TODO
            //simpleButton13.Visible = true;
            //simpleButton12.Visible = true;
            //simpleButton14.Visible = true;
            //simpleButton15.Visible = true;
            //simpleButton16.Visible = true;
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            //groupControl1.Visible = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
        }

        private void Tanımlamalar_Click(object sender, EventArgs e)
        {
            simpleButton12.Visible = true;
            simpleButton14.Visible = true;
            //simpleButton15.Visible = true; to the settings section 
            simpleButton16.Visible = true;
            Tanımlamalar.Visible = false;
            simpleButton37.Visible = true;
            Ayarlar.Visible = false;
            SiparisYonetimi.Visible = false;
            DepoYonetimi.Visible = false;
            Raporlar.Visible = false;
            CPS.Visible = false;
            Planlama.Visible = false;
            LocateButtonTanımlamalarLeft(simpleButton12, 0);
            LocateButtonTanımlamalarLeft(simpleButton14, 1);
            LocateButtonTanımlamalarLeft(simpleButton16, 2);
            //CenterButton(Tanımlamalar);
            kaliteler.Visible = true;
            simpleButton15.Visible = true;
            simpleButton16.Visible = true;
            desenler.Visible = true;
            renkpaletleri.Visible = true;
            renkler.Visible = true;
            ebatşekiltanimlari.Visible = true;
            ebattiptanimlari.Visible = true;
            ebatlar.Visible = true;
            kenarformlari.Visible = true;
            etiketformlari.Visible = true;
            //tanımlamalarLabel.Visible = true;
            //LocateLabelTanımlamalarRight(tanımlamalarLabel, 0);
            LocateButtonTanımlamalarRight5(kaliteler, 1);
            LocateButtonTanımlamalarRight5(simpleButton15, 2);
            LocateButtonTanımlamalarRight5(desenler, 3);
            LocateButtonTanımlamalarRight5(renkpaletleri, 4);
            LocateButtonTanımlamalarRight5(renkler, 5);
            LocateButtonTanımlamalarRight10(ebatşekiltanimlari, 1);
            LocateButtonTanımlamalarRight10(ebattiptanimlari, 2);
            LocateButtonTanımlamalarRight10(ebatlar, 3);
            LocateButtonTanımlamalarRight10(kenarformlari, 4);
            LocateButtonTanımlamalarRight10(etiketformlari, 5);



        }
        private void LocateLabelTanımlamalarRight(LabelControl label, int ordernum)
        {
            int newWidth = 400;
            int newHeight = 100;
            int space = 25;
            label.Size = new Size(newWidth, newHeight);
            label.Appearance.Font = new System.Drawing.Font("Bahnschrift", 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            int centerX = (this.ClientSize.Width - label.Width) / 2 + 200;
            int centerY = (this.ClientSize.Height - label.Height) / 2 + 600 - (ordernum * newHeight);

            label.Location = new Point(centerX, centerY);
        }


        private void LocateButtonTanımlamalarRight5(SimpleButton button, int ordernum)
        {
            int newWidth = 500;
            int newHeight = 100;
            int space = 25;
            button.Size = new Size(newWidth, newHeight);
            button.Appearance.Font = new System.Drawing.Font("Bahnschrift", 15f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            int centerX = (this.ClientSize.Width - button.Width) / 2 + 250;
            int centerY = (this.ClientSize.Height - button.Height) / 2 + 300 - (ordernum * newHeight);

            button.Location = new Point(centerX, centerY);
        }

        private void LocateButtonTanımlamalarRight10(SimpleButton button, int ordernum)
        {
            int newWidth = 500;
            int newHeight = 100;
            int space = 25;

            button.Size = new Size(newWidth, newHeight);
            button.Appearance.Font = new System.Drawing.Font("Bahnschrift", 15f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            int centerX = (this.ClientSize.Width - button.Width) / 2 - 350;
            int centerY = (this.ClientSize.Height - button.Height) / 2 + 300 - (ordernum * newHeight);

            button.Location = new Point(centerX, centerY);
        }


        // Method to locate the button under simpleButton1
        private void LocateButtonTanımlamalarLeft(SimpleButton button, int ordernum)
        {
            int newWidth = 500;
            int newHeight = 100;
            int space = 25;
            button.Size = new Size(newWidth, newHeight);
            button.Appearance.Font = new System.Drawing.Font("Bahnschrift", 15f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            int centerX = (this.ClientSize.Width - button.Width) / 2 - 950;
            int centerY = (this.ClientSize.Height - button.Height) / 2 + 100 - (ordernum*newHeight);

            button.Location = new Point(centerX, centerY);

        }

        // Method to center the button
        private void CenterButton(SimpleButton button)
        {
            // Define the new size for the button
            int newWidth = 1000;  // Adjust the desired width
            int newHeight = 500;  // Adjust the desired height

            button.Size = new Size(newWidth, newHeight);
            button.Appearance.Font = new System.Drawing.Font("Bahnschrift", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


            // Calculate center of the form
            int centerX = (this.ClientSize.Width - button.Width) / 2 - 200;
            int centerY = (this.ClientSize.Height - button.Height) / 2;

            // Set button's location to the center
            button.Location = new Point(centerX, centerY);
            
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            //groupControl1.Visible = false;
        }

        #endregion
        private SimpleButton Ayarlar;
        private SimpleButton SiparisYonetimi;
        private SimpleButton Planlama;
        private SimpleButton DepoYonetimi;
        private SimpleButton Raporlar;
        private SimpleButton CPS;
        private SidePanel sidePanel1;
        private System.Windows.Forms.TextBox textBox1;
        private SimpleButton simpleButton8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private SimpleButton simpleButton9;
        private SimpleButton simpleButton10;
        private SimpleButton simpleButton11;
        private SimpleButton simpleButton12;
        private SimpleButton simpleButton14;
        private SimpleButton simpleButton16;
        private SimpleButton simpleButton37;
        private SimpleButton kaliteler;
        private SimpleButton simpleButton15;
        private SimpleButton desenler;
        private SimpleButton renkpaletleri;
        private SimpleButton renkler;
        private SimpleButton ebatşekiltanimlari;
        private SimpleButton ebattiptanimlari;
        private SimpleButton ebatlar;
        private SimpleButton kenarformlari;
        private SimpleButton etiketformlari;
        private SimpleButton simpleButton25;
        private SimpleButton simpleButton26;
        private SimpleButton Tanımlamalar;
        private DevExpress.XtraBars.Ribbon.RadialMenu radialMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}

