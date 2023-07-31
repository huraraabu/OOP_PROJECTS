using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garments_Management_System.Business_Layer;
using System.IO;
using System.Windows.Forms;
using Garments_Management_System.Data_Layer;
using GmsGui.customerFrmFolder;
using GmsGui.Inputform;
using GmsGui.Data_Layer;
using GmsGui.ViewFormFolder;
using GmsGui.MenuFrmFolder;

namespace Garments_Management_System.Data_Layer
{
    public class FileHandler
    {
      public static string path               =    "personData.txt";
      public static string clothPath          =    "ClothDetail.txt";
      public static string PathOf_BrandLength =    "BrandListLength.txt";
      public static string pathOf_clothList   =    "ClothsListLength.txt";
      public static string pathOf_MenCloth    =    "MenCloth.txt";
      public static string pathOf_WoMenCloth  =    "WoMenCloth.txt";
      public static string pathOf_BabyCloth   =    "BabyCloth.txt";
      public static string pathOf_PurchaseProduct= "PurchaseCloth.txt";
      public static string pathOf_CustomerFeedback="CustomerFeedback.txt";
      public static string Path_Of_BrandName   = "BrandName.txt";
        
        
        
        //store customer feedback
        public static void storeCustomerFeedback()
        {   
            string feedbackSeparation = ",";
            StreamWriter file = new StreamWriter(pathOf_CustomerFeedback,false);
            foreach(CustomerFeedbackDetail feedback in CustomerFeedbackCrud.get_customerFeedbackList())
            {
               file.WriteLine(ConvertINCsv(feedback,feedbackSeparation));
            }
            file.Flush();
            file.Close();
        }
        //load customer feedback
        public static void loadCustomerFeedback()
        {
            if (File.Exists(pathOf_CustomerFeedback))
            {
                string line;
                string[] data;
                StreamReader file = new StreamReader(pathOf_CustomerFeedback);
                while((line=file.ReadLine())!=null)
                {
                    data = line.Split(',');
                    CustomerFeedbackDetail cuF = new CustomerFeedbackDetail(data[0],setClothDetail(data[1]),data[2]);
                    
                }
            }
        }
         public static ClothDetail setClothDetail(string clothDetail)
         {
            string[] feedbacks;
            string[] data = clothDetail.Split(':');
            ClothDetail cloth = new ClothDetail(data[0],data[1],data[2],data[3],data[4],Convert.ToChar(data[5]),Convert.ToInt32(data[6]),Convert.ToInt32(data[7]));
            if(Convert.ToChar(data[5])=='Y')
            {
                string line = data[9];
                feedbacks = line.Split('^');
                setFeedback(feedbacks, cloth);
            }
            return cloth;
         }
            
            

        //get line of the customer
        public static string ConvertINCsv(CustomerFeedbackDetail cuF,string feedbackSeparation)
        {
            string clothSepartion = ":";
            string line = cuF.FeedBack + feedbackSeparation + getClothDetailWithoutBrand(cuF.Cloth,clothSepartion)+feedbackSeparation+cuF.Customer;
            return line;
            
        }
        
        public static string getClothDetailWithoutBrand(ClothDetail cloth,string Clothseparated)
        {
            string feedBackSepararted="^";
            string ClothObjectAttribute = cloth.getName() + Clothseparated + cloth.getPrice() + Clothseparated + cloth.getSize() + Clothseparated + cloth.getColor() + Clothseparated + cloth.getDiscount() + Clothseparated + cloth.FeedbackStatus1 + Clothseparated + cloth.Number_OfStockAvailable1 + Clothseparated + cloth.Number_OfStockSale1 + Clothseparated + get_feedback_string(cloth, feedBackSepararted);
            return ClothObjectAttribute;
         }

        //store brand names
        public static void storeBrandName()
        {
            StreamWriter file = new StreamWriter(Path_Of_BrandName);
            file.Write(getBrandString());
            file.Flush();
            file.Close();      
        }
        public  static string getBrandString()
        {
            string line=null;
            foreach (BrandDetail brand in BrandDetailCrud.GetBrandsList())
            {
                line = line + brand.getBrandName() + ",";
            }
            return line;
        }
                    
            
        //store Brand Detail
        public  static void storeCloth(string path)
        {
            storeMenCloth();
            storeWoMenCloth();
            storeBabyCloth();
            storeBrandLength();
            storePurchaseProduct();
        }


        
        

        //laod brand names in list
        //public static void loadBrandName()
        //{
        //    string line = null;
        //    StreamReader file = new StreamReader(Path_Of_BrandName);
        //    while((line=file.ReadLine()) != null)
        //    {
               
        //        BrandDetail brand = new BrandDetail();
        //        brand.setBrandName(line);
        //        BrandDetailCrud.addBrand_Object_In_list(brand);
        //    }
            
        //    file.Close();
        //}
        
        public static void loadBrandName()
        {
            string line;
            StreamReader file = new StreamReader(Path_Of_BrandName);
            line = file.ReadLine();
            setLine(line);
            file.Close();
        }
        public static void setLine(string line)
        {
            string[] brandName;
            brandName = line.Split(',');
            for (int index = 0; index < brandName.Length; index++)
            {
                BrandDetail brand = new BrandDetail();
                brand.setBrandName(brandName[index]);
                BrandDetailCrud.addBrand_Object_In_list(brand);
            }

        }
    //here i try to fil the fom


        


        //store lenght of lists  in  file
        public static void storeListsLength()
        {
            foreach(BrandDetail brand in BrandDetailCrud.GetBrandsList())
            {
               storeLineInfile(pathOf_clothList,setBrandList(brand));

            }
        }

        //get lenghth of lists in line
        public static string setBrandList(BrandDetail brand)
        {
            string line = brand.getBrandName() + "," + brand.getMenListLength() + "," + brand.getWoMenListLength() + "," + brand.getBabyListLength();
            return line;
        }
        //store length of cloths list

        public static void storelistlength()
        {
            StreamWriter file = new StreamWriter(pathOf_clothList);
            file.WriteLine();
            file.Close();
        }

        //store brand length
        public static  void storeBrandLength()
        {
            storeLength(PathOf_BrandLength, Convert.ToString(BrandDetailCrud.GetBrandsList().Count));
        }

        //convert in csv



        //Store  Men Cloth Detail
        public static void storeMenCloth()
        {
            StreamWriter file = new StreamWriter(pathOf_MenCloth);
            foreach (BrandDetail brand in BrandDetailCrud.GetBrandsList())
            {
                if (brand.getBrandName() != "")
                {
                    if (brand.getMenList() != null)
                    {
                        string MenClothString = null;
                        string Clothseparated = ",";

                        foreach (ClothDetail cloth in brand.getMenList())
                        {
                            Console.WriteLine(brand.getBrandName());
                            MenClothString = MenClothString + returnClothDetail(cloth, Clothseparated, brand.getBrandName()) + "]";
                        }
                        file.WriteLine(MenClothString);
                    

                    }


                }
            }
            file.Flush();
            file.Close();
        }

        //store women cloth

        public static void storeWoMenCloth()
        {
            StreamWriter file = new StreamWriter(pathOf_WoMenCloth);
            foreach (BrandDetail brand in BrandDetailCrud.GetBrandsList())
            {
                if (brand.getBrandName() != "")
                {
                    if (brand.getWomenList() != null)
                    {
                        string WOMenClothString = null;
                        string Clothseparated = ",";

                        foreach (ClothDetail cloth in brand.getWomenList())
                        {
                            Console.WriteLine(brand.getBrandName());
                            WOMenClothString = WOMenClothString + returnClothDetail(cloth, Clothseparated, brand.getBrandName()) + "]";
                        }
                        file.WriteLine(WOMenClothString);
                        

                    }


                }
            }
            file.Flush();
            file.Close();

        }


         //store baby cloths
        public static void storeBabyCloth()
      
        {
            StreamWriter file = new StreamWriter(pathOf_BabyCloth);
            foreach (BrandDetail brand in BrandDetailCrud.GetBrandsList())
            {
                if (brand.getBrandName() != "")
                {
                    if (brand.getBabyList() != null)
                    {
                        string BabyClothString = null;
                        string Clothseparated = ",";

                        foreach (ClothDetail cloth in brand.getBabyList())
                        {
                            Console.WriteLine(brand.getBrandName());
                            BabyClothString = BabyClothString + returnClothDetail(cloth, Clothseparated, brand.getBrandName()) + "]";
                        }
                        file.WriteLine(BabyClothString);
                      

                    }


                }
            }
            file.Flush();
            file.Close();
        }
        //store purchase product
        public static void storePurchaseProduct()
        {
            StreamWriter file = new StreamWriter(pathOf_PurchaseProduct);
            foreach (BrandDetail brand in BrandDetailCrud.GetBrandsList())
            {
                if (brand.getBrandName() != "")
                {
                    if (brand.getMenList() != null)
                    {

                        string SaleClothString = null;
                        string Clothseparated = ",";
                        foreach (ClothDetail cloth in brand.getSaleProductList())
                        {
                            Console.WriteLine(brand.getBrandName());
                            SaleClothString = SaleClothString + returnClothDetail(cloth, Clothseparated, brand.getBrandName()) + "]";
                        }
                        file.WriteLine(SaleClothString);
                    }
                }
                       
            }



            file.Flush();
            file.Close();
        }







        public static string returnClothDetail(ClothDetail cloth, string Clothseparated,string BrandName)
        {
            string feedBackSepararted = ";";
            string ClothObjectAttribute = BrandName+Clothseparated+cloth.getName() + Clothseparated + cloth.getPrice() + Clothseparated + cloth.getSize() + Clothseparated + cloth.getColor() + Clothseparated + cloth.getDiscount() + Clothseparated + cloth.FeedbackStatus1+ Clothseparated+cloth.Number_OfStockAvailable1+Clothseparated+cloth.Number_OfStockSale1+Clothseparated+ get_feedback_string(cloth, feedBackSepararted);
            return ClothObjectAttribute;
        }


        //convert feedback list into one string
        public static string get_feedback_string(ClothDetail cloth,string Feedbackseparated)
        {
            string feedback="";
            for(int  index=0;index<cloth.getFeedBackLength();index++)
            {
                feedback = feedback + cloth.getfeedBack(index)+Feedbackseparated;
            }
                return feedback;
        }



        //store the person data


        public static void store(string path)
        {

            string separated;
            separated = ",";
            StreamWriter file = new StreamWriter(path, false);
            foreach(PersonDetail person in PersonDetailCrud.getPersonList())
            {
               
                file.WriteLine(ConvertINCsv(person, separated));
              
            }
            file.Flush();
            file.Close();
            store_LengthOf_PersonList(PersonDetailCrud.Person_LengthPath);


        }



        //store length of person list in file
        
        public static void store_LengthOf_PersonList(string path)
        {
           storeLength(path, Convert.ToString(PersonDetailCrud.get_Person_ListLength()));
        }
        
        //store length in file 
        public static void storeLength(string path,string  length)
        {
            StreamWriter file = new StreamWriter(path, false);
            file.WriteLine(length);
            file.Flush();
            file.Close();
        }

         



        //load length of person list
        public static int load_Lengthof_PersonList()
        {
            StreamReader file = new StreamReader(PersonDetailCrud.Person_LengthPath);
            string length=file.ReadLine();
            file.Close();
            return(Convert.ToInt32(length));
        }

        //load length of brand list
        public static int load_Lengthof_BrandList()
        {
            StreamReader file = new StreamReader(PathOf_BrandLength);
            string length = file.ReadLine();
            file.Close();
            return (Convert.ToInt32(length));
        }


        //set separated character

        
        
        //set string in the form of separated 
        public static string ConvertINCsv(PersonDetail person,string separated)
        {
            string line="";
            if (person.getRole().ToLower() == "headboy")
            {
                HeadBoyDetail head = (HeadBoyDetail)person;
                line = head.getName() + separated + head.getPassword() + separated + head.getRole()+separated+head.Address+separated+head.Cinc1+separated+head.Education+separated+head.DetailStatus1+separated+head.Status;
            }
            else if(person.getRole().ToLower() == "customer")
            {
                CustomerDetail cus = (CustomerDetail)person;
                line = cus.getName() + separated + cus.getPassword() + separated +cus.getRole()+separated+ cus.CardBalance1 + separated + cus.ReturnProductCount + separated + cus.MessageFromHeadBoy + separated + cus.MessageToHeadBoy+separated+getStringOf_addTocard(cus,'Y')+separated+getStringOf_addTocard(cus,'N');
            }
            else if(person.getRole().ToLower() == "owner")
            {
                OwnerDetail owner = (OwnerDetail)person;
                line = owner.getName() + separated + owner.getPassword() + separated +owner.getRole()+separated+owner.Message_to_Customer1+separated+owner.Message_to_HeadBoy1+separated+ owner.getTotalBudget() +separated+owner.IsDetailAdd+separated;

            }
            else if (person.getRole().ToLower() == "employee")
            {
                EmployeeDetail employee = (EmployeeDetail)person;
                line = employee.getName() + separated + employee.getPassword() + separated + employee.getRole() + separated + employee.MessageToAdmin1 + separated + employee.MessageToCustomer1 + separated +employee.MessageToHeadBoy1+separated+employee.Salary+separated+employee.Status1;

            }
            return line;
            
        }
        
        //get string  of the add to card 
        public static string getStringOf_addTocard(CustomerDetail customer,char isReturnAddtoCard)
        {
            string addToCardProducts="";
            if (isReturnAddtoCard == 'Y')
            {
                for (int ProductNumber = 0; ProductNumber < customer.getAddToCardList().Count; ProductNumber++)
                {
                    addToCardProducts = addToCardProducts + customer.getAddToCardList()[ProductNumber] + ";";
                }
              
            }
            else
            {
                for (int index = 0; index < customer.getPurhasingList().Count; index++)
                {
                    addToCardProducts = addToCardProducts + customer.getPurhasingList()[index].getName() + "[";
                }
            }
            return addToCardProducts;
        }



        //store the line in  the file
        public static void storeLineInfile(string path,string line)
        {

            
        }
       
        //load data from file
         public static void loadData(string path)
        {
            if (File.Exists(path))
            {

               
                string line = null;
                StreamReader file = new StreamReader(path);
                while((line = file.ReadLine()) != null)
                {
                     
                    setData(line);
                }

                file.Close();
            }
          
            
        }
        //load clothes
        




        //set data in file 
        public static void setData(string line)
        {
            string[] data = line.Split(',');
            
            if (data[2].ToLower() == "owner")
            {
              
                PersonDetailCrud.addPerson(new OwnerDetail(data[0], data[1], data[2],data[3],data[4],Convert.ToInt32(data[5]),Convert.ToChar(data[6])));
            }
             if (data[2].ToLower() == "headboy")
            { 
              PersonDetailCrud.addPerson(new HeadBoyDetail(data[0], data[1], data[2],data[3],data[4],data[5],Convert.ToChar(data[6]),Convert.ToChar(data[7])));
            }
            else if (data[2].ToLower() == "customer")
            {
                CustomerDetail cus = new CustomerDetail(data[0], data[1], data[2], Convert.ToInt32(data[3]), Convert.ToInt32(data[4]), data[5], data[6]);
                PersonDetailCrud.addPerson(cus);
             
                
                string[] AddToCardProduct = data[7].Split(';');
                if (data[7] != "")
                {
                    Console.WriteLine($"what is here in data[7]:{data[7]}");
                    Console.ReadKey();
                    setStringList(cus, AddToCardProduct);
                }
                
                                 
            
            }
            else if (data[2].ToLower() == "employee")
            {
                PersonDetailCrud.addPerson(new EmployeeDetail(data[0], data[1], data[2],data[3],data[4],data[5],data[6],Convert.ToChar(data[7])));
            }
        }
        
        public static void setStringList(CustomerDetail customer,string[]convertedArray)
        {
            for(int index=0;index<convertedArray.Length;index++)
            {
                customer.set_AddTocardProduct(convertedArray[index]);
        
            }
        
        
        
        }






       //load cloth data
       public static void loadCloth()
        {


                loadMenClothData();
                load_WoMenClothData();
                load_BabyClothData();
                load_PurchaseClothData();
               
            
        }



        //load cloth  
        public static void loadMenClothData()
        {
           StreamReader file = new StreamReader(pathOf_MenCloth);
           string line;
            while((line=file.ReadLine())!=null)
            {
                
                if (File.Exists(pathOf_MenCloth))
                {
                   
                    splitData(line);

                }
                else
                {
                    MessageBox.Show("File Not Found","warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

              
            }
                file.Close();
        }

        //load purchase cloth
        public static void load_PurchaseClothData()
        {
            string line;
            if (File.Exists(pathOf_PurchaseProduct))
            {
                StreamReader file = new StreamReader(pathOf_PurchaseProduct);
                while ((line = file.ReadLine()) != null)
                {
                    splitPurchaseData(line);

                }
                file.Close();
            }
            
        }

        public static void load_WoMenClothData()
        {
            string line;
            if (File.Exists(pathOf_WoMenCloth))
            {
            StreamReader file = new StreamReader(pathOf_WoMenCloth);
            while((line=file.ReadLine())!=null)
            {
                
                splitWomenData(line);
             
            }
            file.Close();
            }
            





        }
        //load baby data
        public static void load_BabyClothData()
        {
            if (File.Exists(pathOf_BabyCloth))
            {
                StreamReader file = new StreamReader(pathOf_BabyCloth);
                string line;
            while((line=file.ReadLine())!=null)
            {
                    splitBabyData(line);
            }
                file.Close();
            }
            
        }









        //split purchase product data
        public static void splitPurchaseData(string line)
        {
            string[] attribute;
            string[] cloth;
            cloth = line.Split(']');
           
            for (int indxe = 0; indxe < cloth.Length - 1; indxe++)
            {
                ClothDetail clothObject = new ClothDetail();
                attribute = cloth[indxe].Split(',');
               SetCloth_InList(attribute, clothObject,'S');
            }
        }
              



       


        //split men cloth
        public static void splitData(string line)
        {
            string[] attribute;
            string[] cloth;
            cloth = line.Split(']');
            ClothDetail clothObject = new ClothDetail();

            for(int  indxe=0;indxe<cloth.Length - 1;indxe++)
            {
                
                attribute = cloth[indxe].Split(',');
             
                
                SetCloth_InList(attribute, clothObject,'Y');

            }
       
            
        }
        //split women data
        public static void splitWomenData(string line)
        {
            string[] attribute;
            string[] cloth;
            cloth = line.Split(']');
            for (int indxe = 0; indxe < cloth.Length-1; indxe++)
            {
                ClothDetail clothObject = new ClothDetail();
                attribute = cloth[indxe].Split(',');
                SetCloth_InList(attribute, clothObject,'N');
            }
        }
        //split baby data
        public static void splitBabyData(string line)
        {
            string[] attribute;
            string[] cloth;
            cloth = line.Split(']');
            for (int indxe = 0; indxe < cloth.Length-1; indxe++)
            {
                ClothDetail clothObject = new ClothDetail();
                attribute = cloth[indxe].Split(',');
                SetCloth_InList(attribute, clothObject,'B');
            }
        }
        //set  purchase cloth
        public static void SetPurchaseCloth_InList(BrandDetail brand, string[] Mencloths, ClothDetail cloth)
        {
            string[] feedbacks;
          
            brand.setBrandName(Mencloths[0]);
            cloth.setName(Mencloths[1]);
            cloth.setPrice(Mencloths[2]);
            cloth.setSize(Mencloths[3]);
            cloth.setColor(Mencloths[4]);
            cloth.setDisount(Mencloths[5]);
            cloth.FeedbackStatus1 = Convert.ToChar(Mencloths[6]);
            cloth.Number_OfStockAvailable1 = Convert.ToInt32(Mencloths[7]);
            cloth.Number_OfStockSale1 = Convert.ToInt32(Mencloths[8]);
            if (cloth.FeedbackStatus1 == 'Y')
            {
                string line = Mencloths[9];
                feedbacks = line.Split(';');
                setFeedback(feedbacks, cloth);
            }
            brand.setPurchaseClothINList(cloth);
        }
        //set men cloth
        public static void SetCloth_InList(string[] cloths,ClothDetail cloth,char isMen)
        {
            string[] feedbacks;
            BrandDetail brand = BrandDetailCrud.getBrand_object(cloths[0]);
            if (brand!= null)
            {
                cloth.setName(cloths[1]);
                cloth.setPrice(cloths[2]);
                cloth.setSize(cloths[3]);
                cloth.setColor(cloths[4]);
                cloth.setDisount(cloths[5]);
                cloth.FeedbackStatus1 = Convert.ToChar          (cloths[6]);
                cloth.Number_OfStockAvailable1 = Convert.ToInt32(cloths[7]);
                cloth.Number_OfStockSale1 = Convert.ToInt32     (cloths[8]);
                if (cloth.FeedbackStatus1 == 'Y')
                {
                    string line = cloths[9];
                    feedbacks = line.Split(';');
                    setFeedback(feedbacks, cloth);
                }
                if (isMen == 'Y')
                {
                    brand.set_MenClothObject(cloth);
                }
                else if(isMen=='B')
                {
                    brand.setBabyCloth(cloth);
                }
                else if(isMen=='S')
                {
                    brand.set_SALEProduct(cloth);
                }
                else
                {

                    brand.set_WoMenClothObject(cloth);

                }
            }
        }
        public static void SetPurchseCloth_InList(BrandDetail brand, string[] Purchasecloths, ClothDetail cloth)
        {
            string[] feedbacks;
           
            brand.setBrandName(Purchasecloths[0]);
            cloth.setName     (Purchasecloths[1]);
            cloth.setPrice    (Purchasecloths[2]);
            cloth.setSize     (Purchasecloths[3]);
            cloth.setColor    (Purchasecloths[4]);
            cloth.setDisount  (Purchasecloths[5]);
            cloth.FeedbackStatus1 = Convert.ToChar(Purchasecloths[6]);
            cloth.Number_OfStockAvailable1 = Convert.ToInt32(Purchasecloths[7]);
            cloth.Number_OfStockSale1 = Convert.ToInt32(Purchasecloths[8]);
            if (cloth.FeedbackStatus1 == 'Y')
            {
                string line = Purchasecloths[9];
                feedbacks = line.Split(';');
                setFeedback(feedbacks, cloth);
            }
           // brand.set_MenClothObject(cloth);
        }

        //set feedbacks
      static void setFeedback(string[] feedbacks, ClothDetail cloth)
        {
            for (int NumberOfFeedback = 0; NumberOfFeedback < feedbacks.Length; NumberOfFeedback++)
            {
                cloth.setfeedBack(feedbacks[NumberOfFeedback]);
            }
        }
        //set women cloth
        public static void SetWoMenCloth_InList(string[] WoMencloths, ClothDetail cloth)
        {
            BrandDetail brand = BrandDetailCrud.getBrand_object(WoMencloths[0]);
            cloth.setName(WoMencloths[1]);
            cloth.setPrice(WoMencloths[2]);
            cloth.setSize(WoMencloths[3]);
            cloth.setColor(    WoMencloths[4]);
            cloth.setDisount(  WoMencloths[5]);
            brand.set_WoMenClothObject(cloth);
            
        }
        //set baby cloth
        public static void SetBabyCloth_InList( string[] Babycloths, ClothDetail cloth)
        {
            BrandDetail brand=BrandDetailCrud.getBrand_object(Babycloths[0]);
            if (brand != null)
            {
                cloth.setName(Babycloths[1]);
                cloth.setPrice(Babycloths[2]);
                cloth.setSize(Babycloths[3]);
                cloth.setColor(Babycloths[4]);
                cloth.setDisount(Babycloths[5]);
                brand.setBabyCloth(cloth);
            }
            
        }

    }
}
