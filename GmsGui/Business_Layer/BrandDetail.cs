using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garments_Management_System.Business_Layer
{
   public  class BrandDetail
    {
        private string BrandName;
        private List<ClothDetail> menClothes    =    new List<ClothDetail>();
        private List<ClothDetail> WomenClothes  =    new List<ClothDetail>();
        private List<ClothDetail> BabyClothes   =    new List<ClothDetail>();
        private List<ClothDetail> SALEProduct   =    new List<ClothDetail>();
        
        private double SalePercentage;   
        
        
        public List<ClothDetail> getSaleProductList()
        {
            return SALEProduct;
        }
        public void  setPurchaseClothINList(ClothDetail cloth)
        {
         
            SALEProduct.Add(cloth);
        }
        public List<ClothDetail> getMenList()
        {
            return menClothes;
        }
        public List<ClothDetail> getWomenList()
        {
            return WomenClothes;
        }

        //setter of the class
        public  void setBabyCloth(ClothDetail cloth)
        {
            BabyClothes.Add(cloth);
        }

        public List<ClothDetail> getBabyList()
        {
            return BabyClothes;
        }
        public void setBrandName(string BrandName)
        {
            this.BrandName = BrandName;
        }
        public void setSalePercentage(double SalePercentage)
        {
            this.SalePercentage = SalePercentage;
        }
        //  getter of the class
        public double get_SalePercentage()
        {
            return SalePercentage;
        }
        public string getBrandName()
        {
            return BrandName;
        }
        public int getSaleProductLength()
        {
            return SALEProduct.Count();
        }
        public ClothDetail getSaleProduct(int indexNumber)
        {
            return SALEProduct[indexNumber];
        }
        public int getMenListLength()
        {
            return menClothes.Count();
        }
        public int getWoMenListLength()
        {
            return WomenClothes.Count();
        }
        public int getBabyListLength()
        {
            return BabyClothes.Count();
        }
        public ClothDetail getMenCloth_object()
        {
            ClothDetail cloth = new ClothDetail();
            return cloth;
        }
        public ClothDetail getWoMenCloth_object()
        {
            ClothDetail cloth = new ClothDetail();
            return cloth;
        }
        public ClothDetail getBabyCloth_object()
        {
            ClothDetail cloth = new ClothDetail();
            return cloth;
        }

        //setter of the class
        public void set_MenClothObject(ClothDetail cloth)
        {
            menClothes.Add(cloth);
        }
        public void set_SALEProduct(ClothDetail cloth)
        {
            SALEProduct.Add(cloth);
        }
        public void set_WoMenClothObject(ClothDetail cloth)
        {
            WomenClothes.Add(cloth);
        }
        public void set_ChildClothObject(ClothDetail cloth)
        {
            BabyClothes.Add(cloth);
        }
        public void removeSaleProduct(ClothDetail cloth)
        {
            SALEProduct.Remove(cloth);
        }
        //get list object
        public ClothDetail get_MenListObject(int indexNumber)
        {
         return(menClothes[indexNumber]);
        }
        public ClothDetail get_WoMenListObject(int indexNumber)
        {
            return (WomenClothes[indexNumber]);
        }
        public ClothDetail get_BabyListObject(int indexNumber)
        {
            return (BabyClothes[indexNumber]);
        }

        //search Men cloth  name
        
        public ClothDetail getWoMenCloth_object(string clothName)
        { 
            foreach(ClothDetail cloth in WomenClothes)
            {
                if(cloth.getName()==clothName)
                {
                    return cloth;   
                }
            }
            return null;
        }


        //search WoMen cloth  name
        public ClothDetail getMenCloth_object(string clothName)
        {
            foreach (ClothDetail cloth in menClothes)
            {
                if (cloth.getName() == clothName)
                {
                    return cloth;
                }
            }
            return null;
        }

        //search Baby cloth  name
        public ClothDetail getBabyCloth_object(string clothName)
        {
            foreach (ClothDetail cloth in BabyClothes)
            {
                if (cloth.getName() == clothName)
                {
                    return cloth;
                }
            }
            return null;
        }
    }
}
