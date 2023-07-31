using Garments_Management_System.Business_Layer;
using Garments_Management_System.Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GmsGui.Inputform
{
    public partial class InputFrm : Form
    {
        public static InputFrm instance; 
        public static string brandName,ClothName, NumberOfCloth;
        public Label errorLbl,BrandError,ClothError,brndNmeLbl,clhNameLbl,NuOfClthLbl;

        public void setDetails()
        {

           NumOfClothBx.Visible = false;
           NuOfClthLbl.Visible = false;
           clhNameLbl.Text = "ENTER FEEDBACK";
        }
        private void InputFrm_Load(object sender, EventArgs e)
        {
            Form cusfrm = new CustomerFrm();
            Form adfrm = new frmAdmin();
            Form headBoyfrm = new HeadBoyFrm();
        }
        public void setInputBoxes(char lblName)
        {
            if (lblName == 'C')
            {
                clhNameLbl.Text = "Enter Brand Name";
                clhNameLbl.Visible = true;
                clothTxt.Visible = true;
            }
            else if (lblName == 'B')
            {
                BrandNameLbl.Text = "Enter Cloth Name";
                BrandNameLbl.Visible = true;
                brandTxt.Visible = true;

            }
            else if (lblName == 'N')
            {
                NumberOfClthLbl.Text = "Enter Number Of cloth";
                NumberOfClthLbl.Visible = true;
                numberTxt.Visible = true;
            }
            else if (lblName == 'D')
            {
                BrandNameLbl.Text = "Enter Cloth Name";
                BrandNameLbl.Visible = true;
                brandTxt.Visible = true;
                clhNameLbl.Text = "Enter Brand Name";
                clhNameLbl.Visible = true;
                clothTxt.Visible = true;
            }
            else if (lblName == 'F')
            {
                BrandNameLbl.Text = "Enter Your Feedback";
                BrandNameLbl.Visible = true;
                brandTxt.Visible = true;
            }
            else if (lblName == 'P')
            {
                brndNmeLbl.Text = "Enter Old Password";
                clhNameLbl.Text = "Enter New Password";
                clhNameLbl.Visible = true;
                clothTxt.Visible = true;
                BrandNameLbl.Visible = true;
                brandTxt.Visible = true;
            }
            else if (lblName == 'H')
            {
                BrandNameLbl.Text = "Enter HeadBoy Name";
                BrandNameLbl.Visible = true;
                brandTxt.Visible = true;
            }

        }
        
        public TextBox BrandBx, ClothBx, NumOfClothBx;
        

        private void sumbitBtn_Click(object sender, EventArgs e)
        {
            brandName = brandTxt.Text;
            ClothName = clothTxt.Text;
            NumberOfCloth = numberTxt.Text;
            this.Hide();

        }
        

        private void brandTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public void showInvalidBrand()
        {
            BrandinvalidLbl.Visible = true;
        }
        public InputFrm()
        {
            InitializeComponent();
          

            instance = this;
            errorLbl   = invIntegerlbl;
            ClothError = invalidClothLbl;
            BrandError = BrandinvalidLbl;
            BrandBx = brandTxt;
            ClothBx = clothTxt;
            NumOfClothBx = numberTxt;
            brndNmeLbl =BrandNameLbl;
            clhNameLbl = clothNameLbl;
            NuOfClthLbl = NumberOfClthLbl;

        }

    }
}
