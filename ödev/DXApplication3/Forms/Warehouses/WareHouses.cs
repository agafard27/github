using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication3.Forms.Warehouses
{
    public partial class WareHouses : Form
    {
        public WareHouses()
        {
            InitializeComponent();
        }

        private void WareHouses_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cPS_WEBDataSet2.warehouse' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.warehouseTableAdapter.Fill(this.cPS_WEBDataSet2.warehouse);

        }
    }
}
