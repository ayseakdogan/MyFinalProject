﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // ProductTest();
            // CategoryTest();
            ProductTest();

        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var productDetail in result.Data)
                {
                    Console.WriteLine(productDetail.ProductName + "/" + productDetail.CategoryName + "/" + productDetail.UnitsInstock);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        //private static void ProductTest()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());
        //    foreach (var product in productManager.GetAllByCategoryId(2))
        //    {
        //        Console.WriteLine(product.ProductName);
        //    }
        //    foreach (var product in productManager.GetByUnitPrice(90, 100))
        //    {
        //        Console.WriteLine(product.ProductName);
        //    }
        //}
    }
}
