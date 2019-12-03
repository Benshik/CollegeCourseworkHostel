using CollegeCourseworkHostel.Service;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeCourseworkHostel
{
    public partial class SleepPlace : DevExpress.XtraEditors.XtraForm
    {
        SQLAdapter adapter;

        public SleepPlace()
        {
            InitializeComponent();
            Skin skin_ = TabSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel);
            SkinElement element = skin_[TabSkins.SkinTabHeader];
            element.Properties["AllowTouch"] = false;
            element.ContentMargins.Top = 10;
            element.ContentMargins.Right = 20;
            element.ContentMargins.Left = 20;
            element.ContentMargins.Bottom = 10;
            Свободные.LayoutChanged();

            adapter = new SQLAdapter();
            LoadFreeRoom();
            LoadBusyRoom();
        }

        private void LoadFreeRoom()
        {
            gridControlFreeRoom.DataSource = adapter.SelectData(Query.SelectFreeRoom);
            gridViewFreeRoom.RowHeight = 40;
            gridViewFreeRoom.Columns["№ комнаты"].View.OptionsBehavior.EditorShowMode = EditorShowMode.MouseUp;
            gridViewFreeRoom.RowClick += gridViewFreeRoom_RowClick;
        }

        private void LoadBusyRoom()
        {
            gridControlBusyRoom.DataSource = adapter.SelectData(Query.SelectBisySleepPlaces);
            gridViewBusyRoom.RowHeight = 40;
            gridViewBusyRoom.Columns["№ комнаты"].View.OptionsBehavior.EditorShowMode = EditorShowMode.MouseUp;
            gridViewBusyRoom.RowClick += gridViewBusyRoom_RowClick;
        }

        private void LoadFreeBed(object numRoom)
        {
            try
            {
                var query = string.Format(Query.SelectFreeBedByRoom, numRoom);
                gridControlFreeBed.DataSource = adapter.SelectData(query);
                gridViewFreeBed.RowHeight = 30;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Произошла ошибка пр загрузки свободный комнат {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBusyBed(object numRoom)
        {
            try
            {
                var query = string.Format(Query.SelectBusyBedByRoom, numRoom);
                gridControlBusyBed.DataSource = adapter.SelectData(query);
                gridViewFreeBed.RowHeight = 30;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка пр загрузки занятых комнат {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewFreeRoom_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            LoadFreeBed((sender as GridView).GetFocusedRowCellValue("№ комнаты"));
        }

        private void gridViewBusyRoom_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            LoadBusyBed((sender as GridView).GetFocusedRowCellValue("№ комнаты"));
        }
    }          
}
