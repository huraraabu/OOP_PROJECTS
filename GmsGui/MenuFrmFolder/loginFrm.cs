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
using GmsGui.HeadBoyFrmFolder;
namespace GmsGui
{
    public partial class loginFrm : Form
    {
        private InputFrm infrm;
        public loginFrm()
        {
            InitializeComponent();
         
        }

        
        

        private void userName_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void userName_txt_MouseEnter(object sender, EventArgs e)
        {
            userName_txt.Text = string.Empty;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            PersonDetail person = new PersonDetail();
            PersonDetail signIn = signin();
            person = PersonDetailCrud.CompareDetail(signIn);
            loadData(person);
           
        }
        public void loadData(PersonDetail person)
        {
            if (person != null)
            {
                string personRole = person.returnRole();
                switch (personRole)
                {
                    case "owner":
                     
                        OwnerDetail owner = (OwnerDetail)person;
                        OwnerCrud.setOwner(owner);
                        OwnerCrud.OwnerStatus = 'Y';
                        Form adminFrm = new frmAdmin();
                        adminFrm.ShowDialog();
                        break;
                    case "customer":

                        {
                            CustomerDetailCrud.CurrentCustomer = (CustomerDetail)person;
                            Form cusFrm = new CustomerFrm();
                            cusFrm.ShowDialog();
                        }
                        break;
                    case "headboy":
                        HeadBoyDetailCrud.Current_headBoy1=(HeadBoyDetail)person;
                        HeadBoyDetail currentHead = HeadBoyDetailCrud.Current_headBoy1; 
                        if (currentHead.DetailStatus1 != 'Y')
                        {
                            Form hedetailFrm = new HeadBoyDetailFrm();
                            hedetailFrm.ShowDialog();
                            HeadBoyDetailCrud.addObjectInList(currentHead);
                            HeadBoyDetailCrud.setCurrentHeadboy();
                        }
                        char status = currentHead.Status;

                        if (status == 'Y')
                        {
                            HeadBoyDetailCrud.IsHeadBoyExist = 'Y';
                            HeadBoyDetailCrud.Current_headBoy1 = currentHead;
                            Form headFrm = new HeadBoyFrm();
                            headFrm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("WAIT FOR ADMIN PROVE", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        break;
                        case "employee":
                        {
                            EmployeeDetailCrud.curentEmployee = (EmployeeDetail)person;
                            Form emplFrm = new EmployeeFrm();
                            emplFrm.ShowDialog();
                        }
                        break;
                   
                    default:
                      
                        break;

                }
            }
            else
            {
                INPassLbl.Visible = true;
                invalidUserLbl.Visible = true;
            }


        }









        private void signupLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpFrm signUpfrm = new SignUpFrm(infrm);
            this.Hide();
            signUpfrm.ShowDialog();

        }
        public  PersonDetail signin()
        {

            string name = userName_txt.Text;
            string password = SignInPasswordTxt.Text;
            PersonDetail siginIN = new PersonDetail(name, password);
            return siginIN;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form intofrm = new introFrm(infrm);
            intofrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form cufrm = new CustomerFrm();
            cufrm.ShowDialog();
        }

        private void signupLnk_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form signup = new SignUpFrm(infrm);
            signup.ShowDialog();
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            FileHandler.store(FileHandler.path);
            FileHandler.storeCloth(FileHandler.clothPath);
            FileHandler.storeBrandLength();
            FileHandler.storeCustomerFeedback();
            FileHandler.storeBrandName();
            FileHandler.store_LengthOf_PersonList(PersonDetailCrud.Person_LengthPath);
            
            Application.Exit();
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
