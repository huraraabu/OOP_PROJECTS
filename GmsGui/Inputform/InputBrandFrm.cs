using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Garments_Management_System.Data_Layer;
using Garments_Management_System.Business_Layer;

namespace GmsGui.Data_Layer
{
    public partial class InputBrandFrm : Form
    {
        private static String brandName;
        public InputBrandFrm()
        {
            InitializeComponent();
        }

        public static string BrandName { get => brandName; set => brandName = value; }

        

        private void adminSearchbtn_Click(object sender, EventArgs e)
        {
            BrandDetail Check_discounted_brand = BrandDetailCrud.get_object();
            if (Check_discounted_brand != null)
            {
                BrandDetailCrud.setDiscountedProdut(Check_discounted_brand, 'N');
            }
            else
            {
                invalidLbl.Show();
            }
        }


        private void InputBrandFrm_Load(object sender, EventArgs e)
        {
            TpDisclothGrid.DataSource = null;
            TpDisclothGrid.DataSource = BrandDetailCrud.clothDetailGrid;
            BrandDetailCrud.clothDetailGrid = null;
        }

        private void TpDisclothGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
