using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using DevExpress.Skins;
namespace App_DB_3
{
    public partial class TestLinqForm : XtraForm
    {
        public TestLinqForm()
        {
            InitializeComponent();
            // Přidání obsluhy události pro simpleButton1
            simpleButton1.Click += new EventHandler(SearchButton_Click);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            LoadData(textEdit1.Text);
        }

        private void LoadData(string searchCondition1)
        {
            using (var db = new Model.App3DbContext())
            {
                // Použití var pro odvození typu proměnné query
                var query = db.Products.AsQueryable();

                if (checkEdit1.Checked)
                {
                    Console.WriteLine("Spojeno");
                    var joinQuery = from p in db.Products
                                    join c in db.Categories on p.category_id equals c.Category_id
                                    select new ViewProduct
                                    {
                                        product_id = p.product_id,
                                        product_name = p.product_name,
                                        CategoryName = c.Category_name,
                                        brand_id = p.brand_id,
                                        model_year = p.model_year,
                                        list_price = p.list_price,
                                        test = 0
                                    };

                    if (!string.IsNullOrEmpty(searchCondition1))
                    {
                        joinQuery = joinQuery.Where(p => p.product_name.Contains(searchCondition1) || p.CategoryName.Contains(searchCondition1));
                    }

                    var joinResults = joinQuery.ToList();

                    gridControl1.DataSource = joinResults;
                }
                else
                {
                    if (!string.IsNullOrEmpty(searchCondition1))
                    {
                        query = query.Where(p => p.product_name.Contains(searchCondition1));
                    }

                    var results = query.ToList();

                    gridControl1.DataSource = results;
                }

            }
        }

        private class ViewProduct
        {
            public int product_id { get; set; }
            public string product_name { get; set; }
            public string CategoryName { get; set; }
            public int brand_id { get; set; }
            public short model_year { get; set; }
            public decimal list_price { get; set; }
            public int test { get; internal set; }
        }
    }
}