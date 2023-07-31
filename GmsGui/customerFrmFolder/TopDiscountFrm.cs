using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Garments_Management_System.Data_Layer;
using Garments_Management_System.Business_Layer;
using GmsGui.ViewFormFolder;
namespace GmsGui.customerFrmFolder
{
    public partial class TopDiscountFrm : Form
    {
        public static BrandDetail brand;
        
        
        public TopDiscountFrm()
        {
            InitializeComponent();
        }

        private void TopDiscountFrm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
