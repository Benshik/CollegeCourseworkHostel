namespace CollegeCourseworkHostel
{
    partial class Evenue
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
            this.dateEditUntil = new DevExpress.XtraEditors.DateEdit();
            this.dateEditwith = new DevExpress.XtraEditors.DateEdit();
            this.btnCalcMoney = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditUntil.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditUntil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditwith.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditwith.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEditUntil
            // 
            this.dateEditUntil.EditValue = null;
            this.dateEditUntil.Location = new System.Drawing.Point(375, 91);
            this.dateEditUntil.Name = "dateEditUntil";
            this.dateEditUntil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.dateEditUntil.Properties.Appearance.Options.UseFont = true;
            this.dateEditUntil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditUntil.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditUntil.Size = new System.Drawing.Size(139, 26);
            this.dateEditUntil.TabIndex = 0;
            this.dateEditUntil.EditValueChanged += new System.EventHandler(this.dateEditUntil_EditValueChanged);
            // 
            // dateEditwith
            // 
            this.dateEditwith.EditValue = null;
            this.dateEditwith.Location = new System.Drawing.Point(174, 91);
            this.dateEditwith.Name = "dateEditwith";
            this.dateEditwith.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.dateEditwith.Properties.Appearance.Options.UseFont = true;
            this.dateEditwith.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditwith.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditwith.Size = new System.Drawing.Size(134, 26);
            this.dateEditwith.TabIndex = 1;
            // 
            // btnCalcMoney
            // 
            this.btnCalcMoney.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnCalcMoney.Appearance.Options.UseFont = true;
            this.btnCalcMoney.Location = new System.Drawing.Point(141, 161);
            this.btnCalcMoney.Name = "btnCalcMoney";
            this.btnCalcMoney.Size = new System.Drawing.Size(373, 32);
            this.btnCalcMoney.TabIndex = 2;
            this.btnCalcMoney.Text = "Рассчитать";
            this.btnCalcMoney.Click += new System.EventHandler(this.btnCalcMoney_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.label1.Location = new System.Drawing.Point(137, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "C :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.label2.Location = new System.Drawing.Point(332, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "До :";
            // 
            // Evenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 345);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcMoney);
            this.Controls.Add(this.dateEditwith);
            this.Controls.Add(this.dateEditUntil);
            this.Name = "Evenue";
            this.Text = "Доход";
            ((System.ComponentModel.ISupportInitialize)(this.dateEditUntil.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditUntil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditwith.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditwith.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dateEditUntil;
        private DevExpress.XtraEditors.DateEdit dateEditwith;
        private DevExpress.XtraEditors.SimpleButton btnCalcMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}