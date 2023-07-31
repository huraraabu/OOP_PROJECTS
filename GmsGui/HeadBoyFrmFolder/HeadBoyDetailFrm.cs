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

namespace GmsGui.HeadBoyFrmFolder
{
    public partial class HeadBoyDetailFrm : Form
    {
       
        public HeadBoyDetailFrm()
        {
            InitializeComponent();
        }

        private void SumitBtn_Click(object sender, EventArgs e)
        {
         
            if (invalidNumberLbl.Visible == false && invalidSalarLbl.Visible == false && InCompCincLbl.Visible == false)
            {
                HeadBoyDetailCrud.Current_headBoy1.Address = AddresscomBx.Text;
                HeadBoyDetailCrud.Current_headBoy1.Cinc1 = cincTxt.Text;
                HeadBoyDetailCrud.Current_headBoy1.PhoneNumber1 = NumberTxt.Text;
                HeadBoyDetailCrud.Current_headBoy1.Salary1 = salaryTxt.Text;
                HeadBoyDetailCrud.Current_headBoy1.Education = EducationcomBx.Text;
                HeadBoyDetailCrud.Current_headBoy1.DetailStatus1 = 'Y';
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter Valid Details","warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            AddresscomBx.Text = "";
            cincTxt.Text = "";
            NumberTxt.Text = "";
            EducationcomBx.Text = "";
            salaryTxt.Text = "";
        }

        private void invInteCincLbl_Click(object sender, EventArgs e)
        {

        }

        private void HeadBoyDetailFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form logfrm = new loginFrm();
            logfrm.ShowDialog();

        }
    }
}
