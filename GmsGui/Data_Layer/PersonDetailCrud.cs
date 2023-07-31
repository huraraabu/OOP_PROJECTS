using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garments_Management_System.Business_Layer;
using System.Windows.Forms;

namespace Garments_Management_System.Data_Layer
{
   public  class PersonDetailCrud
   {
        private static List<PersonDetail> PersonsList = new List<PersonDetail>();
        
        
     //get person list
        public static List<PersonDetail> getPersonList()
        {
            return PersonsList;
        }
      
        
        //get person object 
        public static  PersonDetail getPerson_Object(int index)
        {
           return(PersonsList[index]);
        }

        //remove object from person list
        public static void removePerson(PersonDetail person)
        {
            PersonsList.Remove(person);
        }
        //get person list length
        public static int get_Person_ListLength()
        {
            return (PersonsList.Count());
                
        }
        //add person in personlist
        public static void addPerson(PersonDetail person)
        {
            PersonsList.Add(person);
        }
        //set  object in list
        public static void setObjectInlist(PersonDetail person)
        {
          
            if(person.getRole().ToLower()=="customer")
            {
                
                 CustomerDetail customer = new CustomerDetail(person.getName(),person.getPassword(),person.getRole());
                addPerson(customer);

            }
            else if (person.getRole().ToLower() == "headboy")
            {
                HeadBoyDetail headboy = new HeadBoyDetail(person.getName(), person.getPassword(),person.getRole());
                addPerson(headboy);
            }
            else if (person.getRole().ToLower() == "owner")
            {
               
                OwnerDetail owner = new OwnerDetail(person.getName(), person.getPassword(),person.getRole());
                addPerson(owner);
            }
            else if (person.getRole().ToLower() == "employee")
            {
                EmployeeDetail employee = new EmployeeDetail(person.getName(), person.getPassword(),person.getRole());
                addPerson(employee);
            }
        }

        public static string Person_LengthPath= "D:\\PersonListLength.txt";
        
        public static PersonDetail CompareDetail(PersonDetail siginIn)
        {
            foreach(PersonDetail person in PersonsList)
            {
            
         
                if ((person.getName()==siginIn.getName())&& (person.getPassword() == siginIn.getPassword()))
                {
                   
                    return person;
                }
            }
            return null;
        }
     


         //check signup role
        
        public static bool checkAdmin()
        {
            foreach(PersonDetail person in PersonsList)
            {
                if(person.getRole().ToLower()=="owner")
                {
                    return true;
                }

            }
            return false;
        }
        //check empty function
        public bool checkEmpty(string name,string password,string role)
        {

            if ((name == "") || (password == "")||(role==""))
            {
                return false;
            }
            else
            {
                return true;
            }


        }
        public static PersonDetail getObject_byRole(string role)
        {
            foreach(PersonDetail person in PersonDetailCrud.getPersonList())
            {
                if(person.getRole()==role)
                {
                    return person;
                }
            }
            return null;           
        }
        //check integer value
        public static  bool checkIntegerEntity(string password)
        {
            int count = 0;
            for (int a = 0; a < password.Length; a++)
            {
                if ((password[a] == '1') || (password[a] == '2') || (password[a] == '3') || (password[a] == '4') || (password[a] == '5') || (password[a] == '6') || (password[a] == '7') || (password[a] == '8') || (password[a] == '9') || (password[a] == '0'))
                {
                    count++;
                }

            }
            if (count == password.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //check alphabetic value
        public static  bool checkAplhabetEntity(string name)
        {
            int count = 0;
            for (int a = 0; a < name.Length; a++)
            {
                if ((name[a] == '1') || (name[a] == '2') || (name[a] == '3') || (name[a] == '4') || (name[a] == '5') || (name[a] == '6') || (name[a] == '7') || (name[a] == '8') || (name[a] == '9'))
                {
                    count++;
                }
            }
            if (count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //count  cinc length
        public static bool countLength(string  cinc)
        {
            if(cinc.Length==13)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //is user exist from this role
        public static bool isUserExist(string name,string role)
        {
            foreach(PersonDetail person in PersonsList)
            {
                if((person.getName()==name)&&(person.getRole() == role))
                {
                    return true;
                }

            }
            return false;
        }
        //check menu option
        public static bool  checkMenu_Option(string name)
        {
            if (name.Length == 1)
            {
                if ((name == "1") || (name == "2") || (name == "3") || (name == "4") || (name == "5") || (name == "6") || (name == "7") || (name == "8") || (name == "9"))
                {
                    return true;
                }
            }
            return false;
        }


        //set role in application
        public static void setRoleIn_application(string role, PersonDetail person)
        {

            if ((role.ToLower() != "owner") && (role.ToLower() != "customer") && (role.ToLower() != "headboy") && (role.ToLower() != "employee"))
            {
                
                person.setRole("customer");
            }


        }
    }
}
