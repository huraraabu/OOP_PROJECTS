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

namespace GmsGui.ViewFormFolder
{
     
    public partial class ClothFrm : Form
    {
        
        public ClothFrm()
        {
            InitializeComponent();
        }

        private void clothGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
          
        }

        private void ClothFrm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            bool isListEmpty = false;



            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Color", typeof(string));
            table.Columns.Add("Price", typeof(string));
            table.Columns.Add("Size", typeof(string));

            if (BrandDetailCrud.clothDetailGrid != null)
            {
                foreach (ClothDetail cloth in BrandDetailCrud.clothDetailGrid)
                {

                    if (cloth != null)
                    {
                        table.Rows.Add(cloth.getName(),cloth.getColor(),cloth.getPrice(),cloth.getSize());
                    }
                    else
                    {
                        isListEmpty = true;
                    }

                }
            }

            if (isListEmpty == true)
            {
                MessageBox.Show("LIST IS EMPTY", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            clothGrid.DataSource = null;
            clothGrid.DataSource =table;
            clothGrid.Refresh();
        }

        private void Exitpng_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerFrm cufr = new CustomerFrm();
            BrandDetailCrud.clothDetailGrid = null;
            cufr.ShowDialog();
        }

        private void backtoemployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeFrm ef = new EmployeeFrm();
            ef.ShowDialog();
        }
    }
}
