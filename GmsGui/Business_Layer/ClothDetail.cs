using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garments_Management_System.Business_Layer
{
   public  class ClothDetail
    {
        private string Name;
        private string Color;
        private string Price;
        private string Size;

        private char FeedbackStatus;
        private string DiscountedPrice;
        private List<string> feedBackList=new List<string>();
        private int Number_OfStockAvailable;
        private int Number_OfStockSale;

        public int Number_OfStockAvailable1 { get => Number_OfStockAvailable; set => Number_OfStockAvailable = value; }
        public int Number_OfStockSale1 { get => Number_OfStockSale; set => Number_OfStockSale = value; }
        public char FeedbackStatus1 { get => FeedbackStatus; set => FeedbackStatus = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Color1 { get => Color; set => Color = value; }
        public string Price1 { get => Price; set => Price = value; }
        public string Size1 { get => Size; set => Size = value; }

        public ClothDetail(string  Name, string Price, string Size, string Color,string DiscountedPrice, char FeedbackStatus,int Number_OfStockAvailable,int Number_OfStockSale)
        {
            this.Name = Name;
            this.Color = Color;
            this.Price = Price;
            this.Size = Size;
            this.FeedbackStatus = FeedbackStatus;
            this.Number_OfStockAvailable = Number_OfStockAvailable;
            this.Number_OfStockSale = Number_OfStockSale;
            this.DiscountedPrice = DiscountedPrice;
        }
        public ClothDetail()
        {

        }
        //setter of the class
        public void setName(string Name)
        {
            this.Name = Name;
        }
        public void setDisount(string DiscountedPrice)
        {
            this.DiscountedPrice = DiscountedPrice;
        }

        public void setColor(string Color)
        {
            this.Color = Color;
        }
        public void setPrice(string Price)
        {
            this.Price = Price;
        }
        public void setSize(string Size)
        {
            this.Size = Size;
        }
        public  void setfeedBack(string feedBack)
        {
            feedBackList.Add(feedBack);
        }
        public int getFeedBackLength()
        {
            return feedBackList.Count();

        }


        //getter of the class
        public string  getName()
        {
            return Name;
        }
        public string getDiscount()
        {
            return DiscountedPrice;
        }
        public string  getColor()
        {
            return Color;
        }
        public string  getPrice()
        {
          return Price;
        }
        public string  getSize()
        {
           return Size;
        }
        public string getfeedBack(int IndexNumber)
        {
           return(feedBackList[IndexNumber]);
        }
    }
}
