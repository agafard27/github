using DevExpress.Data.PLinq;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DXApplication3
{
    partial class MainForm
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
            this.buttonSettings = new DevExpress.XtraEditors.SimpleButton();
            this.buttonOrderManagement = new DevExpress.XtraEditors.SimpleButton();
            this.buttonPlanning = new DevExpress.XtraEditors.SimpleButton();
            this.buttonRepositoryManagement = new DevExpress.XtraEditors.SimpleButton();
            this.buttonReports = new DevExpress.XtraEditors.SimpleButton();
            this.CPS = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.textboxSearching = new System.Windows.Forms.TextBox();
            this.buttonSearching = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCPS = new DevExpress.XtraEditors.SimpleButton();
            this.buttonMsm = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton25 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton26 = new DevExpress.XtraEditors.SimpleButton();
            this.buttonRepoCards = new DevExpress.XtraEditors.SimpleButton();
            this.buttonInfosDefinitions = new DevExpress.XtraEditors.SimpleButton();
            this.buttonCustomerCards = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton37 = new DevExpress.XtraEditors.SimpleButton();
            this.buttonQualities = new DevExpress.XtraEditors.SimpleButton();
            this.buttonLoomDefinitions = new DevExpress.XtraEditors.SimpleButton();
            this.buttonDesigns = new DevExpress.XtraEditors.SimpleButton();
            this.buttonColorPallets = new DevExpress.XtraEditors.SimpleButton();
            this.buttonColors = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSizeShapeDefinitions = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSizeTypeDefinitions = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSizes = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEdgeForms = new DevExpress.XtraEditors.SimpleButton();
            this.buttonLabetForms = new DevExpress.XtraEditors.SimpleButton();
            this.buttonDefinitions = new DevExpress.XtraEditors.SimpleButton();
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
            // buttonSettings
            // 
            this.buttonSettings.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.buttonSettings.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.Appearance.Options.UseBackColor = true;
            this.buttonSettings.Appearance.Options.UseFont = true;
            this.buttonSettings.Location = new System.Drawing.Point(2268, 1132);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(156, 106);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.Text = "AYARLAR";
            this.buttonSettings.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // buttonOrderManagement
            // 
            this.buttonOrderManagement.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(189)))));
            this.buttonOrderManagement.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderManagement.Appearance.Options.UseBackColor = true;
            this.buttonOrderManagement.Appearance.Options.UseFont = true;
            this.buttonOrderManagement.Location = new System.Drawing.Point(406, 111);
            this.buttonOrderManagement.Name = "buttonOrderManagement";
            this.buttonOrderManagement.Size = new System.Drawing.Size(505, 306);
            this.buttonOrderManagement.TabIndex = 2;
            this.buttonOrderManagement.Text = "SİPARİŞ YÖNETİMİ";
            this.buttonOrderManagement.Click += new System.EventHandler(this.simpleButton3_Click);
            this.buttonOrderManagement.MouseLeave += new System.EventHandler(this.simpleButton3_MouseLeave);
            this.buttonOrderManagement.MouseHover += new System.EventHandler(this.simpleButton3_MouseHover);
            // 
            // buttonPlanning
            // 
            this.buttonPlanning.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(247)))));
            this.buttonPlanning.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlanning.Appearance.Options.UseBackColor = true;
            this.buttonPlanning.Appearance.Options.UseFont = true;
            this.buttonPlanning.Location = new System.Drawing.Point(1149, 111);
            this.buttonPlanning.Name = "buttonPlanning";
            this.buttonPlanning.Size = new System.Drawing.Size(505, 306);
            this.buttonPlanning.TabIndex = 3;
            this.buttonPlanning.Text = "PLANLAMA";
            this.buttonPlanning.Click += new System.EventHandler(this.simpleButton4_Click);
            this.buttonPlanning.MouseLeave += new System.EventHandler(this.simpleButton4_MouseLeave);
            this.buttonPlanning.MouseHover += new System.EventHandler(this.simpleButton4_MouseHover);
            // 
            // buttonRepositoryManagement
            // 
            this.buttonRepositoryManagement.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(207)))), ((int)(((byte)(243)))));
            this.buttonRepositoryManagement.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRepositoryManagement.Appearance.Options.UseBackColor = true;
            this.buttonRepositoryManagement.Appearance.Options.UseFont = true;
            this.buttonRepositoryManagement.Location = new System.Drawing.Point(783, 820);
            this.buttonRepositoryManagement.Name = "buttonRepositoryManagement";
            this.buttonRepositoryManagement.Size = new System.Drawing.Size(505, 306);
            this.buttonRepositoryManagement.TabIndex = 4;
            this.buttonRepositoryManagement.Text = "DEPO YÖNETİMİ ";
            this.buttonRepositoryManagement.Click += new System.EventHandler(this.simpleButton5_Click);
            this.buttonRepositoryManagement.MouseLeave += new System.EventHandler(this.simpleButton5_MouseLeave);
            this.buttonRepositoryManagement.MouseHover += new System.EventHandler(this.simpleButton5_MouseHover);
            // 
            // buttonReports
            // 
            this.buttonReports.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.buttonReports.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReports.Appearance.Options.UseBackColor = true;
            this.buttonReports.Appearance.Options.UseFont = true;
            this.buttonReports.Location = new System.Drawing.Point(1149, 471);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(505, 306);
            this.buttonReports.TabIndex = 5;
            this.buttonReports.Text = "RAPORLAR";
            this.buttonReports.Click += new System.EventHandler(this.simpleButton6_Click);
            this.buttonReports.MouseLeave += new System.EventHandler(this.simpleButton6_MouseLeave);
            this.buttonReports.MouseHover += new System.EventHandler(this.simpleButton6_MouseHover);
            // 
            // CPS
            // 
            this.CPS.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(206)))), ((int)(((byte)(221)))));
            this.CPS.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPS.Appearance.Options.UseBackColor = true;
            this.CPS.Appearance.Options.UseFont = true;
            this.CPS.Location = new System.Drawing.Point(2268, 1020);
            this.CPS.Name = "CPS";
            this.CPS.Size = new System.Drawing.Size(156, 106);
            this.CPS.TabIndex = 6;
            this.CPS.Text = "CPS";
            this.CPS.Click += new System.EventHandler(this.simpleButton7_Click);
            this.CPS.MouseLeave += new System.EventHandler(this.simpleButton7_MouseLeave);
            this.CPS.MouseHover += new System.EventHandler(this.simpleButton7_MouseHover);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(229)))), ((int)(((byte)(187)))));
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.textboxSearching);
            this.sidePanel1.Location = new System.Drawing.Point(2205, 81);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(232, 59);
            this.sidePanel1.TabIndex = 7;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // textboxSearching
            // 
            this.textboxSearching.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(229)))), ((int)(((byte)(187)))));
            this.textboxSearching.Location = new System.Drawing.Point(3, 3);
            this.textboxSearching.Multiline = true;
            this.textboxSearching.Name = "textboxSearching";
            this.textboxSearching.Size = new System.Drawing.Size(358, 48);
            this.textboxSearching.TabIndex = 0;
            // 
            // buttonSearching
            // 
            this.buttonSearching.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(229)))), ((int)(((byte)(187)))));
            this.buttonSearching.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearching.Appearance.ForeColor = System.Drawing.Color.White;
            this.buttonSearching.Appearance.Options.UseBackColor = true;
            this.buttonSearching.Appearance.Options.UseFont = true;
            this.buttonSearching.Appearance.Options.UseForeColor = true;
            this.buttonSearching.Location = new System.Drawing.Point(2205, 4);
            this.buttonSearching.Name = "buttonSearching";
            this.buttonSearching.Size = new System.Drawing.Size(232, 71);
            this.buttonSearching.TabIndex = 8;
            this.buttonSearching.Text = "ARA";
            this.buttonSearching.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(144)))), ((int)(((byte)(160)))));
            this.flowLayoutPanel1.Controls.Add(this.buttonCPS);
            this.flowLayoutPanel1.Controls.Add(this.buttonMsm);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton11);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton25);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton26);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(2177, 58);
            this.flowLayoutPanel1.TabIndex = 9;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // buttonCPS
            // 
            this.buttonCPS.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(206)))), ((int)(((byte)(221)))));
            this.buttonCPS.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCPS.Appearance.Options.UseBackColor = true;
            this.buttonCPS.Appearance.Options.UseFont = true;
            this.buttonCPS.Location = new System.Drawing.Point(3, 3);
            this.buttonCPS.Name = "buttonCPS";
            this.buttonCPS.Size = new System.Drawing.Size(375, 55);
            this.buttonCPS.TabIndex = 0;
            this.buttonCPS.Text = "CPS";
            this.buttonCPS.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // buttonMsm
            // 
            this.buttonMsm.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(222)))));
            this.buttonMsm.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMsm.Appearance.Options.UseBackColor = true;
            this.buttonMsm.Appearance.Options.UseFont = true;
            this.buttonMsm.Location = new System.Drawing.Point(384, 3);
            this.buttonMsm.Name = "buttonMsm";
            this.buttonMsm.Size = new System.Drawing.Size(371, 55);
            this.buttonMsm.TabIndex = 1;
            this.buttonMsm.Text = "MSM";
            this.buttonMsm.Click += new System.EventHandler(this.simpleButton10_Click);
            // 
            // simpleButton11
            // 
            this.simpleButton11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.simpleButton11.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton11.Appearance.Options.UseBackColor = true;
            this.simpleButton11.Appearance.Options.UseFont = true;
            this.simpleButton11.Location = new System.Drawing.Point(761, 3);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(360, 55);
            this.simpleButton11.TabIndex = 2;
            this.simpleButton11.Text = "Desen Arşivi";
            // 
            // simpleButton25
            // 
            this.simpleButton25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.simpleButton25.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton25.Appearance.Options.UseBackColor = true;
            this.simpleButton25.Appearance.Options.UseFont = true;
            this.simpleButton25.Location = new System.Drawing.Point(1127, 3);
            this.simpleButton25.Name = "simpleButton25";
            this.simpleButton25.Size = new System.Drawing.Size(371, 55);
            this.simpleButton25.TabIndex = 3;
            this.simpleButton25.Text = "Etiket";
            // 
            // simpleButton26
            // 
            this.simpleButton26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(179)))), ((int)(((byte)(43)))));
            this.simpleButton26.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton26.Appearance.Options.UseBackColor = true;
            this.simpleButton26.Appearance.Options.UseFont = true;
            this.simpleButton26.Location = new System.Drawing.Point(1504, 3);
            this.simpleButton26.Name = "simpleButton26";
            this.simpleButton26.Size = new System.Drawing.Size(371, 55);
            this.simpleButton26.TabIndex = 4;
            this.simpleButton26.Text = "Kalite Kontrol";
            // 
            // buttonRepoCards
            // 
            this.buttonRepoCards.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.buttonRepoCards.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRepoCards.Appearance.Options.UseBackColor = true;
            this.buttonRepoCards.Appearance.Options.UseFont = true;
            this.buttonRepoCards.Location = new System.Drawing.Point(534, 562);
            this.buttonRepoCards.Name = "buttonRepoCards";
            this.buttonRepoCards.Size = new System.Drawing.Size(256, 112);
            this.buttonRepoCards.TabIndex = 12;
            this.buttonRepoCards.Text = "DEPO KARTLARI";
            this.buttonRepoCards.Visible = false;
            this.buttonRepoCards.Click += new System.EventHandler(this.simpleButton12_Click);
            // 
            // buttonInfosDefinitions
            // 
            this.buttonInfosDefinitions.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.buttonInfosDefinitions.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfosDefinitions.Appearance.Options.UseBackColor = true;
            this.buttonInfosDefinitions.Appearance.Options.UseFont = true;
            this.buttonInfosDefinitions.Location = new System.Drawing.Point(512, 570);
            this.buttonInfosDefinitions.Name = "buttonInfosDefinitions";
            this.buttonInfosDefinitions.Size = new System.Drawing.Size(278, 102);
            this.buttonInfosDefinitions.TabIndex = 13;
            this.buttonInfosDefinitions.Text = "BİLGİ TANIMLARI";
            this.buttonInfosDefinitions.Visible = false;
            this.buttonInfosDefinitions.Click += new System.EventHandler(this.simpleButton14_Click);
            // 
            // buttonCustomerCards
            // 
            this.buttonCustomerCards.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.buttonCustomerCards.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomerCards.Appearance.Options.UseBackColor = true;
            this.buttonCustomerCards.Appearance.Options.UseFont = true;
            this.buttonCustomerCards.Location = new System.Drawing.Point(490, 570);
            this.buttonCustomerCards.Name = "buttonCustomerCards";
            this.buttonCustomerCards.Size = new System.Drawing.Size(323, 97);
            this.buttonCustomerCards.TabIndex = 15;
            this.buttonCustomerCards.Text = "MÜŞTERİ KARTLARI";
            this.buttonCustomerCards.Visible = false;
            this.buttonCustomerCards.Click += new System.EventHandler(this.simpleButton16_Click);
            // 
            // simpleButton37
            // 
            this.simpleButton37.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            this.simpleButton37.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton37.Appearance.Options.UseBackColor = true;
            this.simpleButton37.Appearance.Options.UseFont = true;
            this.simpleButton37.Location = new System.Drawing.Point(2041, 65);
            this.simpleButton37.Name = "simpleButton37";
            this.simpleButton37.Size = new System.Drawing.Size(158, 75);
            this.simpleButton37.TabIndex = 36;
            this.simpleButton37.Text = "Geri Dön";
            this.simpleButton37.Visible = false;
            this.simpleButton37.Click += new System.EventHandler(this.simpleButton37_Click);
            // 
            // buttonQualities
            // 
            this.buttonQualities.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.buttonQualities.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQualities.Appearance.Options.UseBackColor = true;
            this.buttonQualities.Appearance.Options.UseFont = true;
            this.buttonQualities.Location = new System.Drawing.Point(586, 585);
            this.buttonQualities.Name = "buttonQualities";
            this.buttonQualities.Size = new System.Drawing.Size(150, 64);
            this.buttonQualities.TabIndex = 37;
            this.buttonQualities.Text = "KALİTELER";
            this.buttonQualities.Visible = false;
            this.buttonQualities.Click += new System.EventHandler(this.simpleButton13_Click);
            // 
            // buttonLoomDefinitions
            // 
            this.buttonLoomDefinitions.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.buttonLoomDefinitions.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoomDefinitions.Appearance.Options.UseBackColor = true;
            this.buttonLoomDefinitions.Appearance.Options.UseFont = true;
            this.buttonLoomDefinitions.Location = new System.Drawing.Point(586, 585);
            this.buttonLoomDefinitions.Name = "buttonLoomDefinitions";
            this.buttonLoomDefinitions.Size = new System.Drawing.Size(150, 64);
            this.buttonLoomDefinitions.TabIndex = 38;
            this.buttonLoomDefinitions.Text = "TEZGAH TANIMLARI";
            this.buttonLoomDefinitions.Visible = false;
            this.buttonLoomDefinitions.Click += new System.EventHandler(this.simpleButton15_Click_1);
            // 
            // buttonDesigns
            // 
            this.buttonDesigns.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.buttonDesigns.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesigns.Appearance.Options.UseBackColor = true;
            this.buttonDesigns.Appearance.Options.UseFont = true;
            this.buttonDesigns.Location = new System.Drawing.Point(586, 583);
            this.buttonDesigns.Name = "buttonDesigns";
            this.buttonDesigns.Size = new System.Drawing.Size(150, 64);
            this.buttonDesigns.TabIndex = 39;
            this.buttonDesigns.Text = "DESENLER";
            this.buttonDesigns.Visible = false;
            this.buttonDesigns.Click += new System.EventHandler(this.desenler_Click);
            // 
            // buttonColorPallets
            // 
            this.buttonColorPallets.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.buttonColorPallets.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonColorPallets.Appearance.Options.UseBackColor = true;
            this.buttonColorPallets.Appearance.Options.UseFont = true;
            this.buttonColorPallets.Location = new System.Drawing.Point(586, 585);
            this.buttonColorPallets.Name = "buttonColorPallets";
            this.buttonColorPallets.Size = new System.Drawing.Size(150, 64);
            this.buttonColorPallets.TabIndex = 40;
            this.buttonColorPallets.Text = "RENK PALETLERİ";
            this.buttonColorPallets.Visible = false;
            this.buttonColorPallets.Click += new System.EventHandler(this.renkpaletleri_Click);
            // 
            // buttonColors
            // 
            this.buttonColors.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.buttonColors.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonColors.Appearance.Options.UseBackColor = true;
            this.buttonColors.Appearance.Options.UseFont = true;
            this.buttonColors.Location = new System.Drawing.Point(586, 583);
            this.buttonColors.Name = "buttonColors";
            this.buttonColors.Size = new System.Drawing.Size(150, 66);
            this.buttonColors.TabIndex = 41;
            this.buttonColors.Text = "RENKLER";
            this.buttonColors.Visible = false;
            this.buttonColors.Click += new System.EventHandler(this.renkler_Click);
            // 
            // buttonSizeShapeDefinitions
            // 
            this.buttonSizeShapeDefinitions.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.buttonSizeShapeDefinitions.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSizeShapeDefinitions.Appearance.Options.UseBackColor = true;
            this.buttonSizeShapeDefinitions.Appearance.Options.UseFont = true;
            this.buttonSizeShapeDefinitions.Location = new System.Drawing.Point(586, 583);
            this.buttonSizeShapeDefinitions.Name = "buttonSizeShapeDefinitions";
            this.buttonSizeShapeDefinitions.Size = new System.Drawing.Size(150, 64);
            this.buttonSizeShapeDefinitions.TabIndex = 42;
            this.buttonSizeShapeDefinitions.Text = "EBAT ŞEKİL TANIMLARI";
            this.buttonSizeShapeDefinitions.Visible = false;
            this.buttonSizeShapeDefinitions.Click += new System.EventHandler(this.ebatşekiltanimlari_Click);
            // 
            // buttonSizeTypeDefinitions
            // 
            this.buttonSizeTypeDefinitions.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.buttonSizeTypeDefinitions.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSizeTypeDefinitions.Appearance.Options.UseBackColor = true;
            this.buttonSizeTypeDefinitions.Appearance.Options.UseFont = true;
            this.buttonSizeTypeDefinitions.Location = new System.Drawing.Point(586, 583);
            this.buttonSizeTypeDefinitions.Name = "buttonSizeTypeDefinitions";
            this.buttonSizeTypeDefinitions.Size = new System.Drawing.Size(150, 64);
            this.buttonSizeTypeDefinitions.TabIndex = 43;
            this.buttonSizeTypeDefinitions.Text = "EBAT TİP TANIMLARI";
            this.buttonSizeTypeDefinitions.Visible = false;
            this.buttonSizeTypeDefinitions.Click += new System.EventHandler(this.ebattiptanimlari_Click);
            // 
            // buttonSizes
            // 
            this.buttonSizes.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.buttonSizes.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSizes.Appearance.Options.UseBackColor = true;
            this.buttonSizes.Appearance.Options.UseFont = true;
            this.buttonSizes.Location = new System.Drawing.Point(586, 583);
            this.buttonSizes.Name = "buttonSizes";
            this.buttonSizes.Size = new System.Drawing.Size(150, 64);
            this.buttonSizes.TabIndex = 44;
            this.buttonSizes.Text = "EBATLAR";
            this.buttonSizes.Visible = false;
            this.buttonSizes.Click += new System.EventHandler(this.ebatlar_Click);
            // 
            // buttonEdgeForms
            // 
            this.buttonEdgeForms.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.buttonEdgeForms.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdgeForms.Appearance.Options.UseBackColor = true;
            this.buttonEdgeForms.Appearance.Options.UseFont = true;
            this.buttonEdgeForms.Location = new System.Drawing.Point(586, 583);
            this.buttonEdgeForms.Name = "buttonEdgeForms";
            this.buttonEdgeForms.Size = new System.Drawing.Size(150, 64);
            this.buttonEdgeForms.TabIndex = 45;
            this.buttonEdgeForms.Text = "KENAR FORMLARI";
            this.buttonEdgeForms.Visible = false;
            this.buttonEdgeForms.Click += new System.EventHandler(this.kenarformlari_Click);
            // 
            // buttonLabetForms
            // 
            this.buttonLabetForms.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.buttonLabetForms.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLabetForms.Appearance.Options.UseBackColor = true;
            this.buttonLabetForms.Appearance.Options.UseFont = true;
            this.buttonLabetForms.Location = new System.Drawing.Point(586, 583);
            this.buttonLabetForms.Name = "buttonLabetForms";
            this.buttonLabetForms.Size = new System.Drawing.Size(150, 64);
            this.buttonLabetForms.TabIndex = 46;
            this.buttonLabetForms.Text = "ETİKET FORMLARI";
            this.buttonLabetForms.Visible = false;
            this.buttonLabetForms.Click += new System.EventHandler(this.simpleButton24_Click);
            // 
            // buttonDefinitions
            // 
            this.buttonDefinitions.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.buttonDefinitions.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDefinitions.Appearance.ForeColor = System.Drawing.Color.Black;
            this.buttonDefinitions.Appearance.Options.UseBackColor = true;
            this.buttonDefinitions.Appearance.Options.UseFont = true;
            this.buttonDefinitions.Appearance.Options.UseForeColor = true;
            this.buttonDefinitions.Location = new System.Drawing.Point(406, 471);
            this.buttonDefinitions.Name = "buttonDefinitions";
            this.buttonDefinitions.Size = new System.Drawing.Size(505, 306);
            this.buttonDefinitions.TabIndex = 47;
            this.buttonDefinitions.Text = "TANIMLAMALAR";
            this.buttonDefinitions.Click += new System.EventHandler(this.Tanımlamalar_Click);
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
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(144)))), ((int)(((byte)(160)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(144)))), ((int)(((byte)(160)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2436, 1250);
            this.Controls.Add(this.buttonDefinitions);
            this.Controls.Add(this.buttonLabetForms);
            this.Controls.Add(this.buttonEdgeForms);
            this.Controls.Add(this.buttonSizes);
            this.Controls.Add(this.buttonSizeTypeDefinitions);
            this.Controls.Add(this.buttonSizeShapeDefinitions);
            this.Controls.Add(this.buttonColors);
            this.Controls.Add(this.buttonColorPallets);
            this.Controls.Add(this.buttonDesigns);
            this.Controls.Add(this.buttonLoomDefinitions);
            this.Controls.Add(this.buttonQualities);
            this.Controls.Add(this.simpleButton37);
            this.Controls.Add(this.buttonSearching);
            this.Controls.Add(this.buttonCustomerCards);
            this.Controls.Add(this.buttonInfosDefinitions);
            this.Controls.Add(this.buttonRepoCards);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.CPS);
            this.Controls.Add(this.buttonReports);
            this.Controls.Add(this.buttonRepositoryManagement);
            this.Controls.Add(this.buttonPlanning);
            this.Controls.Add(this.buttonOrderManagement);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
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
            buttonRepoCards.Visible = false;
            buttonInfosDefinitions.Visible = false;
            //simpleButton15.Visible = true; to the settings section 
            buttonCustomerCards.Visible = false;
            simpleButton37.Visible = false;
            // left
            buttonDefinitions.Visible = true;
            buttonSettings.Visible = true;
            buttonOrderManagement.Visible = true;
            buttonRepositoryManagement.Visible = true;
            buttonReports.Visible = true;
            CPS.Visible = true;
            buttonPlanning.Visible = true;
            locateTanımlamalarButtonBack(buttonDefinitions);

            // right
            //tanımlamalarLabel.Visible = false;
            buttonQualities.Visible = false;
            buttonInfosDefinitions.Visible = false;
            buttonLoomDefinitions.Visible = false;
            buttonCustomerCards.Visible = false;
            buttonDesigns.Visible = false;
            buttonColorPallets.Visible = false;
            buttonColors.Visible = false;
            buttonSizeShapeDefinitions.Visible = false;
            buttonSizeTypeDefinitions.Visible = false;
            buttonSizes.Visible = false;
            buttonEdgeForms.Visible = false;
            buttonLabetForms.Visible = false;
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

        public void Tanımlamalar_Click(object sender, EventArgs e)
        {
            buttonRepoCards.Visible = true;
            buttonInfosDefinitions.Visible = true;
            //simpleButton15.Visible = true; to the settings section 
            buttonCustomerCards.Visible = true;
            buttonDefinitions.Visible = false;
            simpleButton37.Visible = true;
            buttonSettings.Visible = false;
            buttonOrderManagement.Visible = false;
            buttonRepositoryManagement.Visible = false;
            buttonReports.Visible = false;
            CPS.Visible = false;
            buttonPlanning.Visible = false;
            LocateButtonTanımlamalarLeft(buttonRepoCards, 0);
            LocateButtonTanımlamalarLeft(buttonInfosDefinitions, 1);
            LocateButtonTanımlamalarLeft(buttonCustomerCards, 2);
            //CenterButton(Tanımlamalar);
            buttonQualities.Visible = true;
            buttonLoomDefinitions.Visible = true;
            buttonCustomerCards.Visible = true;
            buttonDesigns.Visible = true;
            buttonColorPallets.Visible = true;
            buttonColors.Visible = true;
            buttonSizeShapeDefinitions.Visible = true;
            buttonSizeTypeDefinitions.Visible = true;
            buttonSizes.Visible = true;
            buttonEdgeForms.Visible = true;
            buttonLabetForms.Visible = true;
            //tanımlamalarLabel.Visible = true;
            //LocateLabelTanımlamalarRight(tanımlamalarLabel, 0);
            LocateButtonTanımlamalarRight5(buttonQualities, 1);
            LocateButtonTanımlamalarRight5(buttonLoomDefinitions, 2);
            LocateButtonTanımlamalarRight5(buttonDesigns, 3);
            LocateButtonTanımlamalarRight5(buttonColorPallets, 4);
            LocateButtonTanımlamalarRight5(buttonColors, 5);
            LocateButtonTanımlamalarRight10(buttonSizeShapeDefinitions, 1);
            LocateButtonTanımlamalarRight10(buttonSizeTypeDefinitions, 2);
            LocateButtonTanımlamalarRight10(buttonSizes, 3);
            LocateButtonTanımlamalarRight10(buttonEdgeForms, 4);
            LocateButtonTanımlamalarRight10(buttonLabetForms, 5);



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
        private SimpleButton buttonSettings;
        private SimpleButton buttonOrderManagement;
        private SimpleButton buttonPlanning;
        private SimpleButton buttonRepositoryManagement;
        private SimpleButton buttonReports;
        private SimpleButton CPS;
        private SidePanel sidePanel1;
        private System.Windows.Forms.TextBox textboxSearching;
        private SimpleButton buttonSearching;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private SimpleButton buttonCPS;
        private SimpleButton buttonMsm;
        private SimpleButton simpleButton11;
        private SimpleButton buttonRepoCards;
        private SimpleButton buttonInfosDefinitions;
        private SimpleButton buttonCustomerCards;
        private SimpleButton simpleButton37;
        private SimpleButton buttonQualities;
        private SimpleButton buttonLoomDefinitions;
        private SimpleButton buttonDesigns;
        private SimpleButton buttonColorPallets;
        private SimpleButton buttonColors;
        private SimpleButton buttonSizeShapeDefinitions;
        private SimpleButton buttonSizeTypeDefinitions;
        private SimpleButton buttonSizes;
        private SimpleButton buttonEdgeForms;
        private SimpleButton buttonLabetForms;
        private SimpleButton simpleButton25;
        private SimpleButton simpleButton26;
        private SimpleButton buttonDefinitions;
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

