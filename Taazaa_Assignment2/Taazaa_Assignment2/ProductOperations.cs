using System;
using System.Collections.Generic;
using System.Text;

namespace Taazaa_Assignment2
{
    public class ProductOperations : ProductStore
    {
        public static List<Products> CompleteList = new List<Products>();
        public Products res;


        //show products
        public void GetProduct()
        {
            ProductStore p = new ProductStore();
            Console.WriteLine( p.ProductID);
            var a = p.GetProducts();
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }

        }


        //Add new product
        public void AddProduct()
        {
            Console.WriteLine("ID",ProductID);
            Console.WriteLine("Enter Name");
            string n = Console.ReadLine();
            Console.WriteLine("Enter Manufacturer");
            string m = Console.ReadLine();
            Console.WriteLine("Enter ShortCode");
            string s = Console.ReadLine();
            Console.WriteLine("Enter Description");
            string d = Console.ReadLine();
            Console.WriteLine("Enter SellingPrice");
            string sp = Console.ReadLine();
            Console.WriteLine("Added Successfully!!");
            Console.WriteLine(" NAME : {0}, Manufacturer : {1} ,ShortCode : {2},Description : {3} ,SellingPrice : {4}", n,m,s,d,sp);
            
        }


        //Search new Product
        public Products SearchById(int id)
        {

            Products res = new Products();
            foreach (Products i in CompleteList)

            {
                if (i.ProductID == id)
                {
                    res = i;

                }
            }
            return res;
        }
    }
}
