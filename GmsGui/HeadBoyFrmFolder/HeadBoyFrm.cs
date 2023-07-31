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
using GmsGui.HeadBoyFrmFolder;
namespace GmsGui
{
    public partial class HeadBoyFrm : Form
    {
        public static BrandDetail clothBrand = new BrandDetail();
    
        public HeadBoyFrm()
        {
            InitializeComponent();
      
        }
        
       
        private void ProMenuTransistion_Tick(object sender, EventArgs e)
        {
        }
       

        private void button6_Click(object sender, EventArgs e)
        {
            ProductTransisition.Start();
        }
        bool brMenuExpand = false;
        private void brandProPng_Tick(object sender, EventArgs e)
        {
            if (brMenuExpand == false)
            {
               brandpln.Height += 10;
                if (brandpln.Height >= 100)
                {
                    brandTransistion.Stop();
                    brMenuExpand = true;
                }
            }
            else
            {
                brandpln.Height -= 8;
                if (brandpln.Height ==56)
                {
                    brandTransistion.Stop();
                    brMenuExpand = false;
                }
            }
        }

        private void brandMenuPng_Click(object sender, EventArgs e)
        {
            brandTransistion.Start();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form lofrm = new loginFrm();
            lofrm.ShowDialog();
        }

        private void ProductMenuBtn_Click(object sender, EventArgs e)
        {





               this.Hide();
            AddproductFrm pf = new AddproductFrm();
               pf.ShowDialog();

                
            
          
            
        }

        private void NavBarTransition_Tick(object sender, EventArgs e)
        {

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rightBrTimer.Start();
            leftBarTimer.Start();
        }

        private void _Click(object sender, EventArgs e)
        {
            Form clothFrm = new ClothDetailFrm();
            clothFrm.ShowDialog();
            ClothDetail clothMen = clothBrand.getMenCloth_object();
            clothMen = ClothDetailFrm.currentCloth;
            clothBrand.set_MenClothObject(clothMen);
            

        }

        private void RemCusBt_Click(object sender, EventArgs e)
        {
            Form clothFrm = new ClothDetailFrm();
            clothFrm.ShowDialog();
            ClothDetail clothMen = clothBrand.getWoMenCloth_object();
            clothMen = ClothDetailFrm.currentCloth;
            clothBrand.set_WoMenClothObject(clothMen);
        }

        private void PurchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form purfrm = new PurchasinFrm();
            purfrm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form inpfrm = new InputFrm();
            
          //  formInput.setInputBoxes('B');
            inpfrm.ShowDialog();
          //  Form viewAllcloth = new ViewPortalFrm();
            BrandDetail previouBrand = new BrandDetail();
            BrandDetail BrandObject = BrandDetailCrud.get_object();
            previouBrand = CustomerFrm.AddToCard_brand;
            CustomerFrm.AddToCard_brand = BrandObject;
          //  viewAllcloth.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           MessageBox.Show($"YOUR TOATL SALRY IS:{HeadBoyDetailCrud.Current_headBoy1.Salary1})","warning",MessageBoxButtons.OK);
        }
      

        private void balnceReBtn_Click(object sender, EventArgs e)
        {
           // formInput.setDetails();
            ClothDetail cloth = BrandDetailCrud.get_cloth_object_byInput();
          //  HeadBoyDetailCrud.setPrice(cloth);
        }

        private void ViewBrandBtn_Click(object sender, EventArgs e)
        {
            Form BrandFrm = new ViewBrandFrm();
            BrandFrm.ShowDialog();
        }

        private void RemoveBrandbtn_Click(object sender, EventArgs e)
        {
          //  formInput.setInputBoxes('B');
            BrandDetail BrandObject = BrandDetailCrud.get_object();
            //Form viPorFrm = new ViewPortalFrm();
          //  viPorFrm.ShowDialog();
        }

        

        private void BabyBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void MenBtn_Click(object sender, EventArgs e)
        {
        
        }

        private void WomenBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void HeadBoyFrm_Load(object sender, EventArgs e)
        {
            HeadBoyNamelbl.Text = "WELCOME TO"+"\n"+HeadBoyDetailCrud.Current_headBoy1.getName().ToUpper();
        }

        private void customerDetailBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form purfrm = new customerDetailFrm();
          //  purfrm.setHeadBoyBack();
            purfrm.ShowDialog();
        }

        private void menuBrpln_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RightBrPLn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif, *.bmp) | *.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Get the selected image file path
                string imagePath = dialog.FileName;
                headboyimg.Image = null;
                // Load the image into the PictureBox
                headboyimg.Image = Image.FromFile(imagePath);


            }
        }

        private void headboyimg_Click(object sender, EventArgs e)
        {

        }

        private void productpln_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
