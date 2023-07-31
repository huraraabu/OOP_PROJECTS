using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garments_Management_System.Business_Layer;





namespace Garments_Management_System.Data_Layer
{
    public class HeadBoyDetailCrud
    {
        private static   List<HeadBoyDetail> headboylist = new List<HeadBoyDetail>();
        
        
        private static   HeadBoyDetail Current_headBoy = new HeadBoyDetail();
        private static char isHeadBoyExist;


       
        public static HeadBoyDetail Current_headBoy1 { get => Current_headBoy; set => Current_headBoy = value; }
        public static char IsHeadBoyExist { get => isHeadBoyExist; set => isHeadBoyExist = value; }


        //get headboy list
        public  static List<HeadBoyDetail> getHeadBoyList()
        {
            return headboylist;
        }
        

        //get object of  headBoy by name

        public static PersonDetail getObject_byName(string name,string role)
        {
            foreach (PersonDetail person in PersonDetailCrud.getPersonList())
            {
               
                
                if ((person.getName().ToLower() == name.ToLower())&&(person.getRole().ToLower()==role.ToLower()))
                {
                    
                    return person;
                }
            }
            return null;
        }
        //set current head Boy

        public static void setCurrentHeadboy()
        {
            Current_headBoy1 = null;
        }



        //remove object of headBoy
        public static void removeObject(PersonDetail person)
        {
            PersonDetailCrud.removePerson(person);
        }
        

      
        
        
        //add headdDetailobjectinlist
        public static void addObjectInList(HeadBoyDetail headBoy)
        {
            headboylist.Add(headBoy);
        }
        

    }
}
