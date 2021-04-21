using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taazaa_Assignment2
{
    public class ProductOperations : ProductStore
    {


        //show products
        public static void GetProduct()
        {
            
            Console.WriteLine("ProductID\t\tName\t\tShortCode\t\tDescription");
            Console.WriteLine(" ");
            foreach (var item in products)
            {
                Console.WriteLine(item.ProductID + "\t\t" + item.ProductName + "\t\t" + item.ShortCode + "\t\t\t" + item.Description);
            }
        }

      



        //Add new product
        public static void AddProduct(string pName, string pCode, string desc,int sp)
        {

            CategoryOperation.categories.ForEach((i) =>
            {
                Console.WriteLine(i.Category_ID + i.Category_Name);
            });
            List<Category> productCategories = new List<Category>();
            string choice;
            do
            {
                Console.WriteLine("GIVE CATEGORY ID ");
                int id = Convert.ToInt32(Console.ReadLine());
                var data = CategoryOperation.categories.Single((a) => a.Category_ID == id);
                if (data != null)
                    productCategories.Add(data);
                Console.WriteLine("FOR ADDING MORE CATEGORY : yes , else : no ");
                choice = Console.ReadLine();
            } while (choice == "yes");




            products.Add(new Products
            {

                ProductID = Products.ID,
                ProductName = pName,
                ShortCode = pCode,
                Description = desc,
                SellingPrice = sp,
                Category = productCategories,

            });
            ListOfProducts();
        }

        public static void ListOfProducts()
        {
            Console.WriteLine("ProductID" + "\t" + "Product Name" + "\t\t" + "Product Short Code" + "\t" + "Product Description" + "\t" + "Product Selling Price" + "\t" + "Category" + "\n");
            products.ForEach((i) =>
            {
               
                    string s = "";
                    i.Category.ForEach(c => {
                        s += c.Category_Name + ", ";
                    });

                Console.WriteLine($"{i.ProductID} \t\t {i.ProductName}\t\t\t {i.ShortCode}\t\t\t\t{i.Description}\t\t\t{i.SellingPrice}\t\t{s}");
            });
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
            


         
        }


        public static void DeleteCategory()
        {
            ListOfProducts();
            Console.WriteLine("a. Enter ID");

            char ch2 = Convert.ToChar(Console.ReadLine());
            switch (ch2)
            {
                case 'a':
                    Console.WriteLine("Enter Id Number to delete");
                    int a = Convert.ToInt32(Console.ReadLine());
                    DeleteById(a);
                    break;

            }

        }
        public static void DeleteById(int id)
        {
            bool flag = false;
            products.ForEach((i) =>
            {
                if (i.ProductID == id)
                {
                    ListOfProducts();
                    ProductOperations.GetProduct();
                    products.Remove(i);
                    ListOfProducts();
                    ProductOperations.GetProduct();


                }
                else
                {
                    flag = true;
                }
            });
            if (flag)
            {
                Console.WriteLine("Id not Found");
            }

        
        }

      



    }
}
