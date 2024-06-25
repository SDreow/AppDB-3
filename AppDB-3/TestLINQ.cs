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
            // Vytvoření instance DbContext pro přístup k databázi
            var db = new App3DbContext();

            // Vytvoření LINQ dotazu pro provedení left join mezi produkty a kategoriemi
            // Pokud produkt nemá přiřazenou kategorii, bude CategoryName nastaveno na null
            var query = from product in db.Products
                        join categories in db.Categories on product.category_id equals categories.Category_id into joinedCategories
                        from categories in joinedCategories.DefaultIfEmpty()
                        select new
                        {
                            ProductName = product.product_name,
                            CategoryName = categories != null ? categories.Category_name : "Bez kategorie"
                        };

            // Iterace přes výsledky dotazu a výpis informací o produktu a jeho kategorii
            foreach (var item in query)
            {
                Console.WriteLine($"Produkt: {item.ProductName}, Kategorie: {item.CategoryName}");
            }

            // Uvolnění zdrojů DbContext po dokončení práce s databází
            db.Dispose();

            // Výzva pro uživatele k ukončení aplikace stisknutím klávesy Enter
            Console.WriteLine("Stiskněte Enter pro ukončení...");
            Console.ReadLine();
        }
        public bool Testuj<T>(int a)
        {
            return true;
        }

        public void Natahovani()
        {
            // Vytvoření instance DbContext pro přístup k databázi
            var db = new App3DbContext();

            // Vytvoření LINQ dotazu s left join mezi produkty a kategoriemi
            var query = from product in db.Products
                        join categories in db.Categories on product.category_id equals categories.Category_id into joinedCategories
                        from categories in joinedCategories.DefaultIfEmpty()
                        select new
                        {
                            ProductName = product.product_name,
                            CategoryName = categories.Category_name
                        };

            // Kontrola, zda existuje alespoň jeden produkt v dotazu
            var exist = query.Any(); // Prioritizované použití

            // Získání celkového počtu produktů v dotazu
            var count = query.Count();

            // Získání první kategorie; pokud existuje, kontrola, zda má přiřazené produkty
            var categorie = db.Categories.FirstOrDefault();
            if (categorie.Products.Any()) // Pokud je načteno, lepší pro použití
            { }

            // Kontrola, zda existují produkty v kategorii s ID 1
            var eksistuji = db.Products.Any(p => p.category_id == 1);

            // Načtení všech produktů bez jakékoliv filtrace nebo join operace
            var produkty2 = db.Products.ToList(); // Produkty2 je čistě natažení Entity produktu

            // Načtení produktů s přednačtením (eager loading) jejich kategorií
            var produkty = db.Products.Include(p => p.categories).ToList(); // Produkty s Include zařídí, že se jedním dotazem natáhnou jak produkty, tak jejich kategorie

            // Načtení produktů bez sledování změn (vhodné pro čtení dat)
            var produkty3 = db.Products.AsNoTracking().ToList();

            // Filtrace produktů podle vybraných kategorií
            var vybraneKategorie = new int[] { 1, 2, 3, 4 };
            var produkty4 = db.Products.Where(s => vybraneKategorie.Contains(s.category_id));

            // Použití generické metody pro filtraci produktů (příklad použití generické metody v LINQ dotazu)
            var produkty5 = db.Products.Where(s => Testuj<int>(s.category_id));
        }

        public void Groupování()
        {
            // Vytvoření instance DbContext pro přístup k databázi
            using (var db = new App3DbContext())
            {
                // Vytvoření LINQ dotazu pro seskupení produktů podle názvu kategorie
                // a výpočet počtu produktů v každé kategorii
                var kategorie = from product in db.Products
                                group product by product.categories.Category_name into grpProduct
                                select new { CategoryName = grpProduct.Key, Pocet = grpProduct.Count() };

                // Iterace přes výsledky dotazu a výpis názvu kategorie a počtu produktů v ní
                foreach (var categorie in kategorie)
                {
                    Console.WriteLine($"Kategorie: {categorie.CategoryName} Pocet produktů: {categorie.Pocet}");
                }
            }
        }
        public void VybratVice()
        {
            using (var db = new App3DbContext()) // Vytvoření instance kontextu databáze
            {
                db.Database.Log = Console.WriteLine; // Nastavení logování SQL dotazů do konzole pro ladění

                // Získání všech produktů, které patří do kategorií začínajících na "A", pomocí navigační vlastnosti `Products` v `Categories`
                var produkty = db.Categories.Where(s => s.Category_name.StartsWith("A")) // Filtr kategorií podle názvu
                                             .SelectMany(s => s.Products) // Převedení kolekce kategorií na kolekci produktů
                                             .ToList(); // Vykonání dotazu a konverze výsledku na seznam

                // Alternativní způsob, jak získat všechny produkty, které patří do kategorií začínajících na "A", přímo z `Products`
                var produkty2 = db.Products.Where(p => p.categories.Category_name.StartsWith("A")) // Filtr produktů podle názvu kategorie
                                           .Select(s => s) // Výběr produktů
                                           .ToList(); // Vykonání dotazu a konverze výsledku na seznam
            }
        }
    }
}
