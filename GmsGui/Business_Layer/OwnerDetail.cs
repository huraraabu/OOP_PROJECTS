using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garments_Management_System.Data_Layer;

namespace Garments_Management_System.Business_Layer
{
    public  class OwnerDetail:PersonDetail
    {

        private string Message_to_HeadBoy;
        private string Message_to_Customer;
        private int TotalBudget;
        private List<string> AssignCompany_Name=new List<string>();
        private char isDetailAdd;
        



        public OwnerDetail(string Name, string Password,string Role) : base()
        {
            this.Name = Name;
            this.Password = Password;
            this.Role = Role;
        }
        public OwnerDetail(string Name,string Password,string Role,string Message_to_Customer,string Message_to_HeadBoy,int TotalBudget,char isDetailAdd)
        {
            this.Name = Name;
            this.Password = Password;
            this.Role = Role;
            this.Message_to_HeadBoy = Message_to_HeadBoy;
            this.Message_to_Customer = Message_to_Customer;
            this.TotalBudget = TotalBudget;
            this.isDetailAdd = isDetailAdd;
            
        }
         public OwnerDetail()
        {

        }

        public int getTotalBudget()
        {
            return TotalBudget;
        }
        public void setTotalBudget(int TotalBudget)
        {
           this.TotalBudget=TotalBudget;
        }
        public string Message_to_HeadBoy1 { get => Message_to_HeadBoy; set => Message_to_HeadBoy = value; }
        public char IsDetailAdd { get => isDetailAdd; set => isDetailAdd = value; }
        public string Message_to_Customer1 { get => Message_to_Customer; set => Message_to_Customer = value; }

        public override string returnRole()
        {
            return "owner";
        }
        public string  get_AssignCompany_Name(int indexNumber)
        {
            return AssignCompany_Name[indexNumber];
        }
        public void set_AssignCompany_Name(string FutureOwner)
        {
            AssignCompany_Name.Add(FutureOwner);
        }
        public int get_lengthOf_ChildList()
        {
            return AssignCompany_Name.Count();
        }
    }
}
