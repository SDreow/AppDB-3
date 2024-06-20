namespace App_DB_3
{
    partial class StoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colstore_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstore_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colzip_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstreet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtnSaveStore = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.storeBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(968, 495);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Load += new System.EventHandler(this.StoreForm_Load);
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataSource = typeof(App_DB_3.Model.Store);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colstore_id,
            this.colstore_name,
            this.colcity,
            this.colzip_code,
            this.colstreet,
            this.colphone,
            this.colemail,
            this.colstate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colstore_id
            // 
            this.colstore_id.Caption = "Číslo obchodu";
            this.colstore_id.FieldName = "store_id";
            this.colstore_id.Name = "colstore_id";
            this.colstore_id.Visible = true;
            this.colstore_id.VisibleIndex = 0;
            // 
            // colstore_name
            // 
            this.colstore_name.Caption = "Název obchodu";
            this.colstore_name.FieldName = "store_name";
            this.colstore_name.Name = "colstore_name";
            this.colstore_name.Visible = true;
            this.colstore_name.VisibleIndex = 1;
            // 
            // colcity
            // 
            this.colcity.Caption = "Město";
            this.colcity.FieldName = "city";
            this.colcity.Name = "colcity";
            this.colcity.Visible = true;
            this.colcity.VisibleIndex = 2;
            // 
            // colzip_code
            // 
            this.colzip_code.Caption = "PSČ";
            this.colzip_code.FieldName = "zip_code";
            this.colzip_code.Name = "colzip_code";
            this.colzip_code.Visible = true;
            this.colzip_code.VisibleIndex = 3;
            // 
            // colstreet
            // 
            this.colstreet.Caption = "Ulice";
            this.colstreet.FieldName = "street";
            this.colstreet.Name = "colstreet";
            this.colstreet.Visible = true;
            this.colstreet.VisibleIndex = 4;
            // 
            // colphone
            // 
            this.colphone.Caption = "Telefon";
            this.colphone.FieldName = "phone";
            this.colphone.Name = "colphone";
            this.colphone.Visible = true;
            this.colphone.VisibleIndex = 5;
            // 
            // colemail
            // 
            this.colemail.Caption = "E-mail";
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 6;
            // 
            // colstate
            // 
            this.colstate.Caption = "Stát";
            this.colstate.FieldName = "state";
            this.colstate.Name = "colstate";
            this.colstate.Visible = true;
            this.colstate.VisibleIndex = 7;
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
            this.barBtnSaveStore});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnSaveStore)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barBtnSaveStore
            // 
            this.barBtnSaveStore.Caption = "Save";
            this.barBtnSaveStore.Id = 0;
            this.barBtnSaveStore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSaveStore.ImageOptions.Image")));
            this.barBtnSaveStore.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSaveStore.ImageOptions.LargeImage")));
            this.barBtnSaveStore.Name = "barBtnSaveStore";
            this.barBtnSaveStore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSaveStore_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(968, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 519);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(968, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 495);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(968, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 495);
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 539);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "StoreForm";
            this.Text = "Obchody";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StoreForm_FormClosing);
            this.Load += new System.EventHandler(this.StoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barBtnSaveStore;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colstore_id;
        private DevExpress.XtraGrid.Columns.GridColumn colstore_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcity;
        private DevExpress.XtraGrid.Columns.GridColumn colzip_code;
        private DevExpress.XtraGrid.Columns.GridColumn colstreet;
        private DevExpress.XtraGrid.Columns.GridColumn colphone;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colstate;
    }
}