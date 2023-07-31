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

namespace GmsGui
{
    public partial class CustomerFrm : Form
    {
       
        public static BrandDetail AddToCard_brand = new BrandDetail();

        public CustomerFrm()
        {
            InitializeComponent();
          
        }

      
        private void ProMenuTransistion_Tick(object sender, EventArgs e)
        {
            
        }
        private void ProductMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductFrm purfrm = new ProductFrm();
            purfrm.ShowDialog();
           
        }
              

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Balancefrm bfrm = new Balancefrm();
            bfrm.ShowDialog();
                
        }
        bool braMenuExpand = false;
        private void BrandTranssition_Tick(object sender, EventArgs e)
        {
            if (braMenuExpand == false)
            {
                brandpln.Height += 10;
                if (brandpln.Height >= 100)
                {
                    BrandTranssition.Stop();
                    braMenuExpand = true;
                }
            }
            else
            {
                brandpln.Height -= 10;
                if (brandpln.Height == 55)
                {
                    BrandTranssition.Stop();
                    braMenuExpand = false;
                }
            }
        }

        private void brandMenuPng_Click(object sender, EventArgs e)
        {
            BrandTranssition.Start();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form lofrm = new loginFrm();
            lofrm.ShowDialog();
        }
        bool leBrMenuExpand = false;
        private void leftBarTimer_Tick(object sender, EventArgs e)
        {
            if (leBrMenuExpand == false)
            {
                Leftbarpln.Height += 10;
                if (Leftbarpln.Height >= 357)
                {
                    leftBarTimer.Stop();
                    leBrMenuExpand = true;
                }
            }
            else
            {
                Leftbarpln.Height -= 10;
                if (Leftbarpln.Height == 0)
                {
                    leftBarTimer.Stop();
                    leBrMenuExpand = false;
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            leftBarTimer.Start();
            rightBrTimer.Start();
        }
        bool riBrMenuExpand = false;
        private void rightBrTimer_Tick(object sender, EventArgs e)
        {
            if (riBrMenuExpand == false)
            {
                RightBrPLn.Height += 10;
                if (RightBrPLn.Height >= 357)
                {
                    rightBrTimer.Stop();
                    riBrMenuExpand = true;
                }
            }
            else
            {
                RightBrPLn.Height -= 10;
                if (RightBrPLn.Height == 0)
                {
                    rightBrTimer.Stop();
                    riBrMenuExpand = false;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {


        }



        private void button5_Click(object sender, EventArgs e)
        {
            
                



        }

        private void PurchBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form brn = new viewBrand();
            brn.ShowDialog();
        }

        private void BalnceRechBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new viewBrand();
            frm.ShowDialog();
            
        }

        
        public static int loadBalance()
        {
        addBalance:


            string balance="";
            if (PersonDetailCrud.checkIntegerEntity(balance) == false)
            {
                InputFrm.instance.NuOfClthLbl.Visible = true;
                goto addBalance;
            }

            return (Convert.ToInt32(balance));



        }

        

        private void ViewBrandBtn_Click(object sender, EventArgs e)
        {
            Form brandFrm = new ViewBrandFrm();
            brandFrm.ShowDialog();


        }

        private void RemoveBrandbtn_Click(object sender, EventArgs e)
        {
            BrandDetail BrandObject = BrandDetailCrud.get_object();
            if (BrandObject != null)
            {
                // Form ShowAllCloth = new ViewPortalFrm();
                AddToCard_brand = BrandObject;
                // ShowAllCloth.ShowDialog();
            }
            else
            {
                MessageBox.Show("WRONG INPUT", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PurchasinFrm pfrm = new PurchasinFrm();
            pfrm.setFeedbackFrm();
            pfrm.ShowDialog();
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void RemCusBtn_Click(object sender, EventArgs e)
        {
         
        }

        private void Leftbarpln_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerFrm_Load(object sender, EventArgs e)
        { 
          string name = "WELCOME " +"\n" +CustomerDetailCrud.CurrentCustomer.getName().ToUpper();
          customerNamelbl.Text = name;
        }

        private void RightBrPLn_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}
