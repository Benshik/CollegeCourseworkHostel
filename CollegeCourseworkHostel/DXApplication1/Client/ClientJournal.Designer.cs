namespace CollegeCourseworkHostel
{
    partial class ClientJournal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientJournal));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClientAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnClientEdit = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlClients = new DevExpress.XtraGrid.GridControl();
            this.gridViewClients = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClientAdd);
            this.panelControl1.Controls.Add(this.btnClientEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(691, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(109, 450);
            this.panelControl1.TabIndex = 0;
            // 
            // btnClientAdd
            // 
            this.btnClientAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClientAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClientAdd.ImageOptions.Image")));
            this.btnClientAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClientAdd.Location = new System.Drawing.Point(2, 0);
            this.btnClientAdd.Name = "btnClientAdd";
            this.btnClientAdd.Size = new System.Drawing.Size(105, 210);
            this.btnClientAdd.TabIndex = 42;
            this.btnClientAdd.Click += new System.EventHandler(this.btnClientAdd_Click);
            // 
            // btnClientEdit
            // 
            this.btnClientEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClientEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClientEdit.ImageOptions.Image")));
            this.btnClientEdit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClientEdit.Location = new System.Drawing.Point(2, 210);
            this.btnClientEdit.Name = "btnClientEdit";
            this.btnClientEdit.Size = new System.Drawing.Size(105, 238);
            this.btnClientEdit.TabIndex = 41;
            this.btnClientEdit.Click += new System.EventHandler(this.btnClientEdit_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControlClients);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(691, 450);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControlClients
            // 
            this.gridControlClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlClients.Location = new System.Drawing.Point(2, 2);
            this.gridControlClients.MainView = this.gridViewClients;
            this.gridControlClients.Name = "gridControlClients";
            this.gridControlClients.Size = new System.Drawing.Size(687, 446);
            this.gridControlClients.TabIndex = 0;
            this.gridControlClients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClients});
            // 
            // gridViewClients
            // 
            this.gridViewClients.GridControl = this.gridControlClients;
            this.gridViewClients.Name = "gridViewClients";
            this.gridViewClients.OptionsBehavior.Editable = false;
            this.gridViewClients.DoubleClick += new System.EventHandler(this.gridViewClients_DoubleClick);
            // 
            // JournalClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "JournalClient";
            this.Text = "Список клиентов";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControlClients;
        private DevExpress.XtraEditors.SimpleButton btnClientAdd;
        private DevExpress.XtraEditors.SimpleButton btnClientEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClients;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}