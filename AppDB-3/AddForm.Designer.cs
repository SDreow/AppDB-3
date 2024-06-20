namespace App_DB_3
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.textEditJmenoKategorie = new DevExpress.XtraEditors.TextEdit();
            this.textEditIdKategorie = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditJmenoKategorie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdKategorie.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditJmenoKategorie
            // 
            this.textEditJmenoKategorie.Location = new System.Drawing.Point(165, 31);
            this.textEditJmenoKategorie.Name = "textEditJmenoKategorie";
            this.textEditJmenoKategorie.Size = new System.Drawing.Size(147, 20);
            this.textEditJmenoKategorie.TabIndex = 0;
            // 
            // textEditIdKategorie
            // 
            this.textEditIdKategorie.Location = new System.Drawing.Point(12, 31);
            this.textEditIdKategorie.Name = "textEditIdKategorie";
            this.textEditIdKategorie.Size = new System.Drawing.Size(147, 20);
            this.textEditIdKategorie.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(198, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Jméno kategorie";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(49, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "ID Kategorie";
            // 
            // cancelBtn
            // 
            this.cancelBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.cancelBtn.Location = new System.Drawing.Point(198, 75);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 34);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.saveBtn.Location = new System.Drawing.Point(49, 75);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 35);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Ulož";
            this.saveBtn.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 122);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditIdKategorie);
            this.Controls.Add(this.textEditJmenoKategorie);
            this.Name = "AddForm";
            this.Text = "AddForm";
            ((System.ComponentModel.ISupportInitialize)(this.textEditJmenoKategorie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdKategorie.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEditJmenoKategorie;
        private DevExpress.XtraEditors.TextEdit textEditIdKategorie;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
    }
}