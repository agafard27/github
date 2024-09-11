using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DXApplication3.Helpers; // Add this using directive

namespace DXApplication3
{
    partial class CustomerCards 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private DatabaseHelper dbHelper ;


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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.xtraScrollableControl3 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.musteriKartlarıPanel = new DevExpress.XtraEditors.PanelControl();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.musteriEklemePanel = new DevExpress.XtraEditors.PanelControl();
            this.submitMusteriEkleme = new DevExpress.XtraEditors.SimpleButton();
            this.musteriStatuText = new System.Windows.Forms.RichTextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.musteriTelefonText = new System.Windows.Forms.RichTextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.musteriSehriText = new System.Windows.Forms.RichTextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.musteriUlkesiText = new System.Windows.Forms.RichTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.musteriAdresiText = new System.Windows.Forms.RichTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.musteriAciklamasiText = new System.Windows.Forms.RichTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.musteriKoduText = new System.Windows.Forms.RichTextBox();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelCustomerIDDelete = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.buttonEditCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.custidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custadressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custcityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custstatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPS_WEBDataSet1 = new DXApplication3.CPS_WEBDataSet1();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.musteriduzenlemeButton = new DevExpress.XtraEditors.SimpleButton();
            this.musteriSilmeButton = new DevExpress.XtraEditors.SimpleButton();
            this.musteriEklemeButton = new DevExpress.XtraEditors.SimpleButton();
            this.cPS_WEBDataSet = new DXApplication3.CPS_WEBDataSet();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseTableAdapter = new DXApplication3.CPS_WEBDataSetTableAdapters.warehouseTableAdapter();
            this.customerTableAdapter = new DXApplication3.CPS_WEBDataSet1TableAdapters.customerTableAdapter();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.musteriKartlarıPanel)).BeginInit();
            this.musteriKartlarıPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musteriEklemePanel)).BeginInit();
            this.musteriEklemePanel.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPS_WEBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPS_WEBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(2013, 31);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(186, 55);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Geri Dön";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.Location = new System.Drawing.Point(2329, 31);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(108, 55);
            this.simpleButton7.TabIndex = 9;
            this.simpleButton7.Text = "ARA";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.White;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Location = new System.Drawing.Point(2205, 92);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(232, 68);
            this.sidePanel1.TabIndex = 11;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.Location = new System.Drawing.Point(12, 117);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(267, 1121);
            this.xtraScrollableControl2.TabIndex = 36;
            // 
            // xtraScrollableControl3
            // 
            this.xtraScrollableControl3.Location = new System.Drawing.Point(285, 157);
            this.xtraScrollableControl3.Name = "xtraScrollableControl3";
            this.xtraScrollableControl3.Size = new System.Drawing.Size(1777, 1081);
            this.xtraScrollableControl3.TabIndex = 37;
            // 
            // musteriKartlarıPanel
            // 
            this.musteriKartlarıPanel.Controls.Add(this.tabPane1);
            this.musteriKartlarıPanel.Controls.Add(this.dataGridView1);
            this.musteriKartlarıPanel.Controls.Add(this.simpleButton4);
            this.musteriKartlarıPanel.Location = new System.Drawing.Point(12, 99);
            this.musteriKartlarıPanel.Name = "musteriKartlarıPanel";
            this.musteriKartlarıPanel.Size = new System.Drawing.Size(2203, 1136);
            this.musteriKartlarıPanel.TabIndex = 0;
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Location = new System.Drawing.Point(1313, 62);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(874, 1074);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(874, 1074);
            this.tabPane1.TabIndex = 18;
            this.tabPane1.Text = "Ekle";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Ekle";
            this.tabNavigationPage1.Controls.Add(this.musteriEklemePanel);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(874, 1008);
            // 
            // musteriEklemePanel
            // 
            this.musteriEklemePanel.Controls.Add(this.submitMusteriEkleme);
            this.musteriEklemePanel.Controls.Add(this.musteriStatuText);
            this.musteriEklemePanel.Controls.Add(this.labelControl7);
            this.musteriEklemePanel.Controls.Add(this.musteriTelefonText);
            this.musteriEklemePanel.Controls.Add(this.labelControl6);
            this.musteriEklemePanel.Controls.Add(this.musteriSehriText);
            this.musteriEklemePanel.Controls.Add(this.labelControl5);
            this.musteriEklemePanel.Controls.Add(this.musteriUlkesiText);
            this.musteriEklemePanel.Controls.Add(this.labelControl4);
            this.musteriEklemePanel.Controls.Add(this.musteriAdresiText);
            this.musteriEklemePanel.Controls.Add(this.labelControl3);
            this.musteriEklemePanel.Controls.Add(this.musteriAciklamasiText);
            this.musteriEklemePanel.Controls.Add(this.labelControl2);
            this.musteriEklemePanel.Controls.Add(this.labelControl1);
            this.musteriEklemePanel.Controls.Add(this.musteriKoduText);
            this.musteriEklemePanel.Location = new System.Drawing.Point(3, 14);
            this.musteriEklemePanel.Name = "musteriEklemePanel";
            this.musteriEklemePanel.Size = new System.Drawing.Size(884, 1024);
            this.musteriEklemePanel.TabIndex = 6;
            // 
            // submitMusteriEkleme
            // 
            this.submitMusteriEkleme.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitMusteriEkleme.Appearance.Options.UseFont = true;
            this.submitMusteriEkleme.Location = new System.Drawing.Point(585, 275);
            this.submitMusteriEkleme.Name = "submitMusteriEkleme";
            this.submitMusteriEkleme.Size = new System.Drawing.Size(166, 53);
            this.submitMusteriEkleme.TabIndex = 16;
            this.submitMusteriEkleme.Text = "Ekle";
            // 
            // musteriStatuText
            // 
            this.musteriStatuText.Location = new System.Drawing.Point(16, 291);
            this.musteriStatuText.Name = "musteriStatuText";
            this.musteriStatuText.Size = new System.Drawing.Size(203, 37);
            this.musteriStatuText.TabIndex = 13;
            this.musteriStatuText.Text = "";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(16, 237);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(167, 39);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Müşteri Statüsü";
            // 
            // musteriTelefonText
            // 
            this.musteriTelefonText.Location = new System.Drawing.Point(560, 181);
            this.musteriTelefonText.Name = "musteriTelefonText";
            this.musteriTelefonText.Size = new System.Drawing.Size(191, 34);
            this.musteriTelefonText.TabIndex = 11;
            this.musteriTelefonText.Text = "";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(556, 133);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(195, 39);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Müşteri Telefon No";
            // 
            // musteriSehriText
            // 
            this.musteriSehriText.Location = new System.Drawing.Point(300, 180);
            this.musteriSehriText.Name = "musteriSehriText";
            this.musteriSehriText.Size = new System.Drawing.Size(214, 35);
            this.musteriSehriText.TabIndex = 9;
            this.musteriSehriText.Text = "";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(300, 133);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(142, 39);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Müşteri Şehri";
            // 
            // musteriUlkesiText
            // 
            this.musteriUlkesiText.Location = new System.Drawing.Point(16, 178);
            this.musteriUlkesiText.Name = "musteriUlkesiText";
            this.musteriUlkesiText.Size = new System.Drawing.Size(203, 37);
            this.musteriUlkesiText.TabIndex = 7;
            this.musteriUlkesiText.Text = "";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(16, 133);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(150, 39);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Müşteri Ülkesi";
            // 
            // musteriAdresiText
            // 
            this.musteriAdresiText.Location = new System.Drawing.Point(556, 77);
            this.musteriAdresiText.Name = "musteriAdresiText";
            this.musteriAdresiText.Size = new System.Drawing.Size(186, 33);
            this.musteriAdresiText.TabIndex = 5;
            this.musteriAdresiText.Text = "";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(556, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(154, 39);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Müşteri Adresi";
            // 
            // musteriAciklamasiText
            // 
            this.musteriAciklamasiText.Location = new System.Drawing.Point(300, 77);
            this.musteriAciklamasiText.Name = "musteriAciklamasiText";
            this.musteriAciklamasiText.Size = new System.Drawing.Size(202, 33);
            this.musteriAciklamasiText.TabIndex = 3;
            this.musteriAciklamasiText.Text = "";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(300, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(202, 39);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Müşteri Açıklaması";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(138, 39);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Müşteri Kodu";
            // 
            // musteriKoduText
            // 
            this.musteriKoduText.Location = new System.Drawing.Point(16, 77);
            this.musteriKoduText.Name = "musteriKoduText";
            this.musteriKoduText.Size = new System.Drawing.Size(203, 33);
            this.musteriKoduText.TabIndex = 0;
            this.musteriKoduText.Text = "";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Sil";
            this.tabNavigationPage2.Controls.Add(this.textBox1);
            this.tabNavigationPage2.Controls.Add(this.labelCustomerIDDelete);
            this.tabNavigationPage2.Controls.Add(this.simpleButton3);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(874, 1008);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 39);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelCustomerIDDelete
            // 
            this.labelCustomerIDDelete.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerIDDelete.Appearance.Options.UseFont = true;
            this.labelCustomerIDDelete.Location = new System.Drawing.Point(20, 22);
            this.labelCustomerIDDelete.Name = "labelCustomerIDDelete";
            this.labelCustomerIDDelete.Size = new System.Drawing.Size(20, 39);
            this.labelCustomerIDDelete.TabIndex = 1;
            this.labelCustomerIDDelete.Text = "ID";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(189, 125);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(74, 46);
            this.simpleButton3.TabIndex = 0;
            this.simpleButton3.Text = "Sil";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Düzenle";
            this.tabNavigationPage3.Controls.Add(this.buttonEditCustomer);
            this.tabNavigationPage3.Controls.Add(this.richTextBox1);
            this.tabNavigationPage3.Controls.Add(this.labelControl8);
            this.tabNavigationPage3.Controls.Add(this.richTextBox2);
            this.tabNavigationPage3.Controls.Add(this.labelControl9);
            this.tabNavigationPage3.Controls.Add(this.richTextBox3);
            this.tabNavigationPage3.Controls.Add(this.labelControl10);
            this.tabNavigationPage3.Controls.Add(this.richTextBox4);
            this.tabNavigationPage3.Controls.Add(this.labelControl11);
            this.tabNavigationPage3.Controls.Add(this.richTextBox5);
            this.tabNavigationPage3.Controls.Add(this.labelControl12);
            this.tabNavigationPage3.Controls.Add(this.richTextBox6);
            this.tabNavigationPage3.Controls.Add(this.labelControl13);
            this.tabNavigationPage3.Controls.Add(this.labelControl14);
            this.tabNavigationPage3.Controls.Add(this.richTextBox7);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(874, 1008);
            // 
            // buttonEditCustomer
            // 
            this.buttonEditCustomer.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditCustomer.Appearance.Options.UseFont = true;
            this.buttonEditCustomer.Location = new System.Drawing.Point(586, 290);
            this.buttonEditCustomer.Name = "buttonEditCustomer";
            this.buttonEditCustomer.Size = new System.Drawing.Size(166, 53);
            this.buttonEditCustomer.TabIndex = 31;
            this.buttonEditCustomer.Text = "Güncelle";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(17, 306);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(203, 37);
            this.richTextBox1.TabIndex = 30;
            this.richTextBox1.Text = "";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(17, 252);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(167, 39);
            this.labelControl8.TabIndex = 29;
            this.labelControl8.Text = "Müşteri Statüsü";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(561, 196);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(191, 34);
            this.richTextBox2.TabIndex = 28;
            this.richTextBox2.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(557, 148);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(195, 39);
            this.labelControl9.TabIndex = 27;
            this.labelControl9.Text = "Müşteri Telefon No";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(301, 195);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(214, 35);
            this.richTextBox3.TabIndex = 26;
            this.richTextBox3.Text = "";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(301, 148);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(142, 39);
            this.labelControl10.TabIndex = 25;
            this.labelControl10.Text = "Müşteri Şehri";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(17, 193);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(203, 37);
            this.richTextBox4.TabIndex = 24;
            this.richTextBox4.Text = "";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(17, 148);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(150, 39);
            this.labelControl11.TabIndex = 23;
            this.labelControl11.Text = "Müşteri Ülkesi";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(557, 92);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(186, 33);
            this.richTextBox5.TabIndex = 22;
            this.richTextBox5.Text = "";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(557, 47);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(154, 39);
            this.labelControl12.TabIndex = 21;
            this.labelControl12.Text = "Müşteri Adresi";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(301, 92);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(202, 33);
            this.richTextBox6.TabIndex = 20;
            this.richTextBox6.Text = "";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(301, 47);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(202, 39);
            this.labelControl13.TabIndex = 19;
            this.labelControl13.Text = "Müşteri Açıklaması";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(17, 47);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(138, 39);
            this.labelControl14.TabIndex = 18;
            this.labelControl14.Text = "Müşteri Kodu";
            // 
            // richTextBox7
            // 
            this.richTextBox7.Location = new System.Drawing.Point(17, 92);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(203, 33);
            this.richTextBox7.TabIndex = 17;
            this.richTextBox7.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custidDataGridViewTextBoxColumn,
            this.custcodeDataGridViewTextBoxColumn,
            this.custdescDataGridViewTextBoxColumn,
            this.custadressDataGridViewTextBoxColumn,
            this.custcountryDataGridViewTextBoxColumn,
            this.custcityDataGridViewTextBoxColumn,
            this.custphoneDataGridViewTextBoxColumn,
            this.custstatusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1283, 1109);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // custidDataGridViewTextBoxColumn
            // 
            this.custidDataGridViewTextBoxColumn.DataPropertyName = "cust_id";
            this.custidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.custidDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.custidDataGridViewTextBoxColumn.Name = "custidDataGridViewTextBoxColumn";
            this.custidDataGridViewTextBoxColumn.Width = 50;
            // 
            // custcodeDataGridViewTextBoxColumn
            // 
            this.custcodeDataGridViewTextBoxColumn.DataPropertyName = "cust_code";
            this.custcodeDataGridViewTextBoxColumn.HeaderText = "KOD";
            this.custcodeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.custcodeDataGridViewTextBoxColumn.Name = "custcodeDataGridViewTextBoxColumn";
            this.custcodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // custdescDataGridViewTextBoxColumn
            // 
            this.custdescDataGridViewTextBoxColumn.DataPropertyName = "cust_desc";
            this.custdescDataGridViewTextBoxColumn.HeaderText = "AÇIKLAMA";
            this.custdescDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.custdescDataGridViewTextBoxColumn.Name = "custdescDataGridViewTextBoxColumn";
            this.custdescDataGridViewTextBoxColumn.Width = 200;
            // 
            // custadressDataGridViewTextBoxColumn
            // 
            this.custadressDataGridViewTextBoxColumn.DataPropertyName = "cust_adress";
            this.custadressDataGridViewTextBoxColumn.HeaderText = "ADRES";
            this.custadressDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.custadressDataGridViewTextBoxColumn.Name = "custadressDataGridViewTextBoxColumn";
            this.custadressDataGridViewTextBoxColumn.Width = 300;
            // 
            // custcountryDataGridViewTextBoxColumn
            // 
            this.custcountryDataGridViewTextBoxColumn.DataPropertyName = "cust_country";
            this.custcountryDataGridViewTextBoxColumn.HeaderText = "ÜLKE";
            this.custcountryDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.custcountryDataGridViewTextBoxColumn.Name = "custcountryDataGridViewTextBoxColumn";
            this.custcountryDataGridViewTextBoxColumn.Width = 150;
            // 
            // custcityDataGridViewTextBoxColumn
            // 
            this.custcityDataGridViewTextBoxColumn.DataPropertyName = "cust_city";
            this.custcityDataGridViewTextBoxColumn.HeaderText = "ŞEHİR";
            this.custcityDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.custcityDataGridViewTextBoxColumn.Name = "custcityDataGridViewTextBoxColumn";
            this.custcityDataGridViewTextBoxColumn.Width = 200;
            // 
            // custphoneDataGridViewTextBoxColumn
            // 
            this.custphoneDataGridViewTextBoxColumn.DataPropertyName = "cust_phone";
            this.custphoneDataGridViewTextBoxColumn.HeaderText = "TEL";
            this.custphoneDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.custphoneDataGridViewTextBoxColumn.Name = "custphoneDataGridViewTextBoxColumn";
            this.custphoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // custstatusDataGridViewCheckBoxColumn
            // 
            this.custstatusDataGridViewCheckBoxColumn.DataPropertyName = "cust_status";
            this.custstatusDataGridViewCheckBoxColumn.HeaderText = "STATÜ";
            this.custstatusDataGridViewCheckBoxColumn.MinimumWidth = 10;
            this.custstatusDataGridViewCheckBoxColumn.Name = "custstatusDataGridViewCheckBoxColumn";
            this.custstatusDataGridViewCheckBoxColumn.Width = 200;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.cPS_WEBDataSet1;
            // 
            // cPS_WEBDataSet1
            // 
            this.cPS_WEBDataSet1.DataSetName = "CPS_WEBDataSet1";
            this.cPS_WEBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(399, 0);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(0, 0);
            this.simpleButton4.TabIndex = 1;
            this.simpleButton4.Text = "simpleButton4";
            // 
            // musteriduzenlemeButton
            // 
            this.musteriduzenlemeButton.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musteriduzenlemeButton.Appearance.Options.UseFont = true;
            this.musteriduzenlemeButton.Location = new System.Drawing.Point(264, 29);
            this.musteriduzenlemeButton.Name = "musteriduzenlemeButton";
            this.musteriduzenlemeButton.Size = new System.Drawing.Size(123, 57);
            this.musteriduzenlemeButton.TabIndex = 3;
            this.musteriduzenlemeButton.Text = "Düzenle";
            this.musteriduzenlemeButton.Click += new System.EventHandler(this.musteriduzenlemeButton_Click);
            // 
            // musteriSilmeButton
            // 
            this.musteriSilmeButton.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musteriSilmeButton.Appearance.Options.UseFont = true;
            this.musteriSilmeButton.Location = new System.Drawing.Point(136, 29);
            this.musteriSilmeButton.Name = "musteriSilmeButton";
            this.musteriSilmeButton.Size = new System.Drawing.Size(122, 57);
            this.musteriSilmeButton.TabIndex = 2;
            this.musteriSilmeButton.Text = "Sil";
            this.musteriSilmeButton.Click += new System.EventHandler(this.musterisilmeButton_Click);
            // 
            // musteriEklemeButton
            // 
            this.musteriEklemeButton.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musteriEklemeButton.Appearance.Options.UseFont = true;
            this.musteriEklemeButton.Location = new System.Drawing.Point(12, 29);
            this.musteriEklemeButton.Name = "musteriEklemeButton";
            this.musteriEklemeButton.Size = new System.Drawing.Size(118, 57);
            this.musteriEklemeButton.TabIndex = 0;
            this.musteriEklemeButton.Text = "Ekle";
            this.musteriEklemeButton.Click += new System.EventHandler(this.musterieklemeButton_Click);
            // 
            // cPS_WEBDataSet
            // 
            this.cPS_WEBDataSet.DataSetName = "CPS_WEBDataSet";
            this.cPS_WEBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataMember = "warehouse";
            this.warehouseBindingSource.DataSource = this.cPS_WEBDataSet;
            // 
            // warehouseTableAdapter
            // 
            this.warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(1775, 31);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(232, 55);
            this.simpleButton2.TabIndex = 38;
            this.simpleButton2.Text = "Ana Ekrana Dön";
            // 
            // CustomerCards
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2436, 1250);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.musteriKartlarıPanel);
            this.Controls.Add(this.musteriduzenlemeButton);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.xtraScrollableControl3);
            this.Controls.Add(this.musteriSilmeButton);
            this.Controls.Add(this.xtraScrollableControl2);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.musteriEklemeButton);
            this.Controls.Add(this.simpleButton7);
            this.Location = new System.Drawing.Point(5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerCards";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musteriKartlarıPanel)).EndInit();
            this.musteriKartlarıPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.musteriEklemePanel)).EndInit();
            this.musteriEklemePanel.ResumeLayout(false);
            this.musteriEklemePanel.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            this.tabNavigationPage3.ResumeLayout(false);
            this.tabNavigationPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPS_WEBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPS_WEBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            del_cust_id = int.Parse(textBox1.Text);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            dbHelper = new DatabaseHelper();

            if (del_cust_id == null || del_cust_id == 0)
            {
                MessageBox.Show("Lütfen Geçerli Kod Girin!!");
            }
            else {
                dbHelper.deleteCustomer(del_cust_id);
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
            cust_city = musteriSehriText.Text; 
        }

        private void musteriIdText_TextChanged(object sender, EventArgs e)
        {
            cust_id = 0;
        }

        private void musteriStatuText_TextChanged(object sender, EventArgs e)
        {
            if (musteriStatuText.Text == "1")
            {
                cust_status = true;
            }
            else {
                cust_status = false;
            }
        }

        private void musteriTelefonText_TextChanged_1(object sender, EventArgs e)
        {
            cust_phone = musteriTelefonText.Text;
        }

        private void musteriUlkesiText_TextChanged_1(object sender, EventArgs e)
        {
            cust_country = musteriUlkesiText.Text;
        }

        private void musteriAdresiText_TextChanged_1(object sender, EventArgs e)
        {
            cust_adress = musteriAdresiText.Text;
        }

        private void musteriAciklamasiText_TextChanged_1(object sender, EventArgs e)
        {
            cust_desc = musteriAciklamasiText.Text;
        }

        private void submitMusteriEkleme_Click(object sender, EventArgs e)
        {
            dbHelper = new DatabaseHelper();
            //if (dbHelper == null)
            //{
            //    MessageBox.Show("DatabaseHelper is not initialized.");
            //    return;
            //}

            MessageBox.Show("just clicked");
            dbHelper.AddRecord(cust_id, cust_code, cust_desc, cust_adress, cust_country, cust_city, cust_phone, cust_status);

            UpdateCustomerTable(this.dataGridView1);
        }

        private void UpdateCustomerTable(DataGridView dataGridView1)
        {
            // TODO


            //this.customerBindingSource.DataSource = this.cPS_WEBDataSet1;
            //this.cPS_WEBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //this.customerTableAdapter.ClearBeforeFill = true;
            //((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.cPS_WEBDataSet1)).EndInit();
        }

        private void musterieklemeButton_Click(object sender, EventArgs e)
        {
            musteriEklemePanel.Visible = true;
        }

        private void musterisilmeButton_Click(object sender, EventArgs e)
        {
            musteriEklemePanel.Visible = false;

        }

        private void musteriduzenlemeButton_Click(object sender, EventArgs e)
        {
            musteriEklemePanel.Visible = false;
        }

        private void musteriListesiButton_Click(object sender, EventArgs e)
        {
            musteriEklemePanel.Visible = false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dbHelper = new DatabaseHelper();
            //if (dbHelper == null)
            //{
            //    MessageBox.Show("DatabaseHelper is not initialized.");
            //    return;
            //}

            MessageBox.Show("just clicked");
            dbHelper.AddRecord(cust_id ,cust_code, cust_desc, cust_adress, cust_country, cust_city, cust_phone, cust_status);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            cust_id = 0;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (musteriStatuText.Text == "0")
            {
                cust_status = false;
            }
            else
            {
                cust_status = true;
            }
        }

        private void musteriTelefonText_TextChanged(object sender, EventArgs e)
        {
            cust_phone = musteriTelefonText.Text;
        }

        private void musteriSehriText_TextChanged(object sender, EventArgs e)
        {
            cust_city = musteriSehriText.Text;
        }

        private void musteriUlkesiText_TextChanged(object sender, EventArgs e)
        {
            cust_country = musteriUlkesiText.Text;
        }

        private void musteriAdresiText_TextChanged(object sender, EventArgs e)
        {
            cust_adress = musteriAdresiText.Text;
        }

        private void musteriAciklamasiText_TextChanged(object sender, EventArgs e)
        {
            cust_desc = musteriAciklamasiText.Text;
        }

        private void textBox2_TextChanged(String text)
        {
        }

        private void musteriKoduText_TextChanged(object sender, EventArgs e)
        {
            cust_code = musteriKoduText.Text;
        }

        private void changeColorButtonBasedPanel(PanelControl panel, SimpleButton button)
        {
            if (panel.Name == "musterikartlarıPanel")
            {
                button.BackColor = Color.DarkRed;
            }
        }
        #endregion


        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private int del_cust_id;
        private int cust_id;
        private String cust_code;
        private String cust_desc;
        private String cust_adress;
        private String cust_country;
        private String cust_city;
        private String cust_phone;
        private bool cust_status;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl2;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl3;
        private DevExpress.XtraEditors.PanelControl musteriKartlarıPanel;
        private DevExpress.XtraEditors.SimpleButton musteriduzenlemeButton;
        private DevExpress.XtraEditors.SimpleButton musteriSilmeButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton musteriEklemeButton;
        private DataGridView dataGridView1;
        private CPS_WEBDataSet cPS_WEBDataSet;
        private BindingSource warehouseBindingSource;
        private CPS_WEBDataSetTableAdapters.warehouseTableAdapter warehouseTableAdapter;
        private CPS_WEBDataSet1 cPS_WEBDataSet1;
        private BindingSource customerBindingSource;
        private CPS_WEBDataSet1TableAdapters.customerTableAdapter customerTableAdapter;
        private DataGridViewTextBoxColumn custidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn custcodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn custdescDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn custadressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn custcountryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn custcityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn custphoneDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn custstatusDataGridViewCheckBoxColumn;
        private SimpleButton simpleButton2;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private PanelControl musteriEklemePanel;
        private SimpleButton submitMusteriEkleme;
        private RichTextBox musteriStatuText;
        private LabelControl labelControl7;
        private RichTextBox musteriTelefonText;
        private LabelControl labelControl6;
        private RichTextBox musteriSehriText;
        private LabelControl labelControl5;
        private RichTextBox musteriUlkesiText;
        private LabelControl labelControl4;
        private RichTextBox musteriAdresiText;
        private LabelControl labelControl3;
        private RichTextBox musteriAciklamasiText;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private RichTextBox musteriKoduText;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private LabelControl labelCustomerIDDelete;
        private SimpleButton simpleButton3;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private TextBox textBox1;
        private SimpleButton buttonEditCustomer;
        private RichTextBox richTextBox1;
        private LabelControl labelControl8;
        private RichTextBox richTextBox2;
        private LabelControl labelControl9;
        private RichTextBox richTextBox3;
        private LabelControl labelControl10;
        private RichTextBox richTextBox4;
        private LabelControl labelControl11;
        private RichTextBox richTextBox5;
        private LabelControl labelControl12;
        private RichTextBox richTextBox6;
        private LabelControl labelControl13;
        private LabelControl labelControl14;
        private RichTextBox richTextBox7;
    }
}