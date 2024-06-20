using App_DB_3.Model;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace App_DB_3
{
    public partial class AddForm : XtraForm
    {
        private App3DbContext _db;

        public AddForm()
        {
            InitializeComponent();
            _db = new App3DbContext();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Získání hodnot z textových polí
            bool isValidId = int.TryParse(textEditIdKategorie.Text, out int categoryId);
            string name = textEditJmenoKategorie.Text;

            if (!isValidId)
            {
                MessageBox.Show("Please enter a valid Category ID.");
                return;
            }

            // Vytvoření nové instance kategorie
            var category = new Categories { Category_id = categoryId, Category_name = name };

            // Přidání kategorie do kontextu a uložení změn
            _db.Categories.Add(category);
            _db.SaveChanges();

            MessageBox.Show("Category saved successfully.");
            DialogResult = DialogResult.OK; // Nastaví dialogový výsledek na OK
            _db.Dispose();
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            _db.Dispose();
            Close();
        }
    }
}