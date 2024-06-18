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
            db.Customers.Load();
            customersBindingSource.DataSource = db.Customers.Local.ToBindingList();


        }
    }
}
