using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garments_Management_System.Business_Layer
{
   public  class EmployeeDetail : PersonDetail
    {
        private string MessageToAdmin;
        private string MessageToHeadBoy;
        private string MessageToCustomer;
        private string salary;
        private char   Status;


        public string MessageToAdmin1 { get => MessageToAdmin; set => MessageToAdmin = value; }
        public string MessageToHeadBoy1 { get => MessageToHeadBoy; set => MessageToHeadBoy = value; }
        public string MessageToCustomer1 { get => MessageToCustomer; set => MessageToCustomer = value; }
        public string Salary { get => salary; set => salary = value; }
        public char Status1 { get => Status; set => Status = value; }

        public override string returnRole()
        {
            return "employee";
        }
        public EmployeeDetail(string Name, string Password,string Role) : base()
        {
            this.Name = Name;
            this.Password = Password;
            this.Role = Role;
        }
      
        public  EmployeeDetail(string Name,string Password,string Role,string MessageToAdmin, string MessageToCustomer,string MessageToHeadBoy,string  salary,char Status)
        {
            this.Name = Name;
            this.Password = Password;
            this.Role = Role;
            this.MessageToAdmin = MessageToAdmin;
            this.MessageToCustomer = MessageToCustomer;
            this.MessageToHeadBoy = MessageToHeadBoy;
            this.salary = salary;
            this.Status = Status;
        }   
        public EmployeeDetail()
        {

        }
    }
}
