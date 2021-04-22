using System;
using System.Collections.Generic;
using System.Text;

namespace Taazaa_Assignment2
{
    public  class UserInput
    {
        public static void input()
        {

            ProductOperations po = new ProductOperations();
            CategoryOperation co = new CategoryOperation();



            while (true)
            {

                Console.WriteLine("Select : CATEGORY|| Product || Exit : ");
                string choice = Console.ReadLine();
                Console.WriteLine("");


                if (choice.ToUpper() == "PRODUCT")

                {

                    Console.WriteLine("Select : 1.GET all products || 2.SEARCH product by ID|| 3.ADD product || 4.DELETE product || 5.Exit");
                    string Pchoice = Console.ReadLine();
                    Console.WriteLine("");

                    if (Pchoice == "1")
                    {
                        ProductOperations.GetProduct();

                    }
                    else if (Pchoice == "2")
                    {
                        Console.WriteLine("Enter id : ");
                        int id = Int32.Parse(Console.ReadLine());
                        po.SearchById(id);

                    }
                    else if (Pchoice == "3")
                    {
                        Console.WriteLine("Enter name");
                        var cn = Console.ReadLine();
                        Console.WriteLine("Enter short code");
                        var sc = Console.ReadLine();
                        Console.WriteLine("Enter description");
                        var d = Console.ReadLine();
                        Console.WriteLine("Enter selling price");
                        var s = Int32.Parse(Console.ReadLine());
                        ProductOperations.AddProduct(cn, sc, d, s);

                    }
                    else if (Pchoice == "4")
                    {
                        ProductOperations.DeleteProduct();
                        Console.WriteLine("Product Deleted");

                    }
                    else if (Pchoice == "5")
                    {
                        Console.WriteLine("Please try again");

                    }

                }



                if (choice.ToUpper() == "CATEGORY")

                {

                    Console.WriteLine("Select : 1.GET all category || 2.SEARCH category || 3.ADD Category || 4.Delete category || 5.Exit || 6.Back ");
                    string Pchoice = Console.ReadLine();
                    Console.WriteLine("");

                    if (Pchoice == "1")
                    {
                        CategoryOperation.ListOfAllCategories();


                    }
                    else if (Pchoice == "2")
                    {
                        CategoryOperation.SearchCategory();

                    }
                    else if (Pchoice == "3")
                    {
                        Console.WriteLine("Enter name");
                        var cn = Console.ReadLine();
                        Console.WriteLine("Enter short code");
                        var sc = Console.ReadLine();
                        Console.WriteLine("Enter description");
                        var d = Console.ReadLine();
                        CategoryOperation.AddCategory(cn, sc, d);
                    }
                    else if (Pchoice == "4")
                    {
                      
                        
                        CategoryOperation.DeleteCategory();
                        Console.WriteLine("Category Deleted");

                    }
                    else if (Pchoice == "5")
                    {
                        Console.WriteLine("EXIT from Category");
                        
                    }
                    else if (Pchoice == "6")
                    {
                        Console.WriteLine("Please try again");

                    }
                }


            }

        }
    }
}
