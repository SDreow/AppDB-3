using System;
using System.Linq;

namespace App_DB_3
{
    public class TestLINQ
    {
        public void Test()
        {
            var db = new Model.App3DbContext();
            var productInfo = db.Products.Where(s => s.list_price > 10)
                                          .Select(p => new { p.product_id, p.product_name, p.list_price })
                                          .ToList();
            var productsPrice = db.Products.Where(s => s.list_price > 10).Take(10).ToList();
            foreach (var product in productsPrice)
            {
                Console.WriteLine($"Produkt: {product.product_id} {product.product_name} {product.list_price}");
            }

            db.Dispose();
        }

        public void Test2()
        {
            var db = new Model.App3DbContext();
            var customers = db.Customers.Where(s => s.state == "RU")
                                        .Select(p => new { p.customer_id, p.first_name, p.last_name, p.city })
                                        .ToList();
            var customersCount = db.Customers.Where(s => s.state == "RU").Take(10).Count();
            foreach (var customer in customers)
            {
                Console.WriteLine($"Zákazník: {customer.customer_id} {customer.first_name} {customer.last_name} {customer.city}");
            }

            db.Dispose();
        }
        public void JoinProductsAndCategories()
        {
            var db = new Model.App3DbContext();

            var query = from p in db.Products
                        join c in db.Categories on p.category_id equals c.Category_id
                        select new
                        {
                            ProductName = p.product_name,
                            CategoryName = c.Category_name
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"Produkt: {item.ProductName}, Kategorie: {item.CategoryName}");
            }

            db.Dispose();

            Console.WriteLine("Stiskněte Enter pro ukončení...");
            Console.ReadLine();
        }

    }

}
