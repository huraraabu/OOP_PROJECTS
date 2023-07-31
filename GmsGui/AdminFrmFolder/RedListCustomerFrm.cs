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

namespace GmsGui.AdminFrmFolder
{
    public partial class RedListCustomerFrm : Form
    {
        public RedListCustomerFrm()
        {
            InitializeComponent();
        }

        private void RedCustmerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void RedListCustomerFrm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Name",typeof(string));
            table.Columns.Add("Password",typeof(string));
            table.Columns.Add("Card Balance",typeof(int));
            table.Columns.Add("Return Product",typeof(int));
                
            foreach(CustomerDetail cus in CustomerDetailCrud.getBannedList())
            {
                table.Rows.Add(cus.getName(),cus.getPassword(),cus.CardBalance1,cus.ReturnProductCount);
            }
            RedCustmerGrid.DataSource = null;
            RedCustmerGrid.DataSource = table;
            RedCustmerGrid.Refresh();
        }

        private void RemCusBtn_Click(object sender, EventArgs e)
        {
            string removeCustomer="";
            if (RedCustmerGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = RedCustmerGrid.SelectedRows[0].Index;
                DataGridViewRow selectedRow = RedCustmerGrid.SelectedRows[0];
                removeCustomer = selectedRow.Cells["Name"].Value.ToString();
                RedCustmerGrid.Rows.RemoveAt(selectedIndex);

            }
            CustomerDetail cus = CustomerDetailCrud.IsBannedCustomer(removeCustomer);
            if (cus != null)
            {
                CustomerDetailCrud.removeBannedcustomer(cus);
                int budget = OwnerCrud.getOwner().getTotalBudget();
                budget = budget + cus.CardBalance1;
                OwnerCrud.getOwner().setTotalBudget(budget);
                PersonDetail removePerson = HeadBoyDetailCrud.getObject_byName(cus.getName(), "customer");
                PersonDetailCrud.removePerson(removePerson);
                MessageBox.Show("CUSTOMER CARD BALANCE IS ADDED  INTO THE BUDGET","w",MessageBoxButtons.OK);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form adfrm = new frmAdmin();
            adfrm.ShowDialog();
        }
    }
}
