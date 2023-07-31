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
using GmsGui.Data_Layer;

namespace GmsGui.customerFrmFolder
{
    public partial class Balancefrm : Form
    {
        public Balancefrm()
        {
            InitializeComponent();
        }

        private void balnceReBtn_Click(object sender, EventArgs e)
        {
            setRechargeDetail();
        }
        public void setRechargeDetail()
        {
            BalnaceTxt.Visible = true;
            balanceLbl.Visible = true;
            Addbtn.Visible = true;
            remLbl.Visible = false;
            remainTxt.Visible = false;
        }
        public int loadBalance()
        {
      


            string balance=BalnaceTxt.Text ;
            if (PersonDetailCrud.checkIntegerEntity(balance) == false)
            {
                invalidSalarLbl.Visible = true;   
                
            }
            else
            {
                invalidSalarLbl.Visible = false;
            }
            return (Convert.ToInt32(balance));



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Balance = loadBalance();
            if (invalidSalarLbl.Visible == false)
            {
                CustomerDetailCrud.CurrentCustomer.CardBalance1 = Balance;
                MessageBox.Show("BALANCE IS ADDED","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                BalnaceTxt.Text = "";
            }
            else
            {
                MessageBox.Show("ENTER VALID VALUES","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                invalidSalarLbl.Text = "";
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            int balance = CustomerDetailCrud.CurrentCustomer.CardBalance1;
            setRemaingDetail();
            remainTxt.Text =Convert.ToString(balance);
        }
        public void setRemaingDetail()
        {
            BalnaceTxt.Visible = false;
            balanceLbl.Visible = false;
            Addbtn.Visible = false;
            remLbl.Visible = true;
            remainTxt.Visible = true;
        }

        private void backtoBrand_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerFrm cufr = new CustomerFrm();
            cufr.ShowDialog();
        }
        bool balMenuExpand = false;
        private void balanceTransisition_Tick(object sender, EventArgs e)
        {
            if (balMenuExpand == false)
            {
                BalancePLn.Height += 10;
                if (BalancePLn.Height >= 153)
                {
                    balanceTransisition.Stop();
                    balMenuExpand = true;
                }
            }
            else
            {
                BalancePLn.Height -= 10;
                if (BalancePLn.Height == 55)
                {
                    balanceTransisition.Stop();
                    balMenuExpand = false;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            balanceTransisition.Start();
        }
    }
}
