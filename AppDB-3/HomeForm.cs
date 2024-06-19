using App_DB_3.Model;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace App_DB_3
{
    public partial class HomeForm : DevExpress.XtraEditors.XtraForm
    {
        App3DbContext db;
        public HomeForm()
        {
            InitializeComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("WXI");
        }
        private void HomeForm_Load(object sender, EventArgs e)
        {
            db = new App3DbContext();
            db.Orders.Load();
            ordersBindingSource.DataSource = db.Orders.Local.ToBindingList();


        }
        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }

        private void categorieBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var formCategories = new CategoriesForm())
            {
                formCategories.ShowDialog();
            }
        }

        private void zakazniciBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var formCustomers = new CustomersForm())
            {
                formCustomers.ShowDialog();
            }
        }
    }
}
