using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garments_Management_System.Business_Layer
{
    public  class CustomerFeedbackDetail
    {
        private ClothDetail  cloth = new ClothDetail();
        private string  customer;      
        private string feedBack;

        public ClothDetail Cloth { get => cloth; set => cloth = value; }
        
        public string FeedBack { get => feedBack; set => feedBack = value; }
        public string Customer { get => customer; set => customer = value; }
    
        public CustomerFeedbackDetail()
        {

        }
        public CustomerFeedbackDetail(string feedBack,ClothDetail cloth,string customer)
        {
            this.feedBack = feedBack;
            this.cloth = cloth;
            this.customer = customer;
        }
    
    }
}
