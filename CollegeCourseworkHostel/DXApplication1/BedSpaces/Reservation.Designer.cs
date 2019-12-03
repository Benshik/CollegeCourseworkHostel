namespace CollegeCourseworkHostel
{
    partial class Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateEditArrival = new DevExpress.XtraEditors.DateEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateEditDeparture = new DevExpress.XtraEditors.DateEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.searchLookUpEditClient = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEditClientView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAddClient = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReserve = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.comboBoxBed = new System.Windows.Forms.ComboBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditArrival.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditArrival.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDeparture.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDeparture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditClientView)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(72, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "До";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(365, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Выберете доступное спальное место";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(72, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "От";
            // 
            // dateEditArrival
            // 
            this.dateEditArrival.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateEditArrival.EditValue = null;
            this.dateEditArrival.Location = new System.Drawing.Point(107, 269);
            this.dateEditArrival.Name = "dateEditArrival";
            this.dateEditArrival.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dateEditArrival.Properties.Appearance.Options.UseFont = true;
            this.dateEditArrival.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditArrival.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditArrival.Size = new System.Drawing.Size(123, 26);
            this.dateEditArrival.TabIndex = 19;
            this.dateEditArrival.EditValueChanged += new System.EventHandler(this.dateEditArrival_EditValueChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label10.Location = new System.Drawing.Point(388, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Комната";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label5.Location = new System.Drawing.Point(66, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Выберете период проживания";
            // 
            // dateEditDeparture
            // 
            this.dateEditDeparture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateEditDeparture.EditValue = null;
            this.dateEditDeparture.Location = new System.Drawing.Point(107, 302);
            this.dateEditDeparture.Name = "dateEditDeparture";
            this.dateEditDeparture.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dateEditDeparture.Properties.Appearance.Options.UseFont = true;
            this.dateEditDeparture.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDeparture.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDeparture.Size = new System.Drawing.Size(123, 26);
            this.dateEditDeparture.TabIndex = 20;
            this.dateEditDeparture.EditValueChanged += new System.EventHandler(this.dateEditDeparture_EditValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(390, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Кровать";
            // 
            // searchLookUpEditClient
            // 
            this.searchLookUpEditClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchLookUpEditClient.EditValue = "Создать клиента";
            this.searchLookUpEditClient.Location = new System.Drawing.Point(107, 155);
            this.searchLookUpEditClient.Name = "searchLookUpEditClient";
            this.searchLookUpEditClient.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.searchLookUpEditClient.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpEditClient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEditClient.Properties.View = this.searchLookUpEditClientView;
            this.searchLookUpEditClient.Size = new System.Drawing.Size(558, 26);
            this.searchLookUpEditClient.TabIndex = 25;
            this.searchLookUpEditClient.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.searchLookUpEditClient_ButtonClick);
            // 
            // searchLookUpEditClientView
            // 
            this.searchLookUpEditClientView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEditClientView.Name = "searchLookUpEditClientView";
            this.searchLookUpEditClientView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEditClientView.OptionsView.ShowGroupPanel = false;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddClient.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddClient.ImageOptions.Image")));
            this.btnAddClient.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAddClient.Location = new System.Drawing.Point(671, 153);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(28, 28);
            this.btnAddClient.TabIndex = 26;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(86, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Выберете клиента";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label9.Location = new System.Drawing.Point(313, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(271, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Бронирование кровати";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReserve
            // 
            this.btnReserve.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReserve.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnReserve.Appearance.Options.UseFont = true;
            this.btnReserve.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReserve.ImageOptions.Image")));
            this.btnReserve.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnReserve.Location = new System.Drawing.Point(738, 129);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Padding = new System.Windows.Forms.Padding(3);
            this.btnReserve.Size = new System.Drawing.Size(139, 201);
            this.btnReserve.TabIndex = 18;
            this.btnReserve.Text = "Забронировать";
            this.btnReserve.Click += new System.EventHandler(this.bntReserve_Click);
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoom.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(465, 269);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(234, 25);
            this.comboBoxRoom.TabIndex = 47;
            this.comboBoxRoom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxRoom_MouseClick);
            // 
            // comboBoxBed
            // 
            this.comboBoxBed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBed.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.comboBoxBed.FormattingEnabled = true;
            this.comboBoxBed.Location = new System.Drawing.Point(465, 304);
            this.comboBoxBed.Name = "comboBoxBed";
            this.comboBoxBed.Size = new System.Drawing.Size(234, 25);
            this.comboBoxBed.TabIndex = 48;
            this.comboBoxBed.Click += new System.EventHandler(this.comboBoxBed_Click);
            // 
            // tbCost
            // 
            this.tbCost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCost.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.tbCost.Location = new System.Drawing.Point(463, 362);
            this.tbCost.Name = "tbCost";
            this.tbCost.ReadOnly = true;
            this.tbCost.Size = new System.Drawing.Size(100, 24);
            this.tbCost.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(388, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 50;
            this.label3.Text = "Итого:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.label4.Location = new System.Drawing.Point(569, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "рублей.";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 420);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.comboBoxBed);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchLookUpEditClient);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateEditDeparture);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateEditArrival);
            this.Name = "Reservation";
            this.Text = "Бронирование";
            ((System.ComponentModel.ISupportInitialize)(this.dateEditArrival.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditArrival.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDeparture.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDeparture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditClientView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dateEditArrival;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit dateEditDeparture;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEditClient;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEditClientView;
        private DevExpress.XtraEditors.SimpleButton btnAddClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btnReserve;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.ComboBox comboBoxBed;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}