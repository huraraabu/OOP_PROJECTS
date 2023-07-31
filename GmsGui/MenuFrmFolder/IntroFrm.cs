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
namespace GmsGui
{
    public partial class introFrm : Form
    {
        private InputFrm infrm;
        public introFrm(InputFrm infrm)
        {
            InitializeComponent();
            this.infrm = infrm;
        }
        public introFrm()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value<100)
            {
                progressBar1.Value+=5;

            }
            else
            {
                timer1.Stop();
                this.Hide();
                Form cufrm = new loginFrm();
                cufrm.ShowDialog();
            }
        }

        private void introFrm_Load(object sender, EventArgs e)
        {
            FileHandler.loadBrandName();
            FileHandler.loadData(FileHandler.path);
            FileHandler.loadCloth();
           
            timer1.Start();

        }
    }
}
