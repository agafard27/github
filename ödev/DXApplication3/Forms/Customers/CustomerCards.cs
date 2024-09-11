using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DXApplication3.Models;
using System.Windows.Forms;

namespace DXApplication3
{
    public partial class CustomerCards : DevExpress.XtraEditors.XtraForm
    {

        //private static readonly HttpClient client = new HttpClient();

        public CustomerCards()
        {
            InitializeComponent();
        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MainForm form1 = new MainForm();

            form1.Show();

            this.Hide();
        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void bilgitanımlamalarıDropDownButton_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cPS_WEBDataSet1.customer' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.customerTableAdapter.Fill(this.cPS_WEBDataSet1.customer);
            // TODO: Bu kod satırı 'cPS_WEBDataSet.warehouse' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.warehouseTableAdapter.Fill(this.cPS_WEBDataSet.warehouse);

        }

        private void navigationPane1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void musteriDuzenlemePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}