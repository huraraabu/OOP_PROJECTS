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

namespace GmsGui.ViewFormFolder
{
    public partial class ViewBrandFrm : Form
    {
        public static BrandDetail brandFromGrid;
        public char menuStatus = 'N';
        DataTable table = new DataTable();
        public ViewBrandFrm()
        {
            InitializeComponent();
        }

        private void BrandGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void ViewBrandFrm_Load(object sender, EventArgs e)
        {
            setBrandDetail();
            setBrandGrid();
        }
        public void setBrandDetail()
        {
            BabyGrid.Visible = false;
            BrandGrid.Visible = true;
            MenclothGrid.Visible = false;
            womenGrid.Visible = false;
            WomenClothLbl.Visible = false;
            babylbl.Visible = false;
            MenClothLbl.Visible = false;
            backtoMen.Visible = false;
            backtoWomenpic.Visible = false;
            backtoBrand.Visible = false;
            backToHeadPIc.Visible = true;
            babyNextPic.Visible = false;
            menNextPic.Visible = false;
            brandnameLbl.Visible = true;
            viewBtnPLn.Visible = true;
            RemoveBrandbtn.Visible = true;
          
        }
        public void setBrandGrid()
        {
            if (menuStatus == 'N')
            {
                table.Columns.Add("Name", typeof(string));
                menuStatus = 'Y';


                foreach (BrandDetail brand in BrandDetailCrud.GetBrandsList())
                {
                    table.Rows.Add(brand.getBrandName());
                }
            }

            BrandGrid.DataSource = null;
            BrandGrid.DataSource = table;
            BrandGrid.Refresh();
        }

        private void RemoveBrandbtn_Click(object sender, EventArgs e)
        {
            setWomenDetail();
            setWomenGridDetail();
        }
        public void setWomenDetail()
        {
            BabyGrid.Visible = false;
            BrandGrid.Visible =false;
            MenclothGrid.Visible = false;
            womenGrid.Visible = true;
            WomenClothLbl.Visible = true;
            babylbl.Visible = false;
            MenClothLbl.Visible = false;
            brandnameLbl.Visible = false;
            viewBtnPLn.Visible = false;
            menNextPic.Visible = true;
            babyNextPic.Visible = false;
            RemoveBrandbtn.Visible = false;
            backtoBrand.Visible = true;
            backtoMen.Visible = false;
            backtoWomenpic.Visible = false;
            backToHeadPIc.Visible = false;
         

        }
        public BrandDetail  getBrandobj_FromSelectedRow_OfGrid()
        {
            string BrandNameFor_remove = "";
            if (BrandGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = BrandGrid.SelectedRows[0].Index;
                DataGridViewRow selectedRow = BrandGrid.SelectedRows[0];
                BrandNameFor_remove = selectedRow.Cells["Name"].Value.ToString();
             

            }
            BrandDetail RemoveBrand = BrandDetailCrud.getBrand_object(BrandNameFor_remove);
            brandFromGrid = RemoveBrand;
            return RemoveBrand;

        }



        public void setWomenGridDetail()
        {
            DataTable table = new DataTable();
            BrandDetail brand = getBrandobj_FromSelectedRow_OfGrid();
            if (brand != null)
            {
                // if (brand.getWoMenListLength() != 0)
                //{
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Color", typeof(string));
                table.Columns.Add("Price", typeof(string));
                table.Columns.Add("Size", typeof(string));


                for (int indxeNumber = 0; indxeNumber < brand.getWoMenListLength(); indxeNumber++)
                {
                    ClothDetail cloth = brand.get_WoMenListObject(indxeNumber);
                    table.Rows.Add(cloth.getName(),cloth.getColor(),cloth.getPrice(),cloth.getSize());

                }

            }
            else
            {
                MessageBox.Show("FIRST SELECT BRAND","q",MessageBoxButtons.OK);

            }
            //}
            womenGrid.DataSource = null;
            womenGrid.DataSource = table;
            womenGrid.Refresh();
        }
        public void setMenDetail()
        {
            
            babyNextPic.Visible = true;
            MenclothGrid.Visible = true;
            MenClothLbl.Visible = true;
            BabyGrid.Visible = false;
            BrandGrid.Visible = false;
            womenGrid.Visible = false;
            WomenClothLbl.Visible = false;
            babylbl.Visible = false;
            viewBtnPLn.Visible = false;
            menNextPic.Visible = false;
            backtoBrand.Visible = false;
            backtoMen.Visible = false;
            backtoWomenpic.Visible = true;
            backToHeadPIc.Visible = false;
          
         
        }
        private void menNextPic_Click(object sender, EventArgs e)
        {
            setMenDetail();
            DataTable table = new DataTable();
            BrandDetail brand = brandFromGrid;

           // if (brand.getMenListLength() != 0)
            
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Color", typeof(string));
                table.Columns.Add("Price", typeof(string));
                table.Columns.Add("Size", typeof(string));


                for (int indxeNumber = 0; indxeNumber < brand.getMenListLength(); indxeNumber++)
                {
                    ClothDetail cloth = brand.get_MenListObject(indxeNumber);
                    table.Rows.Add(cloth.getName(),cloth.getColor(),cloth.getPrice(),cloth.getSize());

                }

            
            MenclothGrid.DataSource = null;
            MenclothGrid.DataSource = table;
            MenclothGrid.Refresh();
        }

        private void BabyGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void setBabyDetail()
        {
            BabyGrid.Visible = true;
            BrandGrid.Visible = false;
            MenclothGrid.Visible = false;
            womenGrid.Visible = false;
            WomenClothLbl.Visible = false;
            babylbl.Visible = true;
            MenClothLbl.Visible = false;
            viewBtnPLn.Visible = false;
            menNextPic.Visible = false;
            babyNextPic.Visible = false;
            backtoBrand.Visible =false;
            backtoMen.Visible = true;
            backtoWomenpic.Visible = false;
            backToHeadPIc.Visible = false;

        }
        private void babyNextPic_Click(object sender, EventArgs e)
        {

            
                setBabyDetail();
                DataTable table = new DataTable();
                BrandDetail brand =brandFromGrid;
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Color", typeof(string));
                table.Columns.Add("Price", typeof(string));
                table.Columns.Add("Size", typeof(string));


                for (int indxeNumber = 0; indxeNumber < brand.getBabyListLength(); indxeNumber++)
                {
                    ClothDetail cloth = brand.get_BabyListObject(indxeNumber);
                    table.Rows.Add(cloth.getName(), cloth.getColor(), cloth.getPrice(), cloth.getSize());

            }
            BabyGrid.DataSource = null;
            BabyGrid.DataSource = table;
            BabyGrid.Refresh();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            setWomenDetail();
        }

        private void backToHeadPIc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form hedFrn = new HeadBoyFrm();
            hedFrn.ShowDialog();
        }

        private void backtoBrand_Click(object sender, EventArgs e)
        {
            setBrandDetail();
        }

        private void backtoMen_Click(object sender, EventArgs e)
        {
            setMenDetail();
           
        }

        private void Backtocustomer_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerFrm cuf = new CustomerFrm();
            cuf.ShowDialog();
        }
    }
}
