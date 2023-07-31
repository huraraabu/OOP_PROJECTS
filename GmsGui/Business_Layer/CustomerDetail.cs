using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garments_Management_System.Business_Layer
{
    public class CustomerDetail:PersonDetail
    {
        private List<string> AddTocardProduct = new List<string>();
        private int CardBalance;
        private int returnProductCount;
        private List<ClothDetail> Purchasing_list = new List<ClothDetail>();
        private string messageToHeadBoy;
        private string messageFromHeadBoy;


        public int CardBalance1 { get => CardBalance; set => CardBalance = value; }
        public int ReturnProductCount { get => returnProductCount; set => returnProductCount = value; }
        public string MessageToHeadBoy { get => messageToHeadBoy; set => messageToHeadBoy = value; }
        public string MessageFromHeadBoy { get => messageFromHeadBoy; set => messageFromHeadBoy = value; }

        public override string returnRole()
        {
            return "customer";
        }
        public CustomerDetail()
        {

        }
        public CustomerDetail(string Name,string Password,string Role,int CardBalance,int ReturnProductCount,string messageFromHeadBoy,string messageToHeadBoy)
        {
            setName(Name);
            setPassword(Password);
            setRole(Role);
            this.CardBalance = CardBalance;
            this.ReturnProductCount = ReturnProductCount;
            this.messageFromHeadBoy = messageFromHeadBoy;
            this.messageToHeadBoy = messageToHeadBoy;
        }


        //get customer purchasing list
        public List<ClothDetail>  getPurhasingList()
        {
            return Purchasing_list;
        }

        public List<string> getAddToCardList()
        {
            return AddTocardProduct;
        }


        //remove object 
        public  void removePurchasing_cloth(ClothDetail cloth)
        {
            Purchasing_list.Remove(cloth);
        }
        //add object 
        public void add_clothIn_PurchasingLIsts(ClothDetail cloth)
        {
            Purchasing_list.Add(cloth);
        }

        public  CustomerDetail(string Name,string Password,string Role):base()
        {
            this.Name = Name;
            this.Password = Password;
            this.Role = Role;
        }
        public void set_AddTocardProduct(string product)
        {
            AddTocardProduct.Add(product);
        }
        public string get_AddTocardProduct(int indexNumber)
        {
            return AddTocardProduct[indexNumber];
        }
        public int get_LengthOfAddToCardList()
        {
            if (AddTocardProduct!= null)
            {
                return AddTocardProduct.Count();
            }
            else
            {
                return 0;
            }
        }
        

        public void remove_AddToCardProduct(string name)
        {
            AddTocardProduct.Remove(name);
        }
        public void emptyList()
        {
            AddTocardProduct = null;
        }
    }
}
