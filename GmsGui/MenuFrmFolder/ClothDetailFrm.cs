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
using GmsGui.HeadBoyFrmFolder;
namespace GmsGui.MenuFrmFolder
{
    public partial class ClothDetailFrm : Form
    {
        public static ClothDetail currentCloth = new ClothDetail();
        public ClothDetailFrm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClothTxt.Text = "";
            PriceTxt.Text = "";
            colorTxt.Text = "";
            Sizetxt.Text  = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClothDetail cloth = new ClothDetail();
            cloth.setName (ClothTxt.Text);
            if (PersonDetailCrud.checkIntegerEntity(PriceTxt.Text) == false)
            {
                MessageBox.Show("PLEASE ENTER INTEGER VALUE", "waring", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                cloth.setPrice(PriceTxt.Text);
            }
            cloth.setColor(colorTxt.Text);
            cloth.setSize (Sizetxt.Text);
            cloth.Number_OfStockAvailable1 =Convert.ToInt32(quantityTxt.Text);
            currentCloth = cloth;
            this.Close();
           
        }

        private void ClothDetailFrm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            HeadBoyFrm hf = new HeadBoyFrm();
            hf.ShowDialog();
        }
    }
}
