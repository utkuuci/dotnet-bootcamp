using System;
using Business;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Prod();
            Cat();
            Ord();
        }

        private static void Prod()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var p in productManager.GetAll())
            {
                Console.WriteLine(p.ProductName);
            }
            Console.WriteLine("======================================");
            foreach (var p in productManager.GetAllByCategoryId(6))
            {
                Console.WriteLine(p.ProductName);
            }
            Console.WriteLine("=======================================");
            foreach (var p in productManager.GetByUnitPrice(5, 10))
            {
                Console.WriteLine(p.ProductName);
            }
            Console.WriteLine("=======================================");
        }

        private static void Cat()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var c in categoryManager.GetAll())
            {
                Console.WriteLine(c.CategoryName);
            }
            Console.WriteLine("=======================================");
        }

        private static void Ord()
        {
            OrderManager orderManager = new OrderManager(new EfOrderDal());
            foreach (var o in orderManager.GetAll())
            {
                Console.WriteLine(o.OrderDate);
            }
        }
    }
}
