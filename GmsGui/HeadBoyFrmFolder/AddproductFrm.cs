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
using GmsGui.Inputform;
using GmsGui.customerFrmFolder;
using GmsGui.ViewFormFolder;
using GmsGui.Data_Layer;
using GmsGui.MenuFrmFolder;

namespace GmsGui.HeadBoyFrmFolder
{
    public partial class AddproductFrm : Form
    {
        public static BrandDetail clothBrand = new BrandDetail();
        public AddproductFrm()
        {
            InitializeComponent();
        }

        private void sidebarpln_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductMenuBtn_Click(object sender, EventArgs e)
        {
            setBrandGrid();
        }
        public void setBrandGrid()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Name", typeof(string));



            foreach (BrandDetail brand in BrandDetailCrud.GetBrandsList())
            {
                table.Rows.Add(brand.getBrandName());
            }


            BrandGrid.DataSource = null;
            BrandGrid.DataSource = table;
            BrandGrid.Refresh();
        }
        public void getBrandobj_FromSelectedRow_OfGrid()
        {
            string BrandNameFor_remove = "";
            if (BrandGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = BrandGrid.SelectedRows[0].Index;
                DataGridViewRow selectedRow = BrandGrid.SelectedRows[0];
                BrandNameFor_remove = selectedRow.Cells["Name"].Value.ToString();


            }
            BrandDetail RemoveBrand = BrandDetailCrud.getBrand_object(BrandNameFor_remove);
            clothBrand= RemoveBrand;
            

        }
        private void AddproductFrm_Load(object sender, EventArgs e)
        {

        }

        private void MenBtn_Click(object sender, EventArgs e)
        {
            getBrandobj_FromSelectedRow_OfGrid();
            if (clothBrand != null)
            {
                Form clothFrm = new ClothDetailFrm();
                clothFrm.ShowDialog();
                ClothDetail clothMen = clothBrand.getMenCloth_object();
                clothMen = ClothDetailFrm.currentCloth;
                clothBrand.set_MenClothObject(clothMen);
            }
            else
            {
                MessageBox.Show("SELECT BRAND", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void WomenBtn_Click(object sender, EventArgs e)
        {
            getBrandobj_FromSelectedRow_OfGrid();
            if (clothBrand != null)
            {
                Form clothFrm = new ClothDetailFrm();
                clothFrm.ShowDialog();
                ClothDetail clothMen = clothBrand.getWoMenCloth_object();
                clothMen = ClothDetailFrm.currentCloth;
                clothBrand.set_WoMenClothObject(clothMen);
            }
            else
            {
                MessageBox.Show("SELECT BRAND", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BabyBtn_Click(object sender, EventArgs e)
        {
            getBrandobj_FromSelectedRow_OfGrid();
            if (clothBrand != null)
            {
                Form clothFrm = new ClothDetailFrm();
                clothFrm.ShowDialog();
                ClothDetail clothMen = clothBrand.getBabyCloth_object();
                clothMen = ClothDetailFrm.currentCloth;
                clothBrand.setBabyCloth(clothMen);
            }
            else
            {
                MessageBox.Show("SELECT BRAND", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void backTocustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeadBoyFrm frm = new HeadBoyFrm();
            frm.ShowDialog();
        }
    }
}
