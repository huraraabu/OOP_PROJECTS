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

namespace GmsGui
{
    public partial class SignUpFrm : Form
    {
        private InputFrm infrm;
        public SignUpFrm(InputFrm infrm)
        {
            InitializeComponent();
            this.infrm = infrm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginFrm logfrm = new loginFrm();
            logfrm.ShowDialog();
        }

        

        private void loginBtn_Click(object sender, EventArgs e)
        {
           
            PersonDetail person = signUp();
            if (PersonDetailCrud.checkIntegerEntity(PasswordTxt.Text) == false)
            {
                invalidPassLbl.Visible = true;

            }
            else
            {
                invalidPassLbl.Visible = false;
            }
            if (PersonDetailCrud.checkAplhabetEntity(Nametxt.Text) == false)
            {
                INnameLbl.Visible = true;

            }
            else
            {
                INnameLbl.Visible = false;
            }
            if (person != null)
            {
                if(INnameLbl.Visible == false && invalidPassLbl.Visible == false)
                {
                    PersonDetailCrud.setObjectInlist(person);
                    this.Close();
                }
                //else
                //{
                //  MessageBox.Show("ENTER VALID VALUES","warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //}


                
            }
            else
            {
                MessageBox.Show("USER ALREADY EXIST","warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            



        }
        public  PersonDetail signUp()
        {
            string name = Nametxt.Text; 
            string password = PasswordTxt.Text;
            if (PersonDetailCrud.checkIntegerEntity(password) == false)
            {
                invalidPassLbl.Visible = true;
            }

            string role = rolecomBx.Text;
            if (isOwner_AlreadyExist(role) == false)
            {

                if (PersonDetailCrud.isUserExist(name, role) == false)
                {
                 
                    PersonDetail person = new PersonDetail(name, password, role);
                    PersonDetailCrud.setRoleIn_application(role, person);
                    return person;

                }
                else
                {
                MessageBox.Show("USER ALREADY EXIST","warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                }
            }
            else
            {
                MessageBox.Show("OWNER ALREADT EXIST","warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return null;

        }
        public static bool isOwner_AlreadyExist(string role)
        {

            if ((role.ToLower() == "owner") && (OwnerCrud.OwnerStatus == 'Y'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

        private void PasswordTxt_MouseHover(object sender, EventArgs e)
        {

            PasswordTxt.Text ="";
            

        }

        

        private void Nametxt_MouseHover(object sender, EventArgs e)
        {
            Nametxt.Text = "";
        }

        private void rolecomBx_MouseHover(object sender, EventArgs e)
        {
            rolecomBx.Text = "";
        }
    }
}
