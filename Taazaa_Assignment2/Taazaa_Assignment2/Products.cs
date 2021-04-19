using System;
using System.Collections.Generic;
using System.Text;

namespace Taazaa_Assignment2
{
    public class Products
    {
        

        public string ProductName { get; set; }
        public string Manufacturer { get; set; }
        public string ShortCode { get; set; }

       // public List<CategoryOperation> Category;

        public string Description { get; set; }
        public int SellingPrice { get; set; }

        public static int ID = 1;
        public int ProductID { get; set; }
        public static int IncrementId()
        {
            return ID++;
        }




        // public int ProductID
        // {

        //     set
        //     {
        //         this._id = ProductID + 1;
        //     }
        //     get
        //     {
        //         return this._id;
        //     }
        // }

        //public Products()
        // {
        //     ProductID += 1;
        // }
    }
}
