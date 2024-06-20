namespace App_DB_3
{
    partial class ProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtnSaveProducts = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colproduct_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproduct_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategory_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.collist_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbrand_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditBrands = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colmodel_year = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditBrands)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnSaveProducts});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnSaveProducts)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barBtnSaveProducts
            // 
            this.barBtnSaveProducts.Caption = "Save";
            this.barBtnSaveProducts.Id = 0;
            this.barBtnSaveProducts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSaveProducts.ImageOptions.Image")));
            this.barBtnSaveProducts.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSaveProducts.ImageOptions.LargeImage")));
            this.barBtnSaveProducts.Name = "barBtnSaveProducts";
            this.barBtnSaveProducts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSaveProducts_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(889, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 451);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(889, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 427);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(889, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 427);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.productsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEditBrands});
            this.gridControl1.Size = new System.Drawing.Size(889, 427);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(App_DB_3.Model.Products);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colproduct_id,
            this.colproduct_name,
            this.colcategory_id,
            this.collist_price,
            this.colbrand_id,
            this.colmodel_year});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            // 
            // colproduct_id
            // 
            this.colproduct_id.Caption = "Číslo produktu";
            this.colproduct_id.FieldName = "product_id";
            this.colproduct_id.Name = "colproduct_id";
            this.colproduct_id.Visible = true;
            this.colproduct_id.VisibleIndex = 0;
            // 
            // colproduct_name
            // 
            this.colproduct_name.Caption = "Jméno produktu";
            this.colproduct_name.FieldName = "product_name";
            this.colproduct_name.Name = "colproduct_name";
            this.colproduct_name.Visible = true;
            this.colproduct_name.VisibleIndex = 1;
            // 
            // colcategory_id
            // 
            this.colcategory_id.Caption = "Číslo kategorie";
            this.colcategory_id.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colcategory_id.FieldName = "category_id";
            this.colcategory_id.Name = "colcategory_id";
            this.colcategory_id.Visible = true;
            this.colcategory_id.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "Category_name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "Category_id";
            // 
            // collist_price
            // 
            this.collist_price.Caption = "Cena";
            this.collist_price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.collist_price.FieldName = "list_price";
            this.collist_price.Name = "collist_price";
            this.collist_price.Visible = true;
            this.collist_price.VisibleIndex = 3;
            // 
            // colbrand_id
            // 
            this.colbrand_id.Caption = "Číslo značky";
            this.colbrand_id.ColumnEdit = this.repositoryItemLookUpEditBrands;
            this.colbrand_id.FieldName = "brand_id";
            this.colbrand_id.Name = "colbrand_id";
            this.colbrand_id.Visible = true;
            this.colbrand_id.VisibleIndex = 4;
            // 
            // repositoryItemLookUpEditBrands
            // 
            this.repositoryItemLookUpEditBrands.AutoHeight = false;
            this.repositoryItemLookUpEditBrands.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditBrands.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Brand_Name", "Značka")});
            this.repositoryItemLookUpEditBrands.DisplayMember = "Brand_Name";
            this.repositoryItemLookUpEditBrands.Name = "repositoryItemLookUpEditBrands";
            this.repositoryItemLookUpEditBrands.ValueMember = "Brand_id";
            // 
            // colmodel_year
            // 
            this.colmodel_year.Caption = "Rok";
            this.colmodel_year.FieldName = "model_year";
            this.colmodel_year.Name = "colmodel_year";
            this.colmodel_year.Visible = true;
            this.colmodel_year.VisibleIndex = 5;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 471);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ProductsForm";
            this.Text = "Produkty";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductsForm_FormClosing);
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditBrands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barBtnSaveProducts;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct_id;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcategory_id;
        private DevExpress.XtraGrid.Columns.GridColumn collist_price;
        private DevExpress.XtraGrid.Columns.GridColumn colbrand_id;
        private DevExpress.XtraGrid.Columns.GridColumn colmodel_year;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditBrands;
    }
}