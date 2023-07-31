using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garments_Management_System.Business_Layer;
using GmsGui.Data_Layer;
using GmsGui.Inputform;
using GmsGui.customerFrmFolder;
using GmsGui;
using System.Windows.Forms;

namespace Garments_Management_System.Data_Layer
{
    public class BrandDetailCrud
    {
        private static List<BrandDetail> BrandsList = new List<BrandDetail>();

        public static List<ClothDetail> clothDetailGrid = new List<ClothDetail>();

        //get brand list
        public static List<BrandDetail> GetBrandsList()
        {
            return BrandsList;
        }
        //get brand object by index
        public static BrandDetail get_BrandObject_ByIndex(int indexNumber)
        {
            return BrandsList[indexNumber];
        }
        

        public static void removeLastBrand()
        {
            BrandsList.RemoveAt(BrandsList.Count - 1);
        }


        //add brand object in list
        public static void addBrand_Object_In_list(BrandDetail brand)
        {
            BrandsList.Add(brand);
        }
        
        //get object of  brand by name
        public static BrandDetail getBrand_object(string brandName)
        {
            foreach(BrandDetail brand in BrandsList)
            {
                if(brand.getBrandName()==brandName)
                {
                    return brand;
                }
            }
             return null;
        }


        

        //get brand object by input
        public static BrandDetail getBrandObject_byInput()
        {
            
            string brand_Name = InputFrm.brandName;
            BrandDetail brand = getBrand_object(brand_Name);
            return brand;
        }



        //remove the objects in list
        public static void remove_Object(BrandDetail brand)
        {
            BrandsList.Remove(brand);
        }

       

        //show brand Name
        public static void show_Brand_Name()
        {
            foreach(BrandDetail brand in BrandsList)
            {
                Console.WriteLine($"{brand.getBrandName()}");
            }
                Console.ReadKey();
        }
        //get top Men disocuntet product
       
        public static double  getMost_Discounted_MenProduct(BrandDetail bra,char IsCalculteSale)
        {
             double discount=0.0;
             for(int indexNumber=0;indexNumber<bra.getMenListLength();indexNumber++)
             {
                ClothDetail cloth = bra.get_MenListObject(indexNumber);
                if (IsCalculteSale == 'Y')
                {
                    if (discount < Convert.ToDouble(cloth.getDiscount()))
                    {
                        discount = Convert.ToDouble(cloth.getDiscount());
                    }
                }
                else if(IsCalculteSale=='N')
                {
                    if (discount < Convert.ToDouble(cloth.Number_OfStockSale1))
                    {
                        discount = Convert.ToDouble(cloth.Number_OfStockSale1);
                    }
                }
                
             }
             return discount;
        }

        internal static BrandDetail getBrand_object(object brandName)
        {
            throw new NotImplementedException();
        }

        //get top WoMen disocuntet product

        public static double getMost_Discounted_WoMenProduct(BrandDetail bra, char IsCalculteSale)
        {
            double discount = 0.0;
            for (int indexNumber = 0; indexNumber < bra.getWoMenListLength(); indexNumber++)
            {
                ClothDetail cloth = bra.get_WoMenListObject(indexNumber);
                if (IsCalculteSale == 'Y')
                {
                    if (discount < Convert.ToDouble(cloth.getDiscount()))
                    {
                        discount = Convert.ToDouble(cloth.getDiscount());
                    }
                }
                else
                {
                    if (discount < Convert.ToDouble(cloth.Number_OfStockSale1))
                    {
                        discount = Convert.ToDouble(cloth.Number_OfStockSale1);
                    }
                }
            }
            return discount;
        }
        //get top baby disocuntet product

        public static double getMost_Discounted_BabyProduct(BrandDetail bra,char IsCalculateSale )
        {
            double discount = 0.0;
            for (int indexNumber = 0; indexNumber < bra.getBabyListLength(); indexNumber++)
            {
                ClothDetail cloth = bra.get_BabyListObject(indexNumber);
                if (IsCalculateSale == 'Y')
                {
                    if (discount < Convert.ToDouble(cloth.getDiscount()))
                    {
                        discount = Convert.ToDouble(cloth.getDiscount());
                    }
                }
                else
                {
                    if (discount < Convert.ToDouble(cloth.Number_OfStockSale1))
                    {
                        discount = Convert.ToDouble(cloth.Number_OfStockSale1);
                    }
                }
            }
            return discount;
        }
        //get most dicounted object
        public static ClothDetail get_TopDiscounted_Men_ClothObject(BrandDetail brand,double discount,char isCalculateDiscount)
        {
            for(int indexNumber=0;indexNumber<brand.getMenListLength();indexNumber++)
            {
                ClothDetail cloth = brand.get_MenListObject(indexNumber);
                if (isCalculateDiscount == 'Y')
                {
                    if (Convert.ToDouble(cloth.getDiscount()) == discount)
                    {
                        return cloth;
                    }
                }
                else
                {
                    if (Convert.ToDouble(cloth.Number_OfStockSale1) == discount)
                    {
                        return cloth;
                    }
                }
                
            }
            return null;
        }
        //get most women dicounted object
        public static ClothDetail get_TopDiscounted_WoMen_ClothObject(BrandDetail brand, double discount, char isCalculateDiscount)
        {
            for (int indexNumber = 0; indexNumber < brand.getWoMenListLength(); indexNumber++)
            {
                ClothDetail cloth = brand.get_WoMenListObject(indexNumber);
                if (isCalculateDiscount == 'Y')
                {
                    if (Convert.ToDouble(cloth.getDiscount()) == discount)
                    {
                        return cloth;
                    }
                }
                else
                {
                    if (Convert.ToDouble(cloth.Number_OfStockSale1) == discount)
                    {
                        return cloth;
                    }
                }
            }
            return null;
        }
        //get most Baby dicounted object
        public static ClothDetail get_TopDiscounted_Baby_ClothObject(BrandDetail brand, double discount,char isCalculateDiscount)
        {
            for (int indexNumber = 0; indexNumber < brand.getBabyListLength(); indexNumber++)
            {
                ClothDetail cloth = brand.get_BabyListObject(indexNumber);
                if (isCalculateDiscount == 'Y')
                {
                    if (Convert.ToDouble(cloth.getDiscount()) == discount)
                    {
                        return cloth;
                    }
                }
                else
                {
                    if (Convert.ToDouble(cloth.Number_OfStockSale1) == discount)
                    {
                        return cloth;
                    }
                }
            }
            return null;
        }
        //take input and get brand object
        public static BrandDetail get_object()
        {

            string Brand_Name = "";
            BrandDetail BrandObject = getBrand_object(Brand_Name);
            return BrandObject;
        }
        public static BrandDetail get_object_ofBrand(string Brand_Name)
        {


            BrandDetail BrandObject = getBrand_object(Brand_Name);
            return BrandObject;
        }


            //get object of cloth by its name
            public static ClothDetail get_Object_of_cloth_by_itsName(string  cloth,BrandDetail Brand)
        {   
            ClothDetail returnClothObject=new ClothDetail();
            
            returnClothObject= Brand.getMenCloth_object(cloth);
            
            if (returnClothObject == null)
            {
                returnClothObject = Brand.getWoMenCloth_object(cloth);
                if (returnClothObject == null)
                {
                    returnClothObject = Brand.getBabyCloth_object(cloth);
                    if (cloth == null)
                    {
                        return null;
                    }
                    else
                    {
                        return returnClothObject;
                    }
                }
                else
                {
                    return returnClothObject;
                }
            }
            else
            {
                return returnClothObject;
            }

        }
        //set totalBudget
        public static void set_totalBudget(CustomerDetail current_Customer,ClothDetail cloth)
        {
            int balance = current_Customer.CardBalance1;
            balance = balance - Convert.ToInt32(cloth.getPrice());
            int TotalBudget = OwnerCrud.getOwner().getTotalBudget();
            TotalBudget = TotalBudget + Convert.ToInt32(cloth.getPrice());
            OwnerCrud.getOwner().setTotalBudget(TotalBudget);
        }

        //count high men feedback 

        public static int get_high_MenCloth_feedback(BrandDetail brand)
        {
            ClothDetail cloth = new ClothDetail();
            int High_FeedBack=0;
            if (brand.getMenListLength() != 0)
            {
                for (int indexNumber = 0; indexNumber < brand.getMenListLength(); indexNumber++)
                {
                    cloth = brand.get_MenListObject(indexNumber);
                    int NumberOf_Feedback = cloth.getFeedBackLength();
                    if (High_FeedBack < NumberOf_Feedback)
                    {
                        High_FeedBack = NumberOf_Feedback;

                    }
                }
            }
            else
            {
                MessageBox.Show("WRONG INPUT","war",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return High_FeedBack;
        }
        
        //count high Women feedback 

        public static int get_high_WoMenCloth_feedback(BrandDetail brand)
        {
            ClothDetail cloth = new ClothDetail();
            int High_FeedBack = 0;
            for (int indexNumber = 0; indexNumber < brand.getWoMenListLength(); indexNumber++)
            {
                cloth = brand.get_WoMenListObject(indexNumber);
                int NumberOf_Feedback = cloth.getFeedBackLength();
                if (High_FeedBack < NumberOf_Feedback)
                {
                    High_FeedBack = NumberOf_Feedback;

                }
            }

            return High_FeedBack;
        }
        //count high Baby feedback 

        public static int get_high_BabyCloth_feedback(BrandDetail brand)
        {
            ClothDetail cloth = new ClothDetail();
            int High_FeedBack = 0;
            for (int indexNumber = 0; indexNumber < brand.getBabyListLength(); indexNumber++)
            {
                cloth = brand.get_BabyListObject(indexNumber);
                int NumberOf_Feedback = cloth.getFeedBackLength();
                if (High_FeedBack < NumberOf_Feedback)
                {
                    High_FeedBack = NumberOf_Feedback;

                }
            }

            return High_FeedBack;
        }


        //get cloth object by feedback
        public static ClothDetail Get_cloth_object_by_highFeedback(BrandDetail brand,int highFeedback)
        {
            for(int indexNumber=0;indexNumber<brand.getMenListLength();indexNumber++)
            {
                ClothDetail cloth = brand.get_MenListObject(indexNumber);
                if(highFeedback==cloth.getFeedBackLength())
                {
                    return cloth;
                }
            }
            return null;
        }
       //set dicounted price to all men cloths of the specific brands
        public static void setDicountedPrice_forMen(BrandDetail brand,char isRemoveSale)
        {
            for(int indexNumber=0;indexNumber<brand.getMenListLength();indexNumber++)
            {
                ClothDetail cloth = brand.get_MenListObject(indexNumber);
                setDiscountedDetail(cloth, brand,isRemoveSale);   
            }
        }
        //set dicounted price to all women cloths of the specific brands
        public static void setDicountedPrice_forWomen(BrandDetail brand,char isRemoveSale)
        {
            for (int indexNumber = 0; indexNumber < brand.getWoMenListLength(); indexNumber++)
            {
                ClothDetail cloth = brand.get_WoMenListObject(indexNumber);
                setDiscountedDetail(cloth, brand,isRemoveSale);
            }
        }
        //set dicounted price to all baby cloths of the specific brands
        public static void setDicountedPrice_forBaby(BrandDetail brand,char isRemoveSale)
        {
            for (int indexNumber = 0; indexNumber < brand.getBabyListLength(); indexNumber++)
            {
                ClothDetail cloth = brand.get_BabyListObject(indexNumber);
                setDiscountedDetail(cloth, brand,isRemoveSale);
            }
        }
        //calculte discount
        public static double calculateDiscount(string totalPrice,double dicountPercentage)
        {
            double discountedPrice=(Convert.ToDouble(totalPrice) *dicountPercentage) / 100;
            return discountedPrice;
        }
        //set Discounted Detail
        public static void setDiscountedDetail(ClothDetail cloth,BrandDetail brand,char isRemoveSale)
        {
            double DiscoutedPrice = calculateDiscount(cloth.getPrice(), brand.get_SalePercentage());
            double originalPrice = Convert.ToDouble(cloth.getPrice());
            if (isRemoveSale == 'Y')
            {
                originalPrice = originalPrice + DiscoutedPrice;
                DiscoutedPrice = 0.0;
            }
            else
            {
                originalPrice = originalPrice - DiscoutedPrice;
            }
            cloth.setPrice(Convert.ToString(originalPrice));
            cloth.setDisount(Convert.ToString(DiscoutedPrice));
        }
        //call discouted product
        public static void setDiscountedProdut(BrandDetail Check_discounted_brand,char IsCalculateDiscount)
        {
            double Men_Top_discount =  getMost_Discounted_MenProduct(Check_discounted_brand,  IsCalculateDiscount);
            double WoMen_Top_discount =getMost_Discounted_WoMenProduct(Check_discounted_brand,IsCalculateDiscount);
            double Baby_Top_discount = getMost_Discounted_BabyProduct(Check_discounted_brand, IsCalculateDiscount);



            ClothDetail Top_Discounted_Men_object =  get_TopDiscounted_Men_ClothObject(Check_discounted_brand, Men_Top_discount,IsCalculateDiscount);
            ClothDetail Top_Discounted_WoMen_object =get_TopDiscounted_WoMen_ClothObject(Check_discounted_brand, WoMen_Top_discount,IsCalculateDiscount);
            ClothDetail Top_Discounted_Baby_object = get_TopDiscounted_Baby_ClothObject(Check_discounted_brand, Baby_Top_discount,IsCalculateDiscount);
            if (Top_Discounted_Men_object != null)
            {
                clothDetailGrid.Add(Top_Discounted_Men_object);
            }
            else
            {
                MessageBox.Show("MEN LIST IS  EMPTY","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (Top_Discounted_WoMen_object != null)
            {
                clothDetailGrid.Add(Top_Discounted_Baby_object);
            }
            else
            {
                MessageBox.Show("WOMEN LIST IS  EMPTY", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Top_Discounted_Baby_object != null)
            {
                clothDetailGrid.Add(Top_Discounted_WoMen_object);
            }
            else
            {
                MessageBox.Show("BABY LIST IS  EMPTY", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        //get cloth object 
        public static ClothDetail get_cloth_object_byInput()
        {
           
            
            ClothDetail cloth = new ClothDetail();
            
            Form infrm=new InputFrm();
            infrm.ShowDialog();
            string brand_name_for_change_rate = InputFrm.brandName;
            BrandDetail ChangeBrand =getBrand_object(brand_name_for_change_rate);
            if (ChangeBrand != null)
            {
                string clothName_for_change_Rate = InputFrm.ClothName;
                cloth = get_Object_of_cloth_by_itsName(clothName_for_change_Rate, ChangeBrand);
                return cloth;
            }
            else
            {
                MessageBox.Show("WRONG INPUT", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
