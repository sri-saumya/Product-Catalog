﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Taazaa_Assignment2
{
    ////class CategoriesOperations
    ////{
        public class CategoryOperation
        {
            public static List<Category> categories = new List<Category>()
            {
            new Category()
            {
                Category_ID = Category.GenerateCategoryId(),
                Category_Name="Grocery",
                CategoryShortCode="101",
                CategoryDescription="Well Satisfied"
            },
            new Category
            {
              Category_ID = Category.GenerateCategoryId(),
              Category_Name="Dairy",
              CategoryShortCode="102",
              CategoryDescription="Milk Products are here"
            },
            new Category
            {
                Category_ID = Category.GenerateCategoryId(),
                Category_Name="Automobiles",
                CategoryShortCode="103",
                CategoryDescription="2 wheeler"
            }

        };
            public static void CategoryOperationMenu()
            {

                char ch1 = Convert.ToChar(Console.ReadLine());

              
            }

            public static void AddCategory(string categoryName, string shortCode, string desc)
            {

                categories.Add(new Category
                {

                    Category_ID = Category.GenerateCategoryId(),
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
                Console.WriteLine("a. Delete By ID");
                Console.WriteLine("b. Delete By Short Code");
                char ch2 = Convert.ToChar(Console.ReadLine());
                switch (ch2)
                {
                    case 'a':
                        Console.WriteLine("Enter Id Number to delete");
                        int a = Convert.ToInt32(Console.ReadLine());
                        DeleteById(a);
                        break;
                    case 'b':
                        Console.WriteLine("Enter Short Code of Category to Delete");
                        var sc = Console.ReadLine();
                        DeleteByShortCode(sc);
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
            public static void DeleteByShortCode(string shortCode)
            {
                bool flag = false;
                categories.ForEach((i) =>
                {
                    if (i.CategoryShortCode == shortCode)
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
                    Console.WriteLine("Short Code not Found");
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


                var data = categories.FindAll((i) => i.Category_ID == id);
                if (data.Count > 0)
                {
                    data.ForEach((i) =>
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
                var data = categories.FindAll((i) => i.Category_Name == name);
                if (data.Count > 0)
                {
                    data.ForEach((i) =>
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
                var data = categories.FindAll((i) => i.CategoryShortCode == shortCode);
                if (data.Count > 0)
                {
                    data.ForEach((i) =>
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
    //}
}
