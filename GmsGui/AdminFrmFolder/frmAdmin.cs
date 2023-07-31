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
using GmsGui.AdminFrmFolder;
namespace GmsGui
{
    public partial class frmAdmin : Form
    {
        public static string totalIncome;
        public char menuStatus='N';
        public char addBrandStatus = 'N';
        

        
        public frmAdmin()
        {
            InitializeComponent();
          
        }

        bool BrandMenuExpand=false;

        public string getIncome()
        {
            return totalIncome;
        }
        private void BrandMenuTransisation_Tick(object sender, EventArgs e)
        {
            if (BrandMenuExpand == false)
            {
                brandpln.Height += 10;
                if (brandpln.Height >= 153)
                {
                    BrandMenuExpand = true;
                    BrandMenuTransisation.Stop();
                }
            }
            else
            {
                brandpln.Height -= 10;
                if (brandpln.Height <= 53)
                {
                    BrandMenuExpand = false;
                    BrandMenuTransisation.Stop();
                }

            }
            
        }

        private void brandMenuPng_Click(object sender, EventArgs e)
        {
            BrandMenuTransisation.Start();
            setBrandDetail();
            setBrandGrid();
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
        public void setBrandDetail()
        {
            headboyGrid.Visible = false;
            BrandDeatilPln.Visible = true;
            brandLbl.Visible = true;
            CustomerFeedbackPln.Visible = false;
         
        }
        public void setBrand()
        {

        }
        bool SaleMenuExpand = false;
        private void SaleTransistionTimer_Tick(object sender, EventArgs e)
        {
            if (SaleMenuExpand == false)
            {
                SalePLn.Height += 10;
                if (SalePLn.Height >= 153)
                {
                    SaleMenuExpand = true;
                    SaleTransistionTimer.Stop();
                }
            }
            else
            {
                SalePLn.Height -= 10;
                if (SalePLn.Height <= 53)
                {
                    SaleMenuExpand = false;
                    SaleTransistionTimer.Stop();
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaleTransistionTimer.Start();
            setBrandDetail();
            setBrandGrid();
            set_DetailForAddBrand();
            brandNameLbl.Text = "ENTER SALE PER.";
          
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HeadBoyMenuTran.Start();
            setHeadBoyGrid();
            BrandDeatilPln.Visible = false;
            headboyGrid.Visible = true;
            CustomerFeedbackPln.Visible = false;   
        }
        public void setHeadBoyGrid()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Password", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("Education", typeof(string));
            table.Columns.Add("Salary", typeof(string));
            table.Columns.Add("Cinc", typeof(string));
            foreach (PersonDetail person in PersonDetailCrud.getPersonList())
            {
                if (person.getRole().ToLower() == "headboy")
                {
                    HeadBoyDetail headboy = (HeadBoyDetail)person;
                    if (headboy.Status != 'Y')
                    {
                        table.Rows.Add(headboy.getName(), headboy.getPassword(), headboy.Address, headboy.Education, headboy.Salary1, headboy.Cinc1);
                    }
                }

            }
            headboyGrid.DataSource = null;
            headboyGrid.DataSource = table;
            headboyGrid.Refresh();
        }
        bool HeadBoyMenuExpand = false;
        private void HeadBoyMenuTran_Tick(object sender, EventArgs e)
        {
            if (HeadBoyMenuExpand == false)
            {
                headboyPln.Height += 10;
                if (headboyPln.Height >= 153)
                {
                    HeadBoyMenuExpand = true;
                    HeadBoyMenuTran.Stop();
                }
            }
            else
            {
                headboyPln.Height -= 10;
                if (headboyPln.Height <= 53)
                {
                    HeadBoyMenuExpand = false;
                    HeadBoyMenuTran.Stop();
                }

            }
        }
        bool cusMenuExpand = false;

        private void cusMenuTransistion_Tick(object sender, EventArgs e)
        {
            if(cusMenuExpand==false)
            {
                customerpln.Height += 10;
                if(customerpln.Height>=155)
                {
                    cusMenuTransistion.Stop();
                    cusMenuExpand = true;
                }
            }
            else
            {
                customerpln.Height -= 10;
                if(customerpln.Height==55)
                {
                    cusMenuTransistion.Stop();
                    cusMenuExpand = false;
                }
            }
        }

        private void customerMenuBtn_Click(object sender, EventArgs e)
        {
            cusMenuTransistion.Start();
        //    setFeedback();
        }
        public void setFeedback()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Cloth Name",typeof(string));
            table.Columns.Add("Customer Name",typeof(string));
            table.Columns.Add("Customer Feedback",typeof(string));
            foreach (CustomerFeedbackDetail cus in CustomerFeedbackCrud.get_customerFeedbackList())
            {
                table.Rows.Add($"{cus.Cloth.getName()},{cus.Customer},{cus.FeedBack}");

            }
            CustomerFeedbackGrid.DataSource = null;
            CustomerFeedbackGrid.DataSource = table;
            CustomerFeedbackGrid.Refresh();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            navTransisation.Start();
        }
        bool navMenuExpand = false;

        private void navTransisation_Tick(object sender, EventArgs e)
        {
            if (navMenuExpand == false)
            {
                sidebarpln.Width += 10;
                if (sidebarpln.Width >= 196)
                {
                    navTransisation.Stop();
                    navMenuExpand = true;
                }
            }
            else
            {

                sidebarpln.Width -= 10;
                if (sidebarpln.Width <= 55)
                {
                    navTransisation.Stop();
                    navMenuExpand = false;
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form logfrm = new loginFrm();
            logfrm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form redlistcus = new RedListCustomerFrm();
            this.Hide();
            redlistcus.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string BrandNameFor_Sale = "";
            if (BrandGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = BrandGrid.SelectedRows[0].Index;
                DataGridViewRow selectedRow = BrandGrid.SelectedRows[0];
                BrandNameFor_Sale = selectedRow.Cells["Name"].Value.ToString();
            }

            BrandDetail brandForSale = BrandDetailCrud.getBrand_object(BrandNameFor_Sale);
            if ((brandForSale != null))
            {

                if ((brandForSale.getBabyListLength() != 0) && (brandForSale.getMenListLength() != 0) && (brandForSale.getWoMenListLength() != 0)&&brandLbl.Text!="")
                {
                    double Sale_percentage =Convert.ToDouble(brandNametxt.Text);
                    brandForSale.setSalePercentage(Sale_percentage);
                    BrandDetailCrud.setDicountedPrice_forMen(brandForSale, 'N');
                    BrandDetailCrud.setDicountedPrice_forWomen(brandForSale, 'N');
                    BrandDetailCrud.setDicountedPrice_forBaby(brandForSale, 'N');
                    MessageBox.Show("SALE IS APPLIED", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    brandNametxt.Text = "";
                }
                else
                {
                MessageBox.Show("LIST IS EMPTY", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            else
            {
                MessageBox.Show("WRONG INPUT", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            set_DetailForRemoveBrand();
            string BrandNameFor_remove="";
            if (BrandGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = BrandGrid.SelectedRows[0].Index;
                DataGridViewRow selectedRow = BrandGrid.SelectedRows[0];
                BrandNameFor_remove = selectedRow.Cells["Name"].Value.ToString();
               

            }
            BrandDetail removeSaleFromBrand = BrandDetailCrud.get_object_ofBrand(BrandNameFor_remove);
            if (removeSaleFromBrand != null)
            {
                BrandDetailCrud.setDicountedPrice_forMen(removeSaleFromBrand, 'Y');
                BrandDetailCrud.setDicountedPrice_forWomen(removeSaleFromBrand, 'Y');
                BrandDetailCrud.setDicountedPrice_forBaby(removeSaleFromBrand, 'Y');
            }
            else
            {
                MessageBox.Show("BRAND NOT FOUND","w",MessageBoxButtons.OK);
            }

        }

        private void AddBrandBtn_Click(object sender, EventArgs e)
        {
            set_DetailForAddBrand();
            brandNameLbl.Text = "ENTER BRAND NAME";
            if (addBrandStatus != 'N')
            {
                string Brand_Name = brandNametxt.Text;
                table.Rows.Add(Brand_Name);
                BrandDetail brand = new BrandDetail();
                brand.setBrandName(Brand_Name);
                BrandDetailCrud.addBrand_Object_In_list(brand);
                brandNametxt.Text = "";
            }
            else
            {
                addBrandStatus = 'Y';
            }
        }
        public void set_DetailForAddBrand()
        {
            
            int newLocationX = 277; 
            int newLocationY = 50;
            BrandGrid.Location = new Point(newLocationX, newLocationY);
            brandNameLbl.Visible = true;
            brandNametxt.Visible = true;
        }
        public void set_DetailForRemoveBrand()
        {
            int newLocationX = 142;
            int newLocationY = 55;
            BrandGrid.Location = new Point(newLocationX,newLocationY);
            brandNameLbl.Visible = false;
            brandNametxt.Visible = false;
        }
        private void RemoveBrandbtn_Click(object sender, EventArgs e)
        {
            addBrandStatus = 'N';
            set_DetailForRemoveBrand();
            string BrandNameFor_remove = "";
            if (BrandGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = BrandGrid.SelectedRows[0].Index;
                DataGridViewRow selectedRow = BrandGrid.SelectedRows[0];
                BrandNameFor_remove = selectedRow.Cells["Name"].Value.ToString();
                BrandGrid.Rows.RemoveAt(selectedIndex);

            }
            BrandDetail RemoveBrand = BrandDetailCrud.getBrand_object(BrandNameFor_remove);
            if (RemoveBrand != null)
            {
                BrandDetailCrud.remove_Object(RemoveBrand);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin frad = new frmAdmin();
            totalIncome =Convert.ToString(OwnerCrud.getOwner().getTotalBudget());
            Form infrm = new IncomeFrm(frad);
            infrm.ShowDialog();
               
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Remove_headBoyName="";
            if (headboyGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = headboyGrid.SelectedRows[0].Index;
                DataGridViewRow selectedRow = headboyGrid.SelectedRows[0];
                Remove_headBoyName = selectedRow.Cells["Name"].Value.ToString();
                headboyGrid.Rows.RemoveAt(selectedIndex);

            }
      
          
            PersonDetail removeHeadBoy = HeadBoyDetailCrud.getObject_byName(Remove_headBoyName, "headboy");
         
            if (removeHeadBoy != null)
            {
   
                PersonDetailCrud.removePerson(removeHeadBoy);
                HeadBoyDetailCrud.IsHeadBoyExist = 'N';
            }
            else
            {
               
              MessageBox.Show("WRONG INPUT", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Add_headBoyName="";
            if (HeadBoyDetailCrud.IsHeadBoyExist != 'Y')
            {
                if (headboyGrid.SelectedRows.Count > 0)
                {
                    int seletedRow = headboyGrid.SelectedRows[0].Index;
                    DataGridViewRow selectedrow = headboyGrid.SelectedRows[0];
                    Add_headBoyName = selectedrow.Cells["Name"].Value.ToString();
                    headboyGrid.Rows.RemoveAt(seletedRow);
                
                
                }


              
                HeadBoyDetail Add_HeadBoy = (HeadBoyDetail)HeadBoyDetailCrud.getObject_byName(Add_headBoyName, "headboy");
                if (Add_HeadBoy != null)
                {
                    Add_HeadBoy.Status = 'Y';
                }
                else
                {

                    MessageBox.Show("WRONG INPUT", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                    MessageBox.Show("HEAD BOY ALREADY EXIST", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
        }

        private void custfeedbackBtn_Click(object sender, EventArgs e)
        {
            setFeedback();
            brandLbl.Visible = false;   
            CustomerFeedbackPln.Visible = true;
        

        }

        private void sidebarpln_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
