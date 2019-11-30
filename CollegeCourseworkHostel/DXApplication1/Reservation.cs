using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CollegeCourseworkHostel.Service;

namespace CollegeCourseworkHostel
{
    public partial class Reservation : DevExpress.XtraEditors.XtraForm
    {
        public Reservation()
        {
            InitializeComponent();
            LoadJJournalClient();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            bool isNewClient = true;

            // Cоздаем экземпляр класса Reservation.
            ClientEdit newclientadd = new ClientEdit(isNewClient);

            // Показывает окно.
            newclientadd.Show();
        }

        private void LoadJJournalClient()
        {
            try
            {
                SQLAdapter sqlAdapter = new SQLAdapter();

                // Создали пустую таблицу с названием allClientsDT 
                DataTable allClientsDT = new DataTable();

                // В таблицу allClientsDT помещаем результат метода SelectData
                // В метот SelectData передаем строковую переменную с класса Query - SelectAllClients
                // Метод SelectData возвращает запрошеннуб таблицу
                allClientsDT = sqlAdapter.SelectData(Query.ClientInformation);

                // Выводим БД в форму.
                searchLookUpEditClient.Properties.DataSource = allClientsDT;
                searchLookUpEditClient.Properties.DisplayMember = "FullName";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание, произошла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchLookUpEditClient_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            searchLookUpEditClient.Properties.View.Columns["id"].Visible = false;
        }
    }
}