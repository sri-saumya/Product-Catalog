using System;

namespace Taazaa_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            Start1:
            Console.WriteLine("Categories here!");
            Categories C1 = new Categories();
            C1.ID = 101;
            C1.Name = "RIYA";
            C1.ShortCode = "ABC";
            Console.WriteLine("id = {0}  Name = {1}  Code = {2}", C1.ID, C1.Name, C1.ShortCode);
            Console.WriteLine("");



            Start2:
            Console.WriteLine("Products here!");
            Products p = new Products();
            Console.WriteLine("");


            Start3:
            Console.WriteLine("Select Category || Product || Exit : ");
            string choice = Console.ReadLine();
            Console.WriteLine("");


            switch (choice.ToUpper())
            {
                case "CATEGORY":
                    goto Start1;
                    
                case "PRODUCT":
                    goto Start2;

                case "Exit":
                    Console.WriteLine("Thankyou !!");
                    break;

                default:
                    Console.WriteLine("Your choice {0} is not valid.Please try again!", choice);
                    goto Start3;

            }



        }
    }
}
