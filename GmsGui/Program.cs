using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Garments_Management_System.Business_Layer;
using Garments_Management_System.Data_Layer;
using GmsGui.customerFrmFolder;
namespace GmsGui
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new introFrm());
            Application.EnableVisualStyles();
            

        }
    }
}
