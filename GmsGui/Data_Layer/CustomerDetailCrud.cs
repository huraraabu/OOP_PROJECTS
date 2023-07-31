using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garments_Management_System.Business_Layer;


namespace Garments_Management_System.Data_Layer
{
   public  class CustomerDetailCrud
    {

        private static List<CustomerDetail> bannedCustomerList = new List<CustomerDetail>();
        public  static CustomerDetail CurrentCustomer=new CustomerDetail();

        //get banned list 
        public static List<CustomerDetail> getBannedList()
        {
            return bannedCustomerList;
        }

        //add customer in banned list
        public static void addCustomer_InBannedList(CustomerDetail cus)
        {
            bannedCustomerList.Add(cus);
        }
        //remove customer
        public static void removeBannedcustomer(CustomerDetail cus)
        {
            bannedCustomerList.Remove(cus);
        }
        //compare  purchasing list product
        public static ClothDetail compare_Purching_List(string name,CustomerDetail current_Customer)
        {
            foreach(ClothDetail cloth in current_Customer.getPurhasingList())
            {
                if(name==cloth.getName())
                {
                    return cloth;  
                }
            }
            return null;
        
        }
        //get  customer account health
        public static string checkStatusOfAccount(CustomerDetail customer)
        {
            if(customer.ReturnProductCount<5)
            {
                return "GREEN";
            }
            else if(customer.ReturnProductCount < 8)
            {
                return "BLUE";
            }
            else
            {
                addCustomer_InBannedList(customer);
                return "RED";
            }
        }
        //show banned customer
        //public static void show_BannedCustomer()
        //{
        //    foreach(CustomerDetail cus in bannedCustomerList)
        //    {
        //        CustomerDetailUI.show_CustomerDetail(cus);
        //    }
        //     Console.ReadKey();
        //}

        //get object and remove
        public static CustomerDetail IsBannedCustomer(string name)
        {
            foreach (CustomerDetail cus in getBannedList())
            {
                if(name==cus.getName())
                {
                    return cus;
                }
            }
            return null;
        }


    }


}
