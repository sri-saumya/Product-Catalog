using System;

namespace Taazaa_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductOperations po = new ProductOperations();
            ProductStore ps = new ProductStore();

            Catalogagain:
            Console.WriteLine("Select :  || Product || Exit : ");
            string choice = Console.ReadLine();
            Console.WriteLine("");


            if (choice.ToUpper() == "PRODUCT" )

            {
                productagain:
                Console.WriteLine("Select : 1.GET all products || 2.SEARCH product by ID|| 3.ADD product || 4.Exit || 5.Back");
                string Pchoice = Console.ReadLine();
                Console.WriteLine("");

                if(Pchoice == "1")
                {
                    ps.GetProducts();
                    goto productagain;
                }
                else if (Pchoice == "2")
                {
                    po.SearchById(1);
                    goto productagain;
                }
                else if (Pchoice == "3")
                {
                    po.AddProduct();
                    goto productagain;
                }
                else if (Pchoice == "4")
                {
                    Console.WriteLine("EXIT");
                    goto Catalogagain;

                }
                else if(Pchoice == "5")
                {
                    Console.WriteLine("Please try again");
                    goto productagain;
                }
         
            }

            if (choice.ToUpper() == "CATEGORY")

            {
                Console.WriteLine("Select : 1.GET all category || 2.SEARCH category by ID|| 3.ADD Category : ");
                string Pchoice = Console.ReadLine();
                Console.WriteLine("");

                if (Pchoice == "1")
                {
                    ps.GetProducts();
                }
                if (Pchoice == "2")
                {
                    po.SearchById(1);
                }
                if (Pchoice == "3")
                {
                    po.AddProduct();
                }
            }


        }
    }
}
