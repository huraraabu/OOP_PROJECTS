using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GmsGui.ViewFormFolder;
using Garments_Management_System.Business_Layer;
using Garments_Management_System.Data_Layer;
using GmsGui.Inputform;
using GmsGui.customerFrmFolder;
using GmsGui.Data_Layer;

namespace GmsGui.customerFrmFolder
{
    public partial class ProductFrm : Form
    {
        ViewBrandFrm frm = new ViewBrandFrm();
        public char menuStatus = 'N';
        BrandDetail brandFromGrid;
        public ProductFrm()
        {
            InitializeComponent();
        }

        private void ProductMenuBtn_Click(object sender, EventArgs e)
        {
            ProMenuTransistion.Start();
            setBrand();
            setBrandGrid();

        }
        public void setBrand()
        {
            BrandGrid.Visible = true;
            backTocustomer.Visible = true;
            BabyGrid.Visible = false;
            AddtoCrdLbl.Visible = false;
            AddtoCardGrid.Visible = false;
            MenGrid.Visible = false;
            womenGrid.Visible = false;
            WomenClothLbl.Visible = false;
            babylbl.Visible = false;
            MenClothlbl.Visible = false;
            backtoMen.Visible = false;
            BacktoWomen.Visible = false;
            backtoBrand.Visible = false;

            BabyNextBtn.Visible = false;
            MenNextPic.Visible = false;
            brandLbl.Visible = true;
            viewBtnPLn.Visible = true;
            RemoveBrandbtn.Visible = true;
        }
        DataTable table = new DataTable();
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


        bool proMenuExpand = false;
        private void ProMenuTransistion_Tick(object sender, EventArgs e)
        {
            if (proMenuExpand == false)
            {
                productpln.Height += 10;
                if (productpln.Height >= 300)
                {
                    ProMenuTransistion.Stop();
                    proMenuExpand = true;
                }
            }
            else
            {
                productpln.Height -= 10;
                if (productpln.Height == 50)
                {
                    ProMenuTransistion.Stop();
                    proMenuExpand = false;
                }
            }
        }

        private void AddtocardBtn_Click(object sender, EventArgs e)
        {

            BrandDetail AddToCard_brand;
          
            AddToCard_brand = getBrandobj_FromSelectedRow_OfGrid();

            if (AddToCard_brand != null)
            {




                ClothDetail Addto_CardBabyCloth = getBabyClothobj_FromSelectedRow_OfGrid();
                ClothDetail AddtoCardMenCloth = getMenClothobj_FromSelectedRow_OfGrid();
                ClothDetail AddtoCardWomenCloth = getwomenClothobj_FromSelectedRow_OfGrid();
                if (Addto_CardBabyCloth != null)
                {
                    CustomerDetailCrud.CurrentCustomer.set_AddTocardProduct(Addto_CardBabyCloth.getName());
                    MessageBox.Show("PRODUCT IS ADDED","information",MessageBoxButtons.OK);
                }
                else if (AddtoCardMenCloth != null)
                {
                    CustomerDetailCrud.CurrentCustomer.set_AddTocardProduct(AddtoCardMenCloth.getName());
                    MessageBox.Show("PRODUCT IS ADDED", "information", MessageBoxButtons.OK);
                }
                else if (AddtoCardWomenCloth != null)
                {
                    CustomerDetailCrud.CurrentCustomer.set_AddTocardProduct(AddtoCardWomenCloth.getName());
                    MessageBox.Show("PRODUCT IS ADDED", "information", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Select the cloth", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }





            }
            else
            {
                MessageBox.Show("PLEASE FIRST SELECT BRAND", "warning", MessageBoxButtons.OK);
            }

        }

        private void BabyPln_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RemoveBrandbtn_Click(object sender, EventArgs e)
        {

            setWomenGridDetail();
            setWomenDetail();

        }
        public void setWomenDetail()
        {
            AddtoCrdLbl.Visible = false;
            AddtoCardGrid.Visible = false;
            BrandGrid.Visible = false;
            BabyGrid.Visible = false;
            MenGrid.Visible = false;
            womenGrid.Visible = true;
            WomenClothLbl.Visible = true;
            babylbl.Visible = false;
            MenClothlbl.Visible = false;
            backtoMen.Visible = false;
            BacktoWomen.Visible = false;
            backtoBrand.Visible = true;
            backTocustomer.Visible = false;
            BabyNextBtn.Visible = false;
            MenNextPic.Visible = true;
            brandLbl.Visible = false;
            viewBtnPLn.Visible = false;
            RemoveBrandbtn.Visible = false;
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
            brandFromGrid = RemoveBrand;
            return RemoveBrand;

        }
        public ClothDetail getMenClothobj_FromSelectedRow_OfGrid()
        {
            string clothName = "";
            if (MenGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = MenGrid.SelectedRows[0].Index;
                DataGridViewRow selectedRow = MenGrid.SelectedRows[0];
                clothName = selectedRow.Cells["Name"].Value.ToString();


            }
            ClothDetail cloth = (BrandDetailCrud.get_Object_of_cloth_by_itsName(clothName, brandFromGrid));

            return cloth;

        }
        public string getAddtocard_Clothobj_FromSelectedRow_OfGrid()
        {
            string clothName = "";
            if (AddtoCardGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = AddtoCardGrid.SelectedRows[0].Index;
                DataGridViewRow selectedRow = AddtoCardGrid.SelectedRows[0];
                clothName = selectedRow.Cells["Name"].Value.ToString();


            }


            return clothName;

        }
        public ClothDetail getwomenClothobj_FromSelectedRow_OfGrid()
        {
            string clothName = "";
            if (womenGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = womenGrid.SelectedRows[0].Index;
                DataGridViewRow selectedRow = womenGrid.SelectedRows[0];
                clothName = selectedRow.Cells["Name"].Value.ToString();


            }
            ClothDetail cloth = (BrandDetailCrud.get_Object_of_cloth_by_itsName(clothName, brandFromGrid));

            return cloth;

        }
        public ClothDetail getBabyClothobj_FromSelectedRow_OfGrid()
        {
            string clothName = "";
            if (BabyGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = BabyGrid.SelectedRows[0].Index;
                DataGridViewRow selectedRow = BabyGrid.SelectedRows[0];
                clothName = selectedRow.Cells["Name"].Value.ToString();


            }
            ClothDetail cloth = (BrandDetailCrud.get_Object_of_cloth_by_itsName(clothName, brandFromGrid));

            return cloth;

        }
        public void setWomenGridDetail()
        {
            DataTable table = new DataTable();
            BrandDetail brand = getBrandobj_FromSelectedRow_OfGrid();
            if (brand != null)
            {

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
                MessageBox.Show("FIRST SELECT BRAND", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            womenGrid.DataSource = null;
            womenGrid.DataSource = table;
            womenGrid.Refresh();
        }

        private void Menpln_Paint(object sender, PaintEventArgs e)
        {

        }
        public void setMenDetail()
        {
            AddtoCrdLbl.Visible = false;
            AddtoCardGrid.Visible = false;
            BabyGrid.Visible = false;
            BrandGrid.Visible = false;
            MenGrid.Visible = true;
            womenGrid.Visible = false;
            WomenClothLbl.Visible = false;
            babylbl.Visible = false;
            MenClothlbl.Visible = true;
            backtoMen.Visible = false;
            BacktoWomen.Visible = true;
            backtoBrand.Visible = false;
            backTocustomer.Visible = false;
            BabyNextBtn.Visible = true;
            MenNextPic.Visible = false;
            brandLbl.Visible = false;
            viewBtnPLn.Visible = false;
            RemoveBrandbtn.Visible = false;
        }
        private void womenNextPic_Click(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            BrandDetail brand = brandFromGrid;

            if (brand != null)
            {

                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Color", typeof(string));
                table.Columns.Add("Price", typeof(string));
                table.Columns.Add("Size", typeof(string));


                for (int indxeNumber = 0; indxeNumber < brand.getMenListLength(); indxeNumber++)
                {
                    ClothDetail cloth = brand.get_MenListObject(indxeNumber);
                    table.Rows.Add(cloth.getName(), cloth.getColor(), cloth.getPrice(), cloth.getSize());

                }

            }
            else
            {
                MessageBox.Show("PLEASE FIRST SELECT BRAND", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MenGrid.DataSource = null;
            MenGrid.DataSource = table;
            MenGrid.Refresh();
            setMenDetail();
        }

        private void backtoMen_Click(object sender, EventArgs e)
        {
            setMenDetail();
        }

        private void MenNextBtn_Click(object sender, EventArgs e)
        {
            setBabyDetail();
            DataTable table = new DataTable();
            BrandDetail brand = brandFromGrid;
            if (brand != null)
            {
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Color", typeof(string));
                table.Columns.Add("Price", typeof(string));
                table.Columns.Add("Size", typeof(string));


                for (int indxeNumber = 0; indxeNumber < brand.getBabyListLength(); indxeNumber++)
                {
                    ClothDetail cloth = brand.get_BabyListObject(indxeNumber);
                    table.Rows.Add(cloth.getName(), cloth.getColor(), cloth.getPrice(), cloth.getSize());

                }
            }
            else
            {
                MessageBox.Show("FIRST SELECT BRAND", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            BabyGrid.DataSource = null;
            BabyGrid.DataSource = table;
            BabyGrid.Refresh();
        }
        public void setBabyDetail()
        {
            AddtoCrdLbl.Visible = false;
            AddtoCardGrid.Visible = false;
            BrandGrid.Visible = false;
            BabyGrid.Visible = true;
            MenGrid.Visible = false;
            womenGrid.Visible = false;
            WomenClothLbl.Visible = false;
            babylbl.Visible = true;
            MenClothlbl.Visible = false;
            backtoMen.Visible = true;
            BacktoWomen.Visible = false;
            backtoBrand.Visible = false;
            backTocustomer.Visible = false;
            BabyNextBtn.Visible = false;
            MenNextPic.Visible = false;
            brandLbl.Visible = false;
            viewBtnPLn.Visible = false;
            RemoveBrandbtn.Visible = false;
        }

        private void ProductFrm_Load(object sender, EventArgs e)
        {
            setBrand();
            setBrandGrid();
        }

        private void backtoBrand_Click(object sender, EventArgs e)
        {
            setBrand();

        }

        private void backToMenbtn_Click(object sender, EventArgs e)
        {
            setWomenDetail();

        }

        private void BacktoWomen_Click(object sender, EventArgs e)
        {
            setWomenDetail();
        }

        private void backTocustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerFrm f = new CustomerFrm();
            f.ShowDialog();

        }

        private void ShowAddtocardBtn_Click(object sender, EventArgs e)
        {
            setaddtocard();
            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));

            CustomerDetail cus = CustomerDetailCrud.CurrentCustomer;
            for (int a = 0; a < cus.get_LengthOfAddToCardList(); a++)
            {
                table.Rows.Add($"{cus.get_AddTocardProduct(a)}");
            }
            AddtoCardGrid.DataSource = null;
            AddtoCardGrid.DataSource = table;
            AddtoCardGrid.Refresh();
        }
        public void setaddtocard()
        {
            backTocustomer.Visible = false;
            BabyGrid.Visible = false;
            BrandGrid.Visible = false;
            MenGrid.Visible = false;
            womenGrid.Visible = false;
            WomenClothLbl.Visible = false;
            babylbl.Visible = false;
            MenClothlbl.Visible = false;
            backtoMen.Visible = false;
            BacktoWomen.Visible = false;
            backtoBrand.Visible = false;
            AddtoCardGrid.Visible = true;
            AddtoCrdLbl.Visible = true;
            BabyNextBtn.Visible = false;
            MenNextPic.Visible = false;
            brandLbl.Visible = false;
            viewBtnPLn.Visible = false;
            RemoveBrandbtn.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (CustomerDetailCrud.CurrentCustomer.CardBalance1 != 0)
            {


                setBrand();
                brandFromGrid = getBrandobj_FromSelectedRow_OfGrid();

                if (brandFromGrid != null)
                {
                    setaddtocard();
                    string buyCloth = getAddtocard_Clothobj_FromSelectedRow_OfGrid();
                    ClothDetail Buycloth = BrandDetailCrud.get_Object_of_cloth_by_itsName(buyCloth, brandFromGrid);
                    if (Buycloth != null)
                    {

                        if (Buycloth.Number_OfStockAvailable1 != 0)
                        {
                            
                            CustomerDetailCrud.CurrentCustomer.remove_AddToCardProduct(buyCloth);

                            BrandDetailCrud.set_totalBudget(CustomerDetailCrud.CurrentCustomer, Buycloth);
                            Buycloth.Number_OfStockAvailable1--;
                            Buycloth.Number_OfStockSale1++;
                            brandFromGrid.set_SALEProduct(Buycloth);
                            int cardBalance = CustomerDetailCrud.CurrentCustomer.CardBalance1;
                            cardBalance = cardBalance - Convert.ToInt32(Buycloth.getPrice());
                            CustomerDetailCrud.CurrentCustomer.CardBalance1 = cardBalance;
                            CustomerDetailCrud.CurrentCustomer.add_clothIn_PurchasingLIsts(Buycloth);
                            
                            MessageBox.Show(Buycloth.getPrice()+"AMOUNT DEDUCTED FROM YOUR CARD", "unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else
                        {
                            MessageBox.Show("STOCK IS NOT AVAILABLE", "unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {

                        MessageBox.Show("CLOTH NOT EXIST", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("EMPTY ERROR", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {

                MessageBox.Show("PLEASE RECHARGE YOUR BALANCE", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



        }

        private void PurchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PurchasinFrm frm = new PurchasinFrm();
            frm.setfalse();
            frm.ShowDialog();   
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PurchasinFrm purfrm = new PurchasinFrm();
            purfrm.settrue();
            purfrm.ShowDialog();
        
        }
    }
}
