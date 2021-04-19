using System;
using System.Collections.Generic;
using System.Text;

namespace Taazaa_Assignment2
{
    public class ProductOperations : ProductStore
    {

        public static List<Products> products = new List<Products>()
            {
            new Products()
            {
                    ProductID=Products.IncrementId(),
                    ProductName = "Laptop",
                    Manufacturer = "Lenovo",
                    ShortCode = "qwe",
                    Description = "RAM : 8gb, CORE : I3",
                    SellingPrice = 50000



            },
            new Products()
            {
                   ProductID=Products.IncrementId(),
                    ProductName = "Keyboard",
                    Manufacturer = "Dell",
                    ShortCode = "rty",
                    Description = " Portable",
                    SellingPrice = 2000


            },
            new Products()
            {
                    ProductID=Products.IncrementId(),
                    ProductName = "Mouse",
                    Manufacturer = "Dell",
                    ShortCode = "hjk",
                    Description = " Portable",
                    SellingPrice = 20908


            }
        };

        

        //public static List<Products> CompleteList = new List<Products>();
        //public Products res;




        //show products
        public void GetProduct()
        {
            
            Console.WriteLine("ProductID\t\tName\t\tShortCode\t\tDescription");
            Console.WriteLine(" ");
            foreach (var item in products)
            {
                Console.WriteLine(item.ProductID + "\t\t" + item.ProductName + "\t\t" + item.ShortCode + "\t\t\t" + item.Description);
            }
        }





        //Add new product
        public void AddProduct()
        {
            //public static List<Products> CompleteList = new List<Products>();

            Console.WriteLine("ID  {0} ",ProductID);
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
        public void SearchById(int id)
        {
      
                var d = products.FindAll((i) => i.ProductID == id);
                if (d.Count > 0)
                {
                    d.ForEach((i) =>
                    {
                        Console.WriteLine($"{i.ProductID} \t\t {i.ProductName}\t\t{i.Manufacturer}\t\t{i.Description}\t\t{i.SellingPrice}");
                    });
                }
                else
                {
                    Console.WriteLine("Id Not Found");
                }
            

            //ProductStore prod = new ProductStore();
            //var byid = this.ProductList.Find(res => res.ProductID == id);
            //Console.WriteLine(byid);


         
        }

        
    }
}
