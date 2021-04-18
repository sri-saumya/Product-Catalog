using System;
using System.Text;

namespace Taazaa_Assignment2
{
    public class Products
    {
        private int _id { get; set; }
        public string ProductName { get; set; }
        public string Manufacturer { get; set; }
        public string ShortCode { get; set; }

        //public Categories Category { get; }
        public string Description { get; set; }
        public int SellingPrice { get; set; }




        public int ProductID
        {

            set
            {
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

       



         //ProductDetails = (from item in Products select new Products() 
         //       { ProductId = item.ProductID, ProductName = item.ProductName }).ToList() };
        
    }
}
