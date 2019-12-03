namespace CollegeCourseworkHostel.Сouchette
{
    partial class СouchetteJournal
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
            this.gridСouchette = new DevExpress.XtraGrid.GridControl();
            this.gridViewСouchette = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridСouchette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewСouchette)).BeginInit();
            this.SuspendLayout();
            // 
            // gridСouchette
            // 
            this.gridСouchette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridСouchette.Location = new System.Drawing.Point(0, 0);
            this.gridСouchette.MainView = this.gridViewСouchette;
            this.gridСouchette.Name = "gridСouchette";
            this.gridСouchette.Size = new System.Drawing.Size(800, 450);
            this.gridСouchette.TabIndex = 0;
            this.gridСouchette.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewСouchette});
            // 
            // gridViewСouchette
            // 
            this.gridViewСouchette.GridControl = this.gridСouchette;
            this.gridViewСouchette.Name = "gridViewСouchette";
            this.gridViewСouchette.OptionsBehavior.Editable = false;
            // 
            // СouchetteJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridСouchette);
            this.Name = "СouchetteJournal";
            this.Text = "Учет спальных мест";
            ((System.ComponentModel.ISupportInitialize)(this.gridСouchette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewСouchette)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridСouchette;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewСouchette;
    }
}