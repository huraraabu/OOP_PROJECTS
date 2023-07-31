using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garments_Management_System.Business_Layer;
using System.Windows.Forms;

namespace Garments_Management_System.Data_Layer
{
    public  class EmployeeDetailCrud
    {
        private static List<EmployeeDetail> employeeList = new List<EmployeeDetail>();
        public static EmployeeDetail curentEmployee = new EmployeeDetail(); 

        //get employee list
        public  static List<EmployeeDetail> get_employeeList()
        {
            return employeeList;
        }

        //show high feedback cloth
        public static void showCloth()
        {
           
            BrandDetail highFeedback_Brand = BrandDetailCrud.getBrandObject_byInput();
            if (highFeedback_Brand != null)
            {
                int Men_High_Feedback = BrandDetailCrud.get_high_MenCloth_feedback(highFeedback_Brand);
                ClothDetail men_high_Feedback_cloth = BrandDetailCrud.Get_cloth_object_by_highFeedback(highFeedback_Brand, Men_High_Feedback);
                BrandDetailCrud.clothDetailGrid.Add(men_high_Feedback_cloth);
                int WoMen_High_Feedback = BrandDetailCrud.get_high_WoMenCloth_feedback(highFeedback_Brand);
                ClothDetail Women_high_Feedback_cloth = BrandDetailCrud.Get_cloth_object_by_highFeedback(highFeedback_Brand, WoMen_High_Feedback);
                BrandDetailCrud.clothDetailGrid.Add(Women_high_Feedback_cloth);
                int Baby_High_Feedback = BrandDetailCrud.get_high_BabyCloth_feedback(highFeedback_Brand);
                ClothDetail Baby_high_Feedback_cloth = BrandDetailCrud.Get_cloth_object_by_highFeedback(highFeedback_Brand, Baby_High_Feedback);
                BrandDetailCrud.clothDetailGrid.Add(Baby_high_Feedback_cloth);
            }
            else
            {
                MessageBox.Show("WRONG INPUT", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void showDetailOfSale_productBrand()
        {
            foreach (BrandDetail brand in BrandDetailCrud.GetBrandsList())
            {
                getSaleProductObject(brand);
            }
        }
        public static void getSaleProductObject(BrandDetail brand)
        {
           
            for (int index = 0; index < brand.getSaleProductLength(); index++)
            {
                ClothDetail cloth = brand.getSaleProduct(index);

                BrandDetailCrud.clothDetailGrid.Add(cloth);
            }

        }
          

    }
}
