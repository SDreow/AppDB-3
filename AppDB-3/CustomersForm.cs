﻿using DevExpress.XtraEditors;
using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Text;
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
        private void CustomersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            customersBindingSource.EndEdit();
            if (gridViewCustomers.IsEditing)
                gridViewCustomers.CloseEditor();
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
                XtraMessageBox.Show(dbEVE.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Chyba uložení dat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }


        private void barBtnSaveCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            customersBindingSource.EndEdit();
            gridViewCustomers.CloseEditor();
            UlozData();
        }

    }
}