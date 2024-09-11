using DXApplication3.Helpers;
using System;

namespace DXApplication3.Forms.Warehouses
{
    partial class WareHouses
    {

        DatabaseHelper dbHelper; 
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.buttonWarehouseAdd = new DevExpress.XtraEditors.SimpleButton();
            this.textboxWarehouseStatusAdd = new System.Windows.Forms.TextBox();
            this.textboxWarehouseDescriptionAdd = new System.Windows.Forms.TextBox();
            this.textboxWarehouseCodeAdd = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.buttonWarehouseEdit = new DevExpress.XtraEditors.SimpleButton();
            this.textboxWarehouseStatusEdit = new System.Windows.Forms.TextBox();
            this.textboxWarehouseDescriptionEdit = new System.Windows.Forms.TextBox();
            this.textboxWarehouseCodeEdit = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.buttonWarehouseDelete = new DevExpress.XtraEditors.SimpleButton();
            this.textboxWarehouseCodeDelete = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wareidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waredescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warestatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPS_WEBDataSet2 = new DXApplication3.CPS_WEBDataSet2();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.cPS_WEBDataSet = new DXApplication3.CPS_WEBDataSet();
            this.cPSWEBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseTableAdapter = new DXApplication3.CPS_WEBDataSet2TableAdapters.warehouseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPS_WEBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPS_WEBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPSWEBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tabPane1);
            this.panelControl1.Controls.Add(this.dataGridView1);
            this.panelControl1.Location = new System.Drawing.Point(12, 79);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(2546, 1316);
            this.panelControl1.TabIndex = 0;
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Location = new System.Drawing.Point(892, 50);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(1654, 1258);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1654, 1258);
            this.tabPane1.TabIndex = 1;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Ekle";
            this.tabNavigationPage1.Controls.Add(this.buttonWarehouseAdd);
            this.tabNavigationPage1.Controls.Add(this.textboxWarehouseStatusAdd);
            this.tabNavigationPage1.Controls.Add(this.textboxWarehouseDescriptionAdd);
            this.tabNavigationPage1.Controls.Add(this.textboxWarehouseCodeAdd);
            this.tabNavigationPage1.Controls.Add(this.labelControl3);
            this.tabNavigationPage1.Controls.Add(this.labelControl2);
            this.tabNavigationPage1.Controls.Add(this.labelControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1654, 1192);
            // 
            // buttonWarehouseAdd
            // 
            this.buttonWarehouseAdd.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWarehouseAdd.Appearance.Options.UseFont = true;
            this.buttonWarehouseAdd.Location = new System.Drawing.Point(34, 375);
            this.buttonWarehouseAdd.Name = "buttonWarehouseAdd";
            this.buttonWarehouseAdd.Size = new System.Drawing.Size(174, 46);
            this.buttonWarehouseAdd.TabIndex = 6;
            this.buttonWarehouseAdd.Text = "Ekle";
            this.buttonWarehouseAdd.Click += new System.EventHandler(this.buttonWarehouseAdd_Click);
            // 
            // textboxWarehouseStatusAdd
            // 
            this.textboxWarehouseStatusAdd.Location = new System.Drawing.Point(34, 304);
            this.textboxWarehouseStatusAdd.Multiline = true;
            this.textboxWarehouseStatusAdd.Name = "textboxWarehouseStatusAdd";
            this.textboxWarehouseStatusAdd.Size = new System.Drawing.Size(174, 36);
            this.textboxWarehouseStatusAdd.TabIndex = 5;
            this.textboxWarehouseStatusAdd.TextChanged += new System.EventHandler(this.textboxWarehouseStatusAdd_TextChanged);
            // 
            // textboxWarehouseDescriptionAdd
            // 
            this.textboxWarehouseDescriptionAdd.Location = new System.Drawing.Point(34, 195);
            this.textboxWarehouseDescriptionAdd.Multiline = true;
            this.textboxWarehouseDescriptionAdd.Name = "textboxWarehouseDescriptionAdd";
            this.textboxWarehouseDescriptionAdd.Size = new System.Drawing.Size(174, 36);
            this.textboxWarehouseDescriptionAdd.TabIndex = 4;
            this.textboxWarehouseDescriptionAdd.TextChanged += new System.EventHandler(this.textboxWarehouseDescriptionAdd_TextChanged);
            // 
            // textboxWarehouseCodeAdd
            // 
            this.textboxWarehouseCodeAdd.Location = new System.Drawing.Point(34, 85);
            this.textboxWarehouseCodeAdd.Multiline = true;
            this.textboxWarehouseCodeAdd.Name = "textboxWarehouseCodeAdd";
            this.textboxWarehouseCodeAdd.Size = new System.Drawing.Size(174, 36);
            this.textboxWarehouseCodeAdd.TabIndex = 3;
            this.textboxWarehouseCodeAdd.TextChanged += new System.EventHandler(this.textboxWarehouseCodeAdd_TextChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(34, 259);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(139, 39);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Depo Statüsü";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(34, 150);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(174, 39);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Depo Açıklaması";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(34, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Depo Kodu";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Düzenle";
            this.tabNavigationPage2.Controls.Add(this.buttonWarehouseEdit);
            this.tabNavigationPage2.Controls.Add(this.textboxWarehouseStatusEdit);
            this.tabNavigationPage2.Controls.Add(this.textboxWarehouseDescriptionEdit);
            this.tabNavigationPage2.Controls.Add(this.textboxWarehouseCodeEdit);
            this.tabNavigationPage2.Controls.Add(this.labelControl4);
            this.tabNavigationPage2.Controls.Add(this.labelControl5);
            this.tabNavigationPage2.Controls.Add(this.labelControl6);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1654, 1192);
            // 
            // buttonWarehouseEdit
            // 
            this.buttonWarehouseEdit.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWarehouseEdit.Appearance.Options.UseFont = true;
            this.buttonWarehouseEdit.Location = new System.Drawing.Point(38, 376);
            this.buttonWarehouseEdit.Name = "buttonWarehouseEdit";
            this.buttonWarehouseEdit.Size = new System.Drawing.Size(174, 46);
            this.buttonWarehouseEdit.TabIndex = 13;
            this.buttonWarehouseEdit.Text = "Güncelle";
            // 
            // textboxWarehouseStatusEdit
            // 
            this.textboxWarehouseStatusEdit.Location = new System.Drawing.Point(38, 305);
            this.textboxWarehouseStatusEdit.Multiline = true;
            this.textboxWarehouseStatusEdit.Name = "textboxWarehouseStatusEdit";
            this.textboxWarehouseStatusEdit.Size = new System.Drawing.Size(174, 36);
            this.textboxWarehouseStatusEdit.TabIndex = 12;
            // 
            // textboxWarehouseDescriptionEdit
            // 
            this.textboxWarehouseDescriptionEdit.Location = new System.Drawing.Point(38, 196);
            this.textboxWarehouseDescriptionEdit.Multiline = true;
            this.textboxWarehouseDescriptionEdit.Name = "textboxWarehouseDescriptionEdit";
            this.textboxWarehouseDescriptionEdit.Size = new System.Drawing.Size(174, 36);
            this.textboxWarehouseDescriptionEdit.TabIndex = 11;
            // 
            // textboxWarehouseCodeEdit
            // 
            this.textboxWarehouseCodeEdit.Location = new System.Drawing.Point(38, 86);
            this.textboxWarehouseCodeEdit.Multiline = true;
            this.textboxWarehouseCodeEdit.Name = "textboxWarehouseCodeEdit";
            this.textboxWarehouseCodeEdit.Size = new System.Drawing.Size(174, 36);
            this.textboxWarehouseCodeEdit.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(38, 260);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(139, 39);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Depo Statüsü";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(38, 151);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(174, 39);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Depo Açıklaması";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(38, 41);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(110, 39);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Depo Kodu";
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Sil";
            this.tabNavigationPage3.Controls.Add(this.buttonWarehouseDelete);
            this.tabNavigationPage3.Controls.Add(this.textboxWarehouseCodeDelete);
            this.tabNavigationPage3.Controls.Add(this.labelControl7);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1654, 1192);
            // 
            // buttonWarehouseDelete
            // 
            this.buttonWarehouseDelete.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWarehouseDelete.Appearance.Options.UseFont = true;
            this.buttonWarehouseDelete.Location = new System.Drawing.Point(40, 160);
            this.buttonWarehouseDelete.Name = "buttonWarehouseDelete";
            this.buttonWarehouseDelete.Size = new System.Drawing.Size(174, 46);
            this.buttonWarehouseDelete.TabIndex = 16;
            this.buttonWarehouseDelete.Text = "Sil";
            // 
            // textboxWarehouseCodeDelete
            // 
            this.textboxWarehouseCodeDelete.Location = new System.Drawing.Point(40, 89);
            this.textboxWarehouseCodeDelete.Multiline = true;
            this.textboxWarehouseCodeDelete.Name = "textboxWarehouseCodeDelete";
            this.textboxWarehouseCodeDelete.Size = new System.Drawing.Size(174, 36);
            this.textboxWarehouseCodeDelete.TabIndex = 15;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(40, 44);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(110, 39);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Depo Kodu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wareidDataGridViewTextBoxColumn,
            this.warecodeDataGridViewTextBoxColumn,
            this.waredescDataGridViewTextBoxColumn,
            this.warestatusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.warehouseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(885, 1310);
            this.dataGridView1.TabIndex = 0;
            // 
            // wareidDataGridViewTextBoxColumn
            // 
            this.wareidDataGridViewTextBoxColumn.DataPropertyName = "ware_id";
            this.wareidDataGridViewTextBoxColumn.HeaderText = "ware_id";
            this.wareidDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.wareidDataGridViewTextBoxColumn.Name = "wareidDataGridViewTextBoxColumn";
            this.wareidDataGridViewTextBoxColumn.Width = 200;
            // 
            // warecodeDataGridViewTextBoxColumn
            // 
            this.warecodeDataGridViewTextBoxColumn.DataPropertyName = "ware_code";
            this.warecodeDataGridViewTextBoxColumn.HeaderText = "ware_code";
            this.warecodeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.warecodeDataGridViewTextBoxColumn.Name = "warecodeDataGridViewTextBoxColumn";
            this.warecodeDataGridViewTextBoxColumn.Width = 200;
            // 
            // waredescDataGridViewTextBoxColumn
            // 
            this.waredescDataGridViewTextBoxColumn.DataPropertyName = "ware_desc";
            this.waredescDataGridViewTextBoxColumn.HeaderText = "ware_desc";
            this.waredescDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.waredescDataGridViewTextBoxColumn.Name = "waredescDataGridViewTextBoxColumn";
            this.waredescDataGridViewTextBoxColumn.Width = 200;
            // 
            // warestatusDataGridViewCheckBoxColumn
            // 
            this.warestatusDataGridViewCheckBoxColumn.DataPropertyName = "ware_status";
            this.warestatusDataGridViewCheckBoxColumn.HeaderText = "ware_status";
            this.warestatusDataGridViewCheckBoxColumn.MinimumWidth = 10;
            this.warestatusDataGridViewCheckBoxColumn.Name = "warestatusDataGridViewCheckBoxColumn";
            this.warestatusDataGridViewCheckBoxColumn.Width = 200;
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataMember = "warehouse";
            this.warehouseBindingSource.DataSource = this.cPS_WEBDataSet2;
            // 
            // cPS_WEBDataSet2
            // 
            this.cPS_WEBDataSet2.DataSetName = "CPS_WEBDataSet2";
            this.cPS_WEBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(13, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(152, 52);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Ekle";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(171, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(150, 52);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Sil";
            this.simpleButton2.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(327, 4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(148, 52);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Düzenle";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Location = new System.Drawing.Point(2360, 4);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(192, 52);
            this.simpleButton4.TabIndex = 4;
            this.simpleButton4.Text = "Geri Dön";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Location = new System.Drawing.Point(2155, 4);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(199, 52);
            this.simpleButton5.TabIndex = 5;
            this.simpleButton5.Text = "Ana Ekrana Dön";
            // 
            // cPS_WEBDataSet
            // 
            this.cPS_WEBDataSet.DataSetName = "CPS_WEBDataSet";
            this.cPS_WEBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cPSWEBDataSetBindingSource
            // 
            this.cPSWEBDataSetBindingSource.DataSource = this.cPS_WEBDataSet;
            this.cPSWEBDataSetBindingSource.Position = 0;
            // 
            // warehouseTableAdapter
            // 
            this.warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // WareHouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 1399);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.panelControl1);
            this.Name = "WareHouses";
            this.Text = "WareHouses";
            this.Load += new System.EventHandler(this.WareHouses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            this.tabNavigationPage3.ResumeLayout(false);
            this.tabNavigationPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPS_WEBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPS_WEBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPSWEBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void buttonWarehouseAdd_Click(object sender, EventArgs e)
        {
            dbHelper = new DatabaseHelper();

            dbHelper.AddWarehouse(ware_code, ware_desc, ware_status);

        }

        private void textboxWarehouseStatusAdd_TextChanged(object sender, EventArgs e)
        {
            if (textboxWarehouseStatusAdd.Text == "1")
            {
                ware_status = true;
            }
            else {

                ware_status = false;
            }
        }

        private void textboxWarehouseDescriptionAdd_TextChanged(object sender, EventArgs e)
        {
            ware_desc = textboxWarehouseDescriptionAdd.Text;
        }

        private void textboxWarehouseCodeAdd_TextChanged(object sender, EventArgs e)
        {
            ware_code = textboxWarehouseCodeAdd.Text;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private string ware_code;
        private string ware_desc;
        private bool ware_status; 
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cPSWEBDataSetBindingSource;
        private CPS_WEBDataSet cPS_WEBDataSet;
        private CPS_WEBDataSet2 cPS_WEBDataSet2;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private CPS_WEBDataSet2TableAdapters.warehouseTableAdapter warehouseTableAdapter;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn wareidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waredescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn warestatusDataGridViewCheckBoxColumn;
        private DevExpress.XtraEditors.SimpleButton buttonWarehouseAdd;
        private System.Windows.Forms.TextBox textboxWarehouseStatusAdd;
        private System.Windows.Forms.TextBox textboxWarehouseDescriptionAdd;
        private System.Windows.Forms.TextBox textboxWarehouseCodeAdd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton buttonWarehouseEdit;
        private System.Windows.Forms.TextBox textboxWarehouseStatusEdit;
        private System.Windows.Forms.TextBox textboxWarehouseDescriptionEdit;
        private System.Windows.Forms.TextBox textboxWarehouseCodeEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraEditors.SimpleButton buttonWarehouseDelete;
        private System.Windows.Forms.TextBox textboxWarehouseCodeDelete;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}