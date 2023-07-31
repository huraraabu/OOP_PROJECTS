using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garments_Management_System.Business_Layer
{
    public class HeadBoyDetail:PersonDetail
    {
      
      private string address;
      private string education;
      private string Salary;
      private string PhoneNumber;
      private string Cinc;
      private char status;
      private char DetailStatus;

      
      


        public string Address { get => address; set => address = value; }
        public string Education { get => education; set => education = value; }
        public string Salary1 { get => Salary; set => Salary = value; }
        public string PhoneNumber1 { get => PhoneNumber; set => PhoneNumber = value; }
        public string Cinc1 { get => Cinc; set => Cinc = value; }
        public char Status { get => status; set => status = value; }
        public char DetailStatus1 { get => DetailStatus; set => DetailStatus = value; }




        
        
       
        //override fuctions
        public override string returnRole()
        {
            return "headboy";
        }
        public HeadBoyDetail(string Name,string Password,string Role) :base()
        {
            this.Name = Name;
            this.Password = Password;
            this.Role = Role;
        }
        public HeadBoyDetail()
        {

        }
   
        public HeadBoyDetail(string Name,string Password,string Role,string address,string Cinc,string education,char DetailStatus,char status)
        {
            this.Name = Name;
            this.Password = Password;
            this.Role = Role;
            this.address = address;
            this.Cinc = Cinc;
            this.education = education;
            this.DetailStatus = DetailStatus;
            this.status = status;
        
        
        
        }     
        

    }

}
