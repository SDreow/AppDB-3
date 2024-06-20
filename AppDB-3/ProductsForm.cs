using DevExpress.XtraEditors;
using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App_DB_3
{
    public partial class ProductsForm : XtraForm
    {
        private Model.App3DbContext _db;
        public ProductsForm()
        {
            InitializeComponent();
        }
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            _db = new Model.App3DbContext();
            _db.Products.Load();
            productsBindingSource.DataSource = _db.Products.Local.ToBindingList();
            repositoryItemLookUpEdit1.DataSource = _db.Categories.Select(s => new { s.Category_id, s.Category_name }).ToList();
            repositoryItemLookUpEditBrands.DataSource = _db.Brands.Select(s => new { s.Brand_id, s.Brand_Name }).ToList();
        }
        private void ProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            productsBindingSource.EndEdit();
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
            catch (DbEntityValidationException ex)
            {
                var chyby = new StringBuilder();
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        chyby.AppendLine($"Chyba v: {validationErrors.ValidationErrors} - {validationError.ErrorMessage}");
                    }
                }
                XtraMessageBox.Show(ex.ToString(), "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception vyjimka)
            {
                MessageBox.Show(vyjimka.Message + vyjimka.InnerException?.Message, "Chyba uložení dat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void barBtnSaveProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            productsBindingSource.EndEdit();
            gridView1.CloseEditor();
            UlozData();
        }
        //validace na řádek
        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var products = gridView1.GetFocusedRow() as Model.Products;
            if (products.list_price == 0)
            {
                e.Valid = false;
                e.ErrorText = "List price must be greater than 0.";
            }
        }
        //mazání na klávesu
        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && gridView1.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
            {
                if (XtraMessageBox.Show("Opravdu chcete smazat tento záznam?", "Smazání záznamu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gridView1.DeleteRow(gridView1.FocusedRowHandle);
                }
            }
        }
    }
}