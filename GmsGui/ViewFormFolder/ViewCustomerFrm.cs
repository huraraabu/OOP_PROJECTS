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

namespace GmsGui.ViewFormFolder
{
    public partial class ViewCustomerFrm : Form
    {
        public static List<CustomerDetail> customerlist = new List<CustomerDetail>();
        public ViewCustomerFrm()
        {
            InitializeComponent();
        }

        private void CustomerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerGrid.DataSource = null;
            CustomerGrid.DataSource = customerlist;
            CustomerGrid.Refresh();
        }
        public static void setObject_byRole(string role)
        {
            foreach (PersonDetail person in PersonDetailCrud.getPersonList())
            {
                if (person.getRole() == role)
                {
                    CustomerDetail cus = (CustomerDetail)person;
                    customerlist.Add(cus);
                    
                }
            }
          
        }
    }
}
