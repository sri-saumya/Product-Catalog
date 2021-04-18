using System;
using System.Collections.Generic;
using System.Text;

namespace Taazaa_Assignment2
{
    public class Products
    {
        private int _id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string ShortCode { get; set; }

        public Categories Category { get; }
        public string Description { get; set; }
        public int SellingPrice { get;  }




        public int ID
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

        public void print()
        {
            Console.WriteLine("products here!");
        }

        
    }
}
