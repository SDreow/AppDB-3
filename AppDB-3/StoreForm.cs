using DevExpress.XtraEditors;
using System;
using System.Data.Entity;
using System.Text;
using System.Windows.Forms;

namespace App_DB_3
{
    public partial class StoreForm : XtraForm
    {
        private Model.App3DbContext _db;
        public StoreForm()
        {
            InitializeComponent();
        }
        private void StoreForm_Load(object sender, EventArgs e)
        {
            _db = new Model.App3DbContext();
            _db.Store.Load();
            storeBindingSource.DataSource = _db.Store.Local.ToBindingList();
        }
        private void StoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            storeBindingSource.EndEdit();
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
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEVE)
            {
                var chyby = new StringBuilder();
                foreach (var validationErrors in dbEVE.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        chyby.AppendLine($"Chyba v: {validationErrors.ValidationErrors} - {validationError.ErrorMessage}");
                    }
                }
                XtraMessageBox.Show(chyby.ToString(), "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Chyba v uložení dat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void barBtnSaveStore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            storeBindingSource.EndEdit();
            gridView1.CloseEditor();
            UlozData();
        }
    }
}