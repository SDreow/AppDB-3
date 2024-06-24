using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App_DB_3
{
    public partial class CategoriesForm : XtraForm
    {
        private Model.App3DbContext _db;
        public CategoriesForm()
        {
            InitializeComponent();
        }
        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            _db = new Model.App3DbContext();
            _db.Categories.Load();
            categoriesBindingSource.DataSource = _db.Categories.Local.ToBindingList();
            //categoriesBindingSource.DataSource = _db.Categories.Select(s => new { s.Category_id, s.Category_name }).ToList();
        }
        private void CategoriesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            categoriesBindingSource.EndEdit();
            if (gridView1.IsEditing)
                gridView1.CloseEditor();
            if (_db.ChangeTracker.HasChanges())
            {
                var dialog = XtraMessageBox.Show("Přejete si uložit změny ?", "Uložení změn", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                if (dialog == DialogResult.Yes)
                {
                    e.Cancel = !UlozData();
                }
            }
            if (e.Cancel == false)
            {
                _db.Dispose();
            }
        }
        private bool UlozData()
        {
            try
            {
                _db.SaveChanges();
                return true;
            }
            catch (DbEntityValidationException dbEVE)
            {
                var chyby = new StringBuilder();
                foreach (var validationErrors in dbEVE.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        chyby.AppendLine($"Chyba v: {validationErrors.ValidationErrors} - {validationError.ErrorMessage}");
                    }
                }
                MessageBox.Show(chyby.ToString(), "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DbUpdateException)
            {
                // Zde můžete přidat specifické zpracování pro chyby aktualizace databáze, například pro problémy s category_id
                MessageBox.Show("Nelze aktualizovat 'category_id', protože by to mohlo porušit omezení databáze.", "Chyba aktualizace", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception vyjimka)
            {
                MessageBox.Show(vyjimka.Message + vyjimka.InnerException?.Message, "Chyba uložení dat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void saveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            categoriesBindingSource.EndEdit();
            gridView1.CloseEditor();
            UlozData();
        }
        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var addForm = new AddForm())
            {
                var result = addForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    RefreshCategories(); // Volá metodu pro obnovení dat kategorií
                }
            }
        }
        private void RefreshCategories()
        {
            _db.Categories.Load(); // Znovu načte kategorie z databáze
            categoriesBindingSource.DataSource = _db.Categories.Local.ToBindingList(); // Aktualizuje zdroj dat pro zobrazení
        }
    }

}
