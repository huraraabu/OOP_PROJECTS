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

namespace GmsGui.EmployeeFrmFolder
{
    public partial class CusDeatilFrm : Form
    {
        public CusDeatilFrm()
        {
            InitializeComponent();
        }

        private void BacktoEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new EmployeeFrm();
            f.ShowDialog();
        }

        private void CusDeatilFrm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Password", typeof(string));
            table.Columns.Add("Card Balance", typeof(int));
            table.Columns.Add("Return Product", typeof(int));
            foreach (PersonDetail person in PersonDetailCrud.getPersonList())
            {
                if (person.getRole().ToLower() == "customer")
                {
                    CustomerDetail cus = (CustomerDetail)person;

                    table.Rows.Add(cus.getName(), cus.getPassword(), cus.CardBalance1, cus.ReturnProductCount);
                }
            }
            customerGrid.DataSource = null;
            customerGrid.DataSource = table;
            customerGrid.Refresh();
        }
    }
}
