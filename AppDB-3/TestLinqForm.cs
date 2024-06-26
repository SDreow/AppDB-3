using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using DevExpress.Skins;
namespace App_DB_3
{
    // Třída formuláře pro testování LINQ dotazů v aplikaci
    public partial class TestLinqForm : XtraForm
    {
        // Konstruktor formuláře
        public TestLinqForm()
        {
            InitializeComponent(); // Inicializuje komponenty formuláře
                                   // Přiřazení obsluhy události kliknutí na tlačítko Search
            simpleButton1.Click += new EventHandler(SearchButton_Click);
        }

        // Obsluha události kliknutí na tlačítko Search
        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Načtení dat podle vyhledávacího řetězce z textového pole
            LoadData(textEdit1.Text);
        }

        // Metoda pro načtení dat z databáze podle vyhledávacího řetězce
        private void LoadData(string searchCondition1)
        {
            // Vytvoření kontextu databáze v bloku using pro automatické uvolnění zdrojů
            using (var db = new Model.App3DbContext())
            {
                // Inicializace dotazu pro produkty
                var query = db.Products.AsQueryable();

                if (checkEdit1.Checked) // Pokud je zaškrtnuto pole pro rozšířené vyhledávání
                {
                    Console.WriteLine("Spojeno");
                    // Vytvoření dotazu s join mezi produkty a kategoriemi
                    var joinQuery = from p in db.Products
                                    join c in db.Categories on p.category_id equals c.Category_id
                                    select new ViewProduct // Projektování výsledků do třídy ViewProduct
                                    {
                                        product_id = p.product_id,
                                        product_name = p.product_name,
                                        CategoryName = c.Category_name,
                                        brand_id = p.brand_id,
                                        model_year = p.model_year,
                                        list_price = p.list_price,
                                        test = 0 // Inicializace testovacího pole na 0
                                    };

                    // Filtrace výsledků podle vyhledávacího řetězce
                    if (!string.IsNullOrEmpty(searchCondition1))
                    {
                        joinQuery = joinQuery.Where(p => p.product_name.Contains(searchCondition1) || p.CategoryName.Contains(searchCondition1));
                    }

                    // Získání výsledků dotazu
                    var joinResults = joinQuery.ToList();

                    // Nastavení zdroje dat pro gridControl
                    gridControl1.DataSource = joinResults;
                }
                else // Pokud není zaškrtnuto pole pro rozšířené vyhledávání
                {
                    // Filtrace produktů podle vyhledávacího řetězce
                    if (!string.IsNullOrEmpty(searchCondition1))
                    {
                        query = query.Where(p => p.product_name.Contains(searchCondition1));
                    }

                    // Získání výsledků dotazu
                    var results = query.ToList();

                    // Nastavení zdroje dat pro gridControl
                    gridControl1.DataSource = results;
                }
            }
        }

        // Vnitřní třída pro reprezentaci produktu s informacemi z kategorie
        private class ViewProduct
        {
            public int product_id { get; set; }
            public string product_name { get; set; }
            public string CategoryName { get; set; }
            public int brand_id { get; set; }
            public short model_year { get; set; }
            public decimal list_price { get; set; }
            public int test { get; internal set; } // Testovací pole, výchozí hodnota 0
        }
    }
}