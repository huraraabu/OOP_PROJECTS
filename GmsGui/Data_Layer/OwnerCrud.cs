using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garments_Management_System.Business_Layer;



namespace Garments_Management_System.Data_Layer
{
  public class OwnerCrud
    {
        private static OwnerDetail owner = new OwnerDetail();
        private static char ownerStatus;

        public static char OwnerStatus { get => ownerStatus; set => ownerStatus = value; }

        public  static double calculateDiscount(double discount_Percentage,double totalPrice)
        {
            double dicount = (discount_Percentage / totalPrice) * 100;
            return dicount;
        }
        public static void setOwner(OwnerDetail own)
        {
            owner = own;
        }
        public static OwnerDetail getOwner()
        {
            return owner;
        }
        //check the assigned name
        public static bool check_chidrenName(string name)
        {
            for(int index=0;index<OwnerCrud.getOwner().get_lengthOf_ChildList();index++)
            {
                if (name == getOwner().get_AssignCompany_Name(index))
                {
                    return true;
                }

            }
            return false;
        }
    }
}
