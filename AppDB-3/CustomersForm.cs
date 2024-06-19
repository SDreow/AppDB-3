using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_DB_3
{
    public partial class CustomersForm : XtraForm
    {
        private Model.App3DbContext _db;
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void gridControlCustomers_Load(object sender, EventArgs e)
        {
            _db = new Model.App3DbContext();
            _db.Customers.Load();
            customersBindingSource.DataSource = _db.Customers.Local.ToBindingList();
        }
    }
}