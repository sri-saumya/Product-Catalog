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
        public List<Products> GetProducts()
        {
            ProductStore p = new ProductStore();
            var a = p.GetProducts();
            return a;
        }


        //Add new product
        public List<Products> AddProduct(Products p)
        {  
            CompleteList.Add(p);
            return CompleteList;
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
