namespace App_DB_3
{
    partial class CustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            this.gridControlCustomers = new DevExpress.XtraGrid.GridControl();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcustomer_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfirst_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collast_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstreet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colzip_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtnSaveCustomers = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCustomers
            // 
            this.gridControlCustomers.DataSource = this.customersBindingSource;
            this.gridControlCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCustomers.Location = new System.Drawing.Point(0, 24);
            this.gridControlCustomers.MainView = this.gridViewCustomers;
            this.gridControlCustomers.Name = "gridControlCustomers";
            this.gridControlCustomers.Size = new System.Drawing.Size(837, 553);
            this.gridControlCustomers.TabIndex = 0;
            this.gridControlCustomers.UseEmbeddedNavigator = true;
            this.gridControlCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustomers});
            this.gridControlCustomers.Load += new System.EventHandler(this.gridControlCustomers_Load);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataSource = typeof(App_DB_3.Model.Customers);
            // 
            // gridViewCustomers
            // 
            this.gridViewCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcustomer_id,
            this.colfirst_name,
            this.collast_name,
            this.colphone,
            this.colemail,
            this.colstreet,
            this.colcity,
            this.colstate,
            this.colzip_code});
            this.gridViewCustomers.GridControl = this.gridControlCustomers;
            this.gridViewCustomers.Name = "gridViewCustomers";
            this.gridViewCustomers.OptionsView.ShowGroupPanel = false;
            // 
            // colcustomer_id
            // 
            this.colcustomer_id.Caption = "Číslo zákazníka";
            this.colcustomer_id.FieldName = "customer_id";
            this.colcustomer_id.Name = "colcustomer_id";
            this.colcustomer_id.Visible = true;
            this.colcustomer_id.VisibleIndex = 0;
            // 
            // colfirst_name
            // 
            this.colfirst_name.Caption = "Jméno";
            this.colfirst_name.FieldName = "first_name";
            this.colfirst_name.Name = "colfirst_name";
            this.colfirst_name.Visible = true;
            this.colfirst_name.VisibleIndex = 1;
            // 
            // collast_name
            // 
            this.collast_name.Caption = "Příjmení";
            this.collast_name.FieldName = "last_name";
            this.collast_name.Name = "collast_name";
            this.collast_name.Visible = true;
            this.collast_name.VisibleIndex = 2;
            // 
            // colphone
            // 
            this.colphone.Caption = "Telefon";
            this.colphone.FieldName = "phone";
            this.colphone.Name = "colphone";
            this.colphone.Visible = true;
            this.colphone.VisibleIndex = 3;
            // 
            // colemail
            // 
            this.colemail.Caption = "E-mail";
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 4;
            // 
            // colstreet
            // 
            this.colstreet.Caption = "Ulice";
            this.colstreet.FieldName = "street";
            this.colstreet.Name = "colstreet";
            this.colstreet.Visible = true;
            this.colstreet.VisibleIndex = 5;
            // 
            // colcity
            // 
            this.colcity.Caption = "Město";
            this.colcity.FieldName = "city";
            this.colcity.Name = "colcity";
            this.colcity.Visible = true;
            this.colcity.VisibleIndex = 6;
            // 
            // colstate
            // 
            this.colstate.Caption = "Stát";
            this.colstate.FieldName = "state";
            this.colstate.Name = "colstate";
            this.colstate.Visible = true;
            this.colstate.VisibleIndex = 7;
            // 
            // colzip_code
            // 
            this.colzip_code.Caption = "PSČ";
            this.colzip_code.FieldName = "zip_code";
            this.colzip_code.Name = "colzip_code";
            this.colzip_code.Visible = true;
            this.colzip_code.VisibleIndex = 8;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnSaveCustomers});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnSaveCustomers)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barBtnSaveCustomers
            // 
            this.barBtnSaveCustomers.Caption = "Save";
            this.barBtnSaveCustomers.Id = 0;
            this.barBtnSaveCustomers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSaveCustomers.ImageOptions.Image")));
            this.barBtnSaveCustomers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSaveCustomers.ImageOptions.LargeImage")));
            this.barBtnSaveCustomers.Name = "barBtnSaveCustomers";
            this.barBtnSaveCustomers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSaveCustomers_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(837, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 577);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(837, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 553);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(837, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 553);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 577);
            this.Controls.Add(this.gridControlCustomers);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "CustomersForm";
            this.Text = "Zákazníci";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomersForm_FormClosing);
            this.Load += new System.EventHandler(this.gridControlCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCustomers;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colcustomer_id;
        private DevExpress.XtraGrid.Columns.GridColumn colfirst_name;
        private DevExpress.XtraGrid.Columns.GridColumn collast_name;
        private DevExpress.XtraGrid.Columns.GridColumn colphone;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colstreet;
        private DevExpress.XtraGrid.Columns.GridColumn colcity;
        private DevExpress.XtraGrid.Columns.GridColumn colstate;
        private DevExpress.XtraGrid.Columns.GridColumn colzip_code;
        private DevExpress.XtraBars.BarButtonItem barBtnSaveCustomers;
    }
}