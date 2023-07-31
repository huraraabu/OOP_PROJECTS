using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garments_Management_System.Business_Layer;

namespace Garments_Management_System.Data_Layer
{
   public  class CustomerFeedbackCrud
    {
        private static List<CustomerFeedbackDetail> customerFeedbackList = new List<CustomerFeedbackDetail>();

        //get customer FeedBack length
        public static List<CustomerFeedbackDetail> get_customerFeedbackList()
        {
            return customerFeedbackList;
        }

        public static void addObjectINFeedBackList(CustomerFeedbackDetail cus)
        {

            customerFeedbackList.Add(cus);
        }
    }
}
