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

namespace GmsGui.customerFrmFolder
{
    public partial class PurchasinFrm : Form
    {
        public PurchasinFrm()
        {
            InitializeComponent();
        }

        public  void setfalse()
        {
            purPln.Visible = false;
            FeedbackPln.Visible = false;
            FeedbackTxt.Visible = false;
            feedbackLbl.Visible = false;
            FeedbackBack.Visible = false;
        }
        public void settrue()
        {
            purPln.Visible = true;
            FeedbackPln.Visible = false;
            FeedbackTxt.Visible = false;
            feedbackLbl.Visible = false;
            FeedbackBack.Visible = false;
        }
        public void setFeedbackFrm()
        {
            purPln.Visible = false;
            FeedbackPln.Visible = false;
            FeedbackTxt.Visible = false;
            feedbackLbl.Visible = false;
            FeedbackPln.Visible = true;
            Addbtn.Visible = false;
            FeedbackBack.Visible = true;
        }
        private void PurchasinFrm_Load(object sender, EventArgs e)
        {
            setPurchasingGrid();
        }
        public void setPurchasingGrid()
        {
            DataTable table = new DataTable();




            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Color", typeof(string));
            table.Columns.Add("Price", typeof(string));
            table.Columns.Add("Size", typeof(string));


            foreach (ClothDetail cloth in CustomerDetailCrud.CurrentCustomer.getPurhasingList())
            {

                table.Rows.Add(cloth.getName(),cloth.getColor(),cloth.getPrice(),cloth.getSize());

            }



            purchasingGrid.DataSource = null;
            purchasingGrid.DataSource = table;
            purchasingGrid.Refresh();
        }
        private void purchasingGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backtoBrand_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductFrm fr = new ProductFrm();
            fr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClothDetail refund_cloth =getPurClothobj_FromSelectedRow_OfGrid();

            if (refund_cloth != null)
            {
                refund_cloth.Number_OfStockAvailable1++;
                CustomerDetailCrud.CurrentCustomer.removePurchasing_cloth(refund_cloth);
                CustomerDetailCrud.CurrentCustomer.CardBalance1 = CustomerDetailCrud.CurrentCustomer.CardBalance1 + Convert.ToInt32(refund_cloth.getPrice());
                int budget = OwnerCrud.getOwner().getTotalBudget();
                budget = budget - Convert.ToInt32(refund_cloth.getPrice());
                OwnerCrud.getOwner().setTotalBudget(budget);
                CustomerDetailCrud.CurrentCustomer.ReturnProductCount++;
            }
            else
            {

                MessageBox.Show("NOT FOUND", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public ClothDetail getPurClothobj_FromSelectedRow_OfGrid()
        {
            string clothName = "";
            if (purchasingGrid.SelectedRows.Count > 0)
            {
                int selectedIndex =purchasingGrid.SelectedRows[0].Index;
                DataGridViewRow selectedRow = purchasingGrid.SelectedRows[0];
                clothName = selectedRow.Cells["Name"].Value.ToString();


            }
            ClothDetail cloth = CustomerDetailCrud.compare_Purching_List(clothName, CustomerDetailCrud.CurrentCustomer);

            return cloth;

        }
        
        private void FeedbackPln_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            setFeedback();
            FeedbackPln.Visible = false;  
        }
                  
        public void setFeedback()
        {
            purchasingGrid.Visible = false;
            purPln.Visible = false;
            FeedbackTxt.Visible = true;
            feedbackLbl.Visible = true;
            Addbtn.Visible = true;  
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ClothDetail feedBack_cloth = getPurClothobj_FromSelectedRow_OfGrid();
            if (feedBack_cloth != null)
            {
                string feedBack = FeedbackTxt.Text;
                feedBack_cloth.setfeedBack(feedBack);
                feedBack_cloth.FeedbackStatus1 = 'Y';
                CustomerFeedbackDetail CusFeedback = new CustomerFeedbackDetail();
                CusFeedback.Cloth = feedBack_cloth;
                CusFeedback.Customer = CustomerDetailCrud.CurrentCustomer.getName();
                CusFeedback.FeedBack = feedBack;
                CustomerFeedbackCrud.addObjectINFeedBackList(CusFeedback);
                MessageBox.Show("FEEDBACK IS ADDED", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                CustomerFrm cuf = new CustomerFrm();
                cuf.ShowDialog();
            }
            else
            {
                MessageBox.Show("WRONG INPUT", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FeedbackBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerFrm cufr = new CustomerFrm();
            cufr.ShowDialog();
        }
    }
}
