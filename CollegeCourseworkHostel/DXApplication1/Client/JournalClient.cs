using CollegeCourseworkHostel.Service;
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
    public partial class JournalClient : DevExpress.XtraEditors.XtraForm
    {
        public JournalClient()
        {
            InitializeComponent();
            LoadJournalClient();
        }

        private void btnClientEdit_Click(object sender, EventArgs e)
        {
            // Создал переменную для проверки окна редактирования (false), и окна добавления клиента (true)
            bool isNewClient = false;

            int idClient = GetActiveIdClient();

                // Cоздаем экземпляр класса Reservation.
                ClientEdit client = new ClientEdit(isNewClient, idClient);

            // включаем возможность этой форме отслеживать  форму редактирования клиента       
            client.Owner = this;

            // указываем, что при событие закрытия окна редактирования клиента, вызывается метод Client_FormClosed
            // который снова загрузит всех клиентов уже с новым клиентов
            client.FormClosed += Client_FormClosed;

            // Показывает окно.
            client.Show();       
        }

        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            // Создал переменную для проверки окна редактирования (false), и окна добавления клиента (true)
            bool isNewClient = true;

            // Cоздаем экземпляр класса Reservation.
            ClientEdit client = new ClientEdit(isNewClient);

            // включаем возможность этой форме отслеживать  форму редактирования клиента       
            client.Owner = this;

            // указываем, что при событие закрытия окна редактирования клиента, вызывается метод Client_FormClosed
            // который снова загрузит всех клиентов уже с новым клиентов
            client.FormClosed += Client_FormClosed;

            // Показываем окно редактирвоания клиента.
            client.Show();
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadJournalClient();
        }

        public void LoadJournalClient()
        {    
            SQLAdapter sqlAdapter = new SQLAdapter();

            // Создали пустую таблицу с названием allClientsDT 
            DataTable allClientsDT = new DataTable();

            // В таблицу allClientsDT помещаем результат метода SelectData
            // В метот SelectData передаем строковую переменную с класса Query - SelectAllClients
            // Метод SelectData возвращает запрошеннуб таблицу
            allClientsDT = sqlAdapter.SelectData(Query.SelectAllClients);

            // очищаем журнал клиентов
            gridControlClients.DataSource = null;

            // передаем таблице на форме  таблицу allClientsDT
            gridControlClients.DataSource = allClientsDT;

            // отключаем видимость столбца id
            gridViewClients.Columns["id"].Visible = false;
        }

        private int GetActiveIdClient()
        {
            int rowIndex = gridViewClients.GetSelectedRows()[0];
            DataRow selectedRow = gridViewClients.GetDataRow(rowIndex);

            int result = int.Parse(selectedRow["id"].ToString());

            return result;
        }
    }
}
