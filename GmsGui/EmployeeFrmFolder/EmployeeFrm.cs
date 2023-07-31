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
using  GmsGui.EmployeeFrmFolder;

namespace GmsGui
{
    public partial class EmployeeFrm : Form
    {
        //Form inObjFrm = new InputFrm();
       
        public EmployeeFrm()
        {
            InitializeComponent();
           
        }
        bool leBrMenuExpand = false;
        private void NavBarTransition_Tick(object sender, EventArgs e)
        {
            if (leBrMenuExpand == false)
            {
               menuPln.Height += 10;
                if (menuPln.Height >= 339)
                {
                    NavBarTransition.Stop();
                    leBrMenuExpand = true;
                }
            }
            else
            {
                menuPln.Height -= 10;
                if (menuPln.Height == 0)
                {
                   NavBarTransition.Stop();
                    leBrMenuExpand = false;
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            NavBarTransition.Start();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form lgfrm = new loginFrm();
            lgfrm.ShowDialog();
        }

        private void ViewCusBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CusDeatilFrm cuf = new CusDeatilFrm();
            cuf.ShowDialog();
        }

        private void ChanPassBtn_Click(object sender, EventArgs e)
        {
            Form infrm = new InputFrm();
           
         //   inpfrm.setDetails();
            infrm.ShowDialog();
           
          
            string oldPassword = InputFrm.brandName;
            if (oldPassword == EmployeeDetailCrud.curentEmployee.getPassword())
            {
               
                
                EmployeeDetailCrud.curentEmployee.setPassword(InputFrm.ClothName);
                MessageBox.Show("PASSWORD UPDATED", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("WRONG INPUT", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewFeedbackBtn_Click(object sender, EventArgs e)
        {
            
            EmployeeDetailCrud.showCloth();
        }

        private void ViewTotalSaleBtn_Click(object sender, EventArgs e)
        {
           EmployeeDetailCrud.showDetailOfSale_productBrand();
           Form clthfrm = new ClothFrm();
           clthfrm.ShowDialog();

        }

        private void ProduuQuanBtn_Click(object sender, EventArgs e)
        {
          
          //  inpfrm.setInputBoxes('B');         
           // inObjFrm.ShowDialog();
            BrandDetail Brand_for_productQuantity = BrandDetailCrud.getBrandObject_byInput();
            
         
            if (Brand_for_productQuantity != null)
            {
                setClothList(Brand_for_productQuantity);
                Form shcloth = new ClothFrm();
                shcloth.ShowDialog();
            }
            else
            {
                MessageBox.Show("WRONG INPUT", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
               
        }
       public void setClothList(BrandDetail Brand_for_productQuantity)
        {
            foreach (ClothDetail cloth in Brand_for_productQuantity.getMenList())
            {
                BrandDetailCrud.clothDetailGrid.Add(cloth);
            }
            foreach (ClothDetail cloth in Brand_for_productQuantity.getWomenList())
            {
                BrandDetailCrud.clothDetailGrid.Add(cloth);
            }
            foreach (ClothDetail cloth in Brand_for_productQuantity.getBabyList())
            {
                BrandDetailCrud.clothDetailGrid.Add(cloth);
            }

        }

        private void EmployeeFrm_Load(object sender, EventArgs e)
        {
            EmployeeNamelbl.Text = "WELCOME TO"+"\n"+ EmployeeDetailCrud.curentEmployee.getName().ToUpper();
        }
    }
}
