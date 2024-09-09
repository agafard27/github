using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DXApplication3.Helpers; // Add this using directive

namespace DXApplication3
{
    partial class Form2 
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.xtraScrollableControl3 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.musteriKartlarıPanel = new DevExpress.XtraEditors.PanelControl();
            this.musteriEklemePanel = new DevExpress.XtraEditors.PanelControl();
            this.submitMusteriEkleme = new DevExpress.XtraEditors.SimpleButton();
            this.musteriIdText = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
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
            this.musterilistesiButton = new DevExpress.XtraEditors.SimpleButton();
            this.musteriduzenlemeButton = new DevExpress.XtraEditors.SimpleButton();
            this.musteriSilmeButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.musteriEklemeButton = new DevExpress.XtraEditors.SimpleButton();
            this.musteriListesiPanel = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.musteriKartlarıPanel)).BeginInit();
            this.musteriKartlarıPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musteriEklemePanel)).BeginInit();
            this.musteriEklemePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musteriListesiPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(12, 31);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(261, 72);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Geri Dön";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(2068, 120);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(369, 52);
            this.textBox2.TabIndex = 8;
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.Location = new System.Drawing.Point(2068, 31);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(369, 83);
            this.simpleButton7.TabIndex = 9;
            this.simpleButton7.Text = "ARAMA";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.White;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Location = new System.Drawing.Point(2068, 178);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(369, 536);
            this.sidePanel1.TabIndex = 11;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Location = new System.Drawing.Point(2218, 109);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(75, 23);
            this.xtraScrollableControl1.TabIndex = 35;
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
            this.xtraScrollableControl3.Location = new System.Drawing.Point(315, 31);
            this.xtraScrollableControl3.Name = "xtraScrollableControl3";
            this.xtraScrollableControl3.Size = new System.Drawing.Size(1747, 1207);
            this.xtraScrollableControl3.TabIndex = 37;
            // 
            // musteriKartlarıPanel
            // 
            this.musteriKartlarıPanel.Controls.Add(this.musteriEklemePanel);
            this.musteriKartlarıPanel.Controls.Add(this.musterilistesiButton);
            this.musteriKartlarıPanel.Controls.Add(this.musteriduzenlemeButton);
            this.musteriKartlarıPanel.Controls.Add(this.musteriSilmeButton);
            this.musteriKartlarıPanel.Controls.Add(this.simpleButton4);
            this.musteriKartlarıPanel.Controls.Add(this.musteriEklemeButton);
            this.musteriKartlarıPanel.Location = new System.Drawing.Point(285, 34);
            this.musteriKartlarıPanel.Name = "musteriKartlarıPanel";
            this.musteriKartlarıPanel.Size = new System.Drawing.Size(1777, 1207);
            this.musteriKartlarıPanel.TabIndex = 0;
            // 
            // musteriEklemePanel
            // 
            this.musteriEklemePanel.Controls.Add(this.musteriListesiPanel);
            this.musteriEklemePanel.Controls.Add(this.submitMusteriEkleme);
            this.musteriEklemePanel.Controls.Add(this.musteriIdText);
            this.musteriEklemePanel.Controls.Add(this.labelControl8);
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
            this.musteriEklemePanel.Location = new System.Drawing.Point(33, 106);
            this.musteriEklemePanel.Name = "musteriEklemePanel";
            this.musteriEklemePanel.Size = new System.Drawing.Size(1739, 1125);
            this.musteriEklemePanel.TabIndex = 5;
            // 
            // submitMusteriEkleme
            // 
            this.submitMusteriEkleme.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitMusteriEkleme.Appearance.Options.UseFont = true;
            this.submitMusteriEkleme.Location = new System.Drawing.Point(857, 647);
            this.submitMusteriEkleme.Name = "submitMusteriEkleme";
            this.submitMusteriEkleme.Size = new System.Drawing.Size(304, 72);
            this.submitMusteriEkleme.TabIndex = 16;
            this.submitMusteriEkleme.Text = "Ekle";
            // 
            // musteriIdText
            // 
            this.musteriIdText.Location = new System.Drawing.Point(493, 647);
            this.musteriIdText.Name = "musteriIdText";
            this.musteriIdText.Size = new System.Drawing.Size(304, 67);
            this.musteriIdText.TabIndex = 15;
            this.musteriIdText.Text = "";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(493, 583);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(171, 58);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Müşteri  ID";
            // 
            // musteriStatuText
            // 
            this.musteriStatuText.Location = new System.Drawing.Point(119, 647);
            this.musteriStatuText.Name = "musteriStatuText";
            this.musteriStatuText.Size = new System.Drawing.Size(304, 67);
            this.musteriStatuText.TabIndex = 13;
            this.musteriStatuText.Text = "";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(119, 583);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(255, 58);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Müşteri Statüsü";
            // 
            // musteriTelefonText
            // 
            this.musteriTelefonText.Location = new System.Drawing.Point(857, 436);
            this.musteriTelefonText.Name = "musteriTelefonText";
            this.musteriTelefonText.Size = new System.Drawing.Size(304, 67);
            this.musteriTelefonText.TabIndex = 11;
            this.musteriTelefonText.Text = "";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(857, 372);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(296, 58);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Müşteri Telefon No";
            // 
            // musteriSehriText
            // 
            this.musteriSehriText.Location = new System.Drawing.Point(493, 436);
            this.musteriSehriText.Name = "musteriSehriText";
            this.musteriSehriText.Size = new System.Drawing.Size(304, 67);
            this.musteriSehriText.TabIndex = 9;
            this.musteriSehriText.Text = "";
            this.musteriSehriText.TextChanged += new System.EventHandler(this.richTextBox5_TextChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(493, 372);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(216, 58);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Müşteri Şehri";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // musteriUlkesiText
            // 
            this.musteriUlkesiText.Location = new System.Drawing.Point(119, 436);
            this.musteriUlkesiText.Name = "musteriUlkesiText";
            this.musteriUlkesiText.Size = new System.Drawing.Size(304, 67);
            this.musteriUlkesiText.TabIndex = 7;
            this.musteriUlkesiText.Text = "";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(119, 372);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(227, 58);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Müşteri Ülkesi";
            // 
            // musteriAdresiText
            // 
            this.musteriAdresiText.Location = new System.Drawing.Point(857, 213);
            this.musteriAdresiText.Name = "musteriAdresiText";
            this.musteriAdresiText.Size = new System.Drawing.Size(304, 67);
            this.musteriAdresiText.TabIndex = 5;
            this.musteriAdresiText.Text = "";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(857, 149);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(232, 58);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Müşteri Adresi";
            // 
            // musteriAciklamasiText
            // 
            this.musteriAciklamasiText.Location = new System.Drawing.Point(493, 213);
            this.musteriAciklamasiText.Name = "musteriAciklamasiText";
            this.musteriAciklamasiText.Size = new System.Drawing.Size(304, 67);
            this.musteriAciklamasiText.TabIndex = 3;
            this.musteriAciklamasiText.Text = "";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(493, 149);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(307, 58);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Müşteri Açıklaması";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(119, 149);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(208, 58);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Müşteri Kodu";
            // 
            // musteriKoduText
            // 
            this.musteriKoduText.Location = new System.Drawing.Point(119, 213);
            this.musteriKoduText.Name = "musteriKoduText";
            this.musteriKoduText.Size = new System.Drawing.Size(304, 67);
            this.musteriKoduText.TabIndex = 0;
            this.musteriKoduText.Text = "";
            // 
            // musterilistesiButton
            // 
            this.musterilistesiButton.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musterilistesiButton.Appearance.Options.UseFont = true;
            this.musterilistesiButton.Location = new System.Drawing.Point(1092, 0);
            this.musterilistesiButton.Name = "musterilistesiButton";
            this.musterilistesiButton.Size = new System.Drawing.Size(348, 72);
            this.musterilistesiButton.TabIndex = 4;
            this.musterilistesiButton.Text = "Müşteri Listesi";
            this.musterilistesiButton.Click += new System.EventHandler(this.musteriListesiButton_Click);
            // 
            // musteriduzenlemeButton
            // 
            this.musteriduzenlemeButton.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musteriduzenlemeButton.Appearance.Options.UseFont = true;
            this.musteriduzenlemeButton.Location = new System.Drawing.Point(738, 0);
            this.musteriduzenlemeButton.Name = "musteriduzenlemeButton";
            this.musteriduzenlemeButton.Size = new System.Drawing.Size(348, 72);
            this.musteriduzenlemeButton.TabIndex = 3;
            this.musteriduzenlemeButton.Text = "Müşteri Düzenleme";
            this.musteriduzenlemeButton.Click += new System.EventHandler(this.musteriduzenlemeButton_Click);
            // 
            // musteriSilmeButton
            // 
            this.musteriSilmeButton.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musteriSilmeButton.Appearance.Options.UseFont = true;
            this.musteriSilmeButton.Location = new System.Drawing.Point(384, 0);
            this.musteriSilmeButton.Name = "musteriSilmeButton";
            this.musteriSilmeButton.Size = new System.Drawing.Size(348, 72);
            this.musteriSilmeButton.TabIndex = 2;
            this.musteriSilmeButton.Text = "Müşteri Silme";
            this.musteriSilmeButton.Click += new System.EventHandler(this.musterisilmeButton_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(399, 0);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(0, 0);
            this.simpleButton4.TabIndex = 1;
            this.simpleButton4.Text = "simpleButton4";
            // 
            // musteriEklemeButton
            // 
            this.musteriEklemeButton.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musteriEklemeButton.Appearance.Options.UseFont = true;
            this.musteriEklemeButton.Location = new System.Drawing.Point(30, 0);
            this.musteriEklemeButton.Name = "musteriEklemeButton";
            this.musteriEklemeButton.Size = new System.Drawing.Size(348, 72);
            this.musteriEklemeButton.TabIndex = 0;
            this.musteriEklemeButton.Text = "Müşteri Ekleme";
            this.musteriEklemeButton.Click += new System.EventHandler(this.musterieklemeButton_Click);
            // 
            // musteriListesiPanel
            // 
            this.musteriListesiPanel.Location = new System.Drawing.Point(2, 0);
            this.musteriListesiPanel.Name = "musteriListesiPanel";
            this.musteriListesiPanel.Size = new System.Drawing.Size(1739, 1125);
            this.musteriListesiPanel.TabIndex = 38;
            this.musteriListesiPanel.Visible = false;
            // 
            // Form2
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2436, 1250);
            this.Controls.Add(this.musteriKartlarıPanel);
            this.Controls.Add(this.xtraScrollableControl3);
            this.Controls.Add(this.xtraScrollableControl2);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.simpleButton1);
            this.Location = new System.Drawing.Point(5, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musteriKartlarıPanel)).EndInit();
            this.musteriKartlarıPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.musteriEklemePanel)).EndInit();
            this.musteriEklemePanel.ResumeLayout(false);
            this.musteriEklemePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musteriListesiPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void musterieklemeButton_Click(object sender, EventArgs e)
        {
            musteriEklemePanel.Visible = true;
            musteriListesiPanel.Visible = false;
        }

        private void musterisilmeButton_Click(object sender, EventArgs e)
        {
            musteriListesiPanel.Visible = false;
            musteriEklemePanel.Visible = false;

        }

        private void musteriduzenlemeButton_Click(object sender, EventArgs e)
        {
            musteriListesiPanel.Visible = false;
            musteriEklemePanel.Visible = false;
        }

        private void musteriListesiButton_Click(object sender, EventArgs e)
        {
            musteriEklemePanel.Visible = false;
            musteriListesiPanel.Visible = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dbHelper == null)
            {
                MessageBox.Show("DatabaseHelper is not initialized.");
                return;
            }
            dbHelper.AddRecord(cust_id ,cust_code, cust_desc, cust_adress, cust_country, cust_city, cust_phone, cust_status);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            cust_id = int.Parse(musteriIdText.Text);
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            cust_phone = musteriTelefonText.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            cust_city = musteriSehriText.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            cust_country = musteriUlkesiText.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            cust_adress = musteriAdresiText.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            cust_desc = musteriAciklamasiText.Text;
        }

        private void textBox2_TextChanged(String text)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
        private System.Windows.Forms.TextBox textBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private int cust_id;
        private String cust_code;
        private String cust_desc;
        private String cust_adress;
        private String cust_country;
        private String cust_city;
        private String cust_phone;
        private bool cust_status;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl2;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl3;
        private DevExpress.XtraEditors.PanelControl musteriKartlarıPanel;
        private DevExpress.XtraEditors.SimpleButton musteriduzenlemeButton;
        private DevExpress.XtraEditors.SimpleButton musteriSilmeButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton musteriEklemeButton;
        private SimpleButton musterilistesiButton;
        private PanelControl musteriEklemePanel;
        private RichTextBox musteriAdresiText;
        private LabelControl labelControl3;
        private RichTextBox musteriAciklamasiText;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private RichTextBox musteriKoduText;
        private RichTextBox musteriSehriText;
        private LabelControl labelControl5;
        private RichTextBox musteriUlkesiText;
        private LabelControl labelControl4;
        private RichTextBox musteriIdText;
        private LabelControl labelControl8;
        private RichTextBox musteriStatuText;
        private LabelControl labelControl7;
        private RichTextBox musteriTelefonText;
        private LabelControl labelControl6;
        private SimpleButton submitMusteriEkleme;
        private PanelControl musteriListesiPanel;
    }
}