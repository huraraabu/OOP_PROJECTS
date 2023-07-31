using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Garments_Management_System.Business_Layer;
using Garments_Management_System.Data_Layer;
using GmsGui.customerFrmFolder;
using GmsGui.Inputform;
using GmsGui.Data_Layer;
using GmsGui.ViewFormFolder;
using GmsGui.MenuFrmFolder;
namespace GmsGui.customerFrmFolder
{
    public partial class viewBrand : Form
    {
        public viewBrand()
        {
            InitializeComponent();
        }

        private void AddtoCardDrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void AddTocardViewFrm_Load(object sender, EventArgs e)
        {
            setBrandGrid();
        }
        DataTable table = new DataTable();
        public void setBrandGrid()
        {
            
                table.Columns.Add("Name", typeof(string));
              


                foreach (BrandDetail brand in BrandDetailCrud.GetBrandsList())
                {
                    table.Rows.Add(brand.getBrandName());
                }
            

            BrandGrid.DataSource = null;
            BrandGrid.DataSource = table;
            BrandGrid.Refresh();
        }
        public BrandDetail getBrandobj_FromSelectedRow_OfGrid()
        {
            string BrandNameFor_remove = "";
            if (BrandGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = BrandGrid.SelectedRows[0].Index;
                DataGridViewRow selectedRow = BrandGrid.SelectedRows[0];
                BrandNameFor_remove = selectedRow.Cells["Name"].Value.ToString();


            }
            BrandDetail RemoveBrand = BrandDetailCrud.getBrand_object(BrandNameFor_remove);
         
            return RemoveBrand;

        }
        private void Viewbtn_Click(object sender, EventArgs e)
        {
            Form tpDiscntFrm = new ClothFrm();
            BrandDetail Check_Sale_brand =getBrandobj_FromSelectedRow_OfGrid();
            if (Check_Sale_brand != null)
            {

                BrandDetailCrud.setDiscountedProdut(Check_Sale_brand, 'Y');
                tpDiscntFrm.ShowDialog();
           
            }
            else
            {
                MessageBox.Show("BRAND IS EMPTY","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
       
    }
}
