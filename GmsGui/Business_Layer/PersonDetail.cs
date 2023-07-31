using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garments_Management_System.Business_Layer
{
  public   class PersonDetail
    {
        protected string Name;
        protected string Password;
        protected string Role;
        
        public   PersonDetail()
        {

        }
        public PersonDetail(string Name,string Password,string Role)
        {
            this.Name = Name;
            this.Password = Password;
            this.Role = Role;
        }
        public PersonDetail(string Name, string Password)
        {
            this.Name = Name;
            this.Password = Password;
            
        }
        //getter of the class

        public string getName()
        {
            return Name;
        }

        public string getPassword()
        {
            return Password;
        }
        public string getRole()
        {
            return Role;
        }
        public virtual string returnRole()
        {
            return "person";
        }

        //setter of the class
        public void setName(string Name)
        {
            this.Name = Name;
        }
        public void setPassword(string Password)
        {
            this.Password = Password;
        }
        public void setRole(string Role)
        {
            this.Role = Role;
        }

    }
}
