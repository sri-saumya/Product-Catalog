using System;
using System.Collections.Generic;
using System.Text;

namespace Taazaa_Assignment2
{
    public class Products: Category
    {
        

      
        public string Manufacturer { get; set; }
        public int SellingPrice { get; set; }

        public List<Category> Category;

        public static int ID = 1;
        public int ProductID { get; set; }
        public static int IncrementId()
        {
            return ID++;
        }

        public Products()
        {
            this.Category = new List<Category>();
        }



      
    }
}
