using System;
using System.Collections.Generic;
using System.Text;

namespace Taazaa_Assignment2
{
    
        public class CategoryOperation : CategoryStore

        {

            public static void CategoryOperationMenu()
            {

                char ch1 = Convert.ToChar(Console.ReadLine());

              
            }

            public static void AddCategory(string categoryName, string shortCode, string desc)
            {

                categories.Add(new Category
                {

                    Category_ID = Category.IncreamentID(),
                    Category_Name = categoryName,
                    CategoryShortCode = shortCode,
                    CategoryDescription = desc

                });
                ListOfAllCategories();
            }
            public static void ListOfAllCategories()
            {
                Console.WriteLine("Category Id" + "\t" + "Category Name" + "\t\t" + "Category Short Code" + "\t" + "Category Description\n");
                categories.ForEach((i) =>
                {
                    Console.WriteLine($"{i.Category_ID} \t\t {i.Category_Name}\t\t {i.CategoryShortCode}\t\t{i.CategoryDescription}");
                });
            }

            public static void DeleteCategory()
            {
                ListOfAllCategories();
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
                categories.ForEach((i) =>
                {
                    if (i.Category_ID == id)
                    {
                        categories.Remove(i);
                        ListOfAllCategories();
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
    

            public static void SearchCategory()
            {
                Console.WriteLine("a : Give ID");
                Console.WriteLine("b : Give Name");
                Console.WriteLine("c : Give Short Code");
                char ch3 = Convert.ToChar(Console.ReadLine());
                switch (ch3)
                {
                    case 'a':
                        Console.WriteLine("Enter Id : ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        SearchByID(a);
                        break;
                    case 'b':
                        Console.WriteLine("Enter Name : ");
                        var name = Console.ReadLine();
                        SearchByName(name);
                        break;
                    case 'c':
                        Console.WriteLine("Enter Short Code : ");
                        var sc = Console.ReadLine();
                        SearchByShortCode(sc);
                        break;
                }

            }
            public static void SearchByID(int id)
            {


                var d = categories.FindAll((i) => i.Category_ID == id);
                if (d.Count > 0)
                {
                    d.ForEach((i) =>
                    {
                        Console.WriteLine($"{i.Category_ID} \t\t {i.Category_Name}\t\t{i.CategoryShortCode}\t\t{i.CategoryDescription}");
                    });
                }
                else
                {
                    Console.WriteLine("InValid Id");
                }

            }
            public static void SearchByName(string name)
            {
                var d = categories.FindAll((i) => i.Category_Name == name);
                if (d.Count > 0)
                {
                    d.ForEach((i) =>
                    {
                        Console.WriteLine($"{i.Category_ID} \t\t {i.Category_Name}\t\t{i.CategoryShortCode}\t\t{i.CategoryDescription}");
                    });
                }
                else
                {
                    Console.WriteLine("Invalid Name");
                }

            }
            public static void SearchByShortCode(string shortCode)
            {
                var d = categories.FindAll((i) => i.CategoryShortCode == shortCode);
                if (d.Count > 0)
                {
                    d.ForEach((i) =>
                    {
                        Console.WriteLine($"{i.Category_ID} \t\t {i.Category_Name}\t\t{i.CategoryShortCode}\t\t{i.CategoryDescription}");
                    });
                }
                else
                {
                    Console.WriteLine("Invalid Short Code ");
                }
            }
        }
    
}
