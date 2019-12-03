using CollegeCourseworkHostel.Service;
using System;
using System.Data;
using System.Windows.Forms;

namespace CollegeCourseworkHostel
{
    public partial class Reservation : DevExpress.XtraEditors.XtraForm
    {
        SQLAdapter sqlAdapter;
        public Reservation()
        {
            InitializeComponent();
            sqlAdapter = new SQLAdapter();
            LoadClients();
        }

        //метод загружает все свободные комнаты из БД
        private void LoadFreeRooms()
        {
            // если указаны даты заезда и выезда, то загружаем  комнаты
            if (dateEditArrival.Text != string.Empty && dateEditDeparture.Text != string.Empty)
            {
                var dateArrival = dateEditArrival.Text;
                var dateDeparture = dateEditDeparture.Text;
                var query = string.Format(Query.SelectRoomsWithEmptyBed, dateArrival, dateDeparture);
                DataTable rooms = sqlAdapter.SelectData(query);
                comboBoxRoom.DataSource = rooms;
                comboBoxRoom.ValueMember = "Room";
            }
        }

        // метод загружает все свободные комнаты из БД для текущей комнаты в выбранное время
        private void LoadFreeBed()
        {
            if (comboBoxRoom.Text != string.Empty)
            {
                var dateArrival = dateEditArrival.Text;
                var dateDeparture = dateEditDeparture.Text;
                var numRoom = comboBoxRoom.SelectedValue;
                var query = string.Format(Query.SelectEmptyBedsForRoom, numRoom, dateArrival, dateDeparture);
                DataTable rooms = sqlAdapter.SelectData(query);
                comboBoxBed.DataSource = rooms;
                comboBoxBed.ValueMember = "Bed";
            }
        }

        // метод загружает всех клиентов, чтобы их можно было выбрать
        private void LoadClients()
        {
            try
            {
                // Создали пустую таблицу с названием allClientsDT 
                DataTable allClientsDT = new DataTable();

                // В таблицу allClientsDT помещаем результат метода SelectData
                // В метот SelectData передаем строковую переменную с класса Query - SelectAllClients
                // Метод SelectData возвращает запрошеннуб таблицу
                allClientsDT = sqlAdapter.SelectData(Query.ClientInformation);

                // Выводим БД в форму.
                searchLookUpEditClient.Properties.DataSource = null;
                searchLookUpEditClient.Properties.DataSource = allClientsDT;
                searchLookUpEditClient.Properties.DisplayMember = "Клиент";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание, произошла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // функций проверяет, что все важные данные клиента внесены, и возвращает true или false
        private bool CheckInputDataClient()
        {
            if (searchLookUpEditClient.Text == string.Empty)
            {
                MessageBox.Show("Выберете имя клиента!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBoxBed.Text == string.Empty)
            {
                MessageBox.Show("Выберете гостевую кровать!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }


        // при нажатие на кнопку добавление нового клиента
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            bool isNewClient = true;

            // Cоздаем экземпляр класса Reservation.
            ClientEdit newclientadd = new ClientEdit(isNewClient);
            newclientadd.Owner = this;

            // указываем, что при событие закрытия окна редактирования клиента, вызывается метод Client_FormClosed
            // который снова загрузит всех клиентов уже с новым клиентов
            newclientadd.FormClosed += Client_FormClosed;

            // Показываем окно редактирвоания клиента.
            newclientadd.Show();
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadClients();
        }

        private void bntReserve_Click(object sender, EventArgs e)
        {
            // в условие if вызываем метод CheckInputDataClient, который проверяет, ведены ли все данные бронирования
            // если все данные ведены, возвращает true
            if (CheckInputDataClient())
            {
                // вызываем метод, который записывет данные клиента в БД
                AddGuestRegestration();
            }
        }

        private void AddGuestRegestration()
        {   
            try
            {
                int index = this.searchLookUpEditClient.Properties.GetIndexByKeyValue(this.searchLookUpEditClient.EditValue);
                object selectedRow = this.searchLookUpEditClientView.GetRow(index);


                var idSelectedClient = this.searchLookUpEditClientView.GetRowCellValue(index, this.searchLookUpEditClientView.Columns["id"]);
                var dateArrival = dateEditArrival.Text;
                var dateDeparture = dateEditDeparture.Text;

                var numRoom = comboBoxRoom.SelectedValue;
                var numBed = comboBoxBed.SelectedValue;

                var row = sqlAdapter.SelectActiveRow(string.Format(Query.selectIDCouchette, numRoom, numBed));
                var idСouchette = row["idСouchette"];

                var newReservQuery = string.Format(Query.insertNewReserv, idSelectedClient, idСouchette, tbCost.Text, dateArrival, dateDeparture);
                sqlAdapter.RunQuery(newReservQuery);

                MessageBox.Show( $"Клиент {searchLookUpEditClient.Text} успешно забронировал кровать № {numBed} в комнате {numRoom}!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Произошла внутренняя ошибка при заселения гостя!  {ex.ToString()} ", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // метод срабатывает при событие нажатия на кнопку выбора клиента
        private void searchLookUpEditClient_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // делаем колонку id невидимой
            searchLookUpEditClient.Properties.View.Columns["id"].Visible = false;         
        }

        private void comboBoxRoom_MouseClick(object sender, MouseEventArgs e)
        {
            if (dateEditArrival.Text == string.Empty)
            {
                MessageBox.Show("Выберете дату заселения гостя!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateEditDeparture.Text == string.Empty)
            {
                MessageBox.Show("Выберете дату отьезда гостя!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxBed_Click(object sender, EventArgs e)
        {
            if (comboBoxRoom.Text == string.Empty)
            {
                MessageBox.Show("Выберете гостевую комнату!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoadFreeBed();
            }
        }

        private void dateEditDeparture_EditValueChanged(object sender, EventArgs e)
        {
            LoadFreeRooms();
            DateTime arrival = Convert.ToDateTime(dateEditArrival.Text);
            DateTime departure = Convert.ToDateTime(dateEditDeparture.Text);
            if (departure > arrival)
            {
                tbCost.Text = ((departure.Day - arrival.Day) * 500).ToString();
            }
            else
            {
                MessageBox.Show("Дата отьезда не может быть меньше даты прибытия!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateEditArrival_EditValueChanged(object sender, EventArgs e)
        {
            if (dateEditDeparture.Text != string.Empty)
            {
                DateTime arrival = Convert.ToDateTime(dateEditArrival.Text);
                DateTime departure = Convert.ToDateTime(dateEditDeparture.Text);
                if (departure > arrival)
                {
                    tbCost.Text = ((departure.Day - arrival.Day) * 500).ToString();
                }
                else
                {
                    MessageBox.Show("Дата отьезда не может быть меньше даты прибытия!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}