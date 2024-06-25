using App_DB_3.Model;
using DevExpress.Data.ODataLinq.Helpers;
using System;
using System.Data.Entity;
using System.Linq;

namespace App_DB_3
{
    public class TestLINQ
    {
        public void Test()
        {
            using (var db = new App3DbContext()) // tento formát dělá sám dispose
            {
                var productInfo = db.Products.Where(s => s.list_price > 10)
                                              .Select(p => new { p.product_id, p.product_name, p.list_price })
                                              .ToList();
                var productsPrice = db.Products.Where(s => s.list_price > 10).Take(10).ToList();
                foreach (var product in productsPrice)
                {
                    Console.WriteLine($"Produkt: {product.product_id} {product.product_name} {product.list_price}");
                }

            }
        }

        public void Test2()
        {
            var db = new App3DbContext();
            var customers = db.Customers.Where(s => s.state == "RU")
                                        .Select(p => new { p.customer_id, p.first_name, p.last_name, p.city })
                                        .ToList();
            var customersCount = db.Customers.Where(s => s.state == "RU").Take(10).Count();
            foreach (var customer in customers)
            {
                Console.WriteLine($"Zákazník: {customer.customer_id} {customer.first_name} {customer.last_name} {customer.city}");
            }
            Console.WriteLine($"Počet zákazníků: {customersCount}");

            db.Dispose();

        }
        public void InnerJoinProductsAndCategories()
        {
            var db = new App3DbContext();

            var query = from product in db.Products
                        join categories in db.Categories on product.category_id equals categories.Category_id
                        select new
                        {
                            ProductName = product.product_name,
                            CategoryName = categories.Category_name
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"Produkt: {item.ProductName}, Kategorie: {item.CategoryName}");
            }

            db.Dispose();

            Console.WriteLine("Stiskněte Enter pro ukončení...");
            Console.ReadLine();
        }
        public void LeftJoinProductsAndCategories()
        {
            var db = new App3DbContext();

            var query = from product in db.Products
                        join categories in db.Categories on product.category_id equals categories.Category_id into joinedCategories
                        from categories in joinedCategories.DefaultIfEmpty()
                        select new
                        {
                            ProductName = product.product_name,
                            CategoryName = categories.Category_name
                        };


            foreach (var item in query)
            {
                Console.WriteLine($"Produkt: {item.ProductName}, Kategorie: {item.CategoryName}");
            }

            db.Dispose();

            Console.WriteLine("Stiskněte Enter pro ukončení...");
            Console.ReadLine();
        }
        public bool Testuj<T>(int a)
        {
            return true;
        }

        public void Natahovani()
        {
            var db = new App3DbContext();
            var query = from product in db.Products
                        join categories in db.Categories on product.category_id equals categories.Category_id into joinedCategories
                        from categories in joinedCategories.DefaultIfEmpty()
                        select new
                        {
                            ProductName = product.product_name,
                            CategoryName = categories.Category_name
                        };
            var exist = query.Any(); //prioritizované použití 
            var count = query.Count();

            var categorie = db.Categories.FirstOrDefault();
            if (categorie.Products.Any()) // pokud je načteno, lepší pro použití
            { }
            var eksistuji = db.Products.Any(p => p.category_id == 1);

            var produkty2 = db.Products.ToList();
            // produkty2 je čistě natažení Entity produktu

            var produkty = db.Products.Include(p => p.categories).ToList();
            //produkty s Include zařídí že se jedním dotazem natáhnou jak produkty tak jejich categorie

            var produkty3 = db.Products.AsNoTracking().ToList();

            var vybraneKategorie = new int[] { 1, 2, 3, 4 };
            var produkty4 = db.Products.Where(s => vybraneKategorie.Contains(s.category_id));
            var produkty5 = db.Products.Where(s => Testuj<int>(s.category_id));
        }

        public void Groupování()
        {
            using (var db = new App3DbContext())
            {
                var kategorie = from product in db.Products
                                group product by product.categories.Category_name into grpProduct
                                select new { CategoryName = grpProduct.Key, Pocet = grpProduct.Count() };
                foreach (var categorie in kategorie)
                {
                    Console.WriteLine($"Kategorie: {categorie.CategoryName} Pocet produktů: {categorie.Pocet}");
                }
            }
        }
        public void VybratVice()
        {
            using (var db = new App3DbContext())
            {
                db.Database.Log = Console.WriteLine;
                var produkty = db.Categories.Where(s => s.Category_name.StartsWith("A")).SelectMany(s => s.Products).ToList();
                var produkty2 = db.Products.Where(p => p.categories.Category_name.StartsWith("A")).Select(s => s).ToList();

            }
        }
    }
}
