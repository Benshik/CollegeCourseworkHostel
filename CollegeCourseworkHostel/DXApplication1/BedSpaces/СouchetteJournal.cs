using CollegeCourseworkHostel.Service;
using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeCourseworkHostel.Сouchette
{
    public partial class СouchetteJournal : DevExpress.XtraEditors.XtraForm
    {
        public СouchetteJournal()
        {
            InitializeComponent();
            LoadReserverPlaces();
        }

        private void LoadReserverPlaces()
        {
            SQLAdapter sqlAdapter = new SQLAdapter();

            // Создали пустую таблицу с названием allClientsDT 
            DataTable currentReservedPlases = new DataTable();

            // В таблицу allClientsDT помещаем результат метода SelectData
            // В метот SelectData передаем строковую переменную с класса Query - SelectAllClients
            // Метод SelectData возвращает запрошеннуб таблицу
            currentReservedPlases = sqlAdapter.SelectData(Query.AllReservedPlaces);

            // очищаем журнал клиентов
            gridСouchette.DataSource = null;

            // передаем таблице на форме  таблицу allClientsDT
            gridСouchette.DataSource = currentReservedPlases;
        
            // отключаем видимость столбца id
            gridViewСouchette.Columns["idReservation"].Visible = false;
        }
    }
}
