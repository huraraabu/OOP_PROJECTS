using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GmsGui.AdminFrmFolder
{
    public partial class IncomeFrm : Form
    {
        private frmAdmin instance;
       
        public IncomeFrm(frmAdmin fradmn)
        {
            InitializeComponent();
            instance = fradmn;
          
        }

        private void IncomeFrm_Load(object sender, EventArgs e)
        {
            incomeTxt.Text = instance.getIncome();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            Form admfrm = new frmAdmin();
            admfrm.ShowDialog();
        }
    }
}
