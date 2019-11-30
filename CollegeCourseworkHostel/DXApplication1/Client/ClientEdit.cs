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
    public partial class ClientEdit : DevExpress.XtraEditors.XtraForm
    {
        bool isNewClient;
        int idClient = -1;
        SQLAdapter sqlAdapter = null;

        // конструктор. idClient - не обязательный параметр
        // по умолчанию  ИД клиента  поставим = -1
        //  (т.к. для нового клиента ID у нас нет)
        public ClientEdit(bool isNewClient, int idClient = -1)
        {
            InitializeComponent();

            // создаем экземпляр класса, у которого есть методы для работой с БД
            sqlAdapter = new SQLAdapter();

            // полю этого класса isNewClient присваиваем то, что пришло в конструктор
            this.isNewClient = isNewClient;

            // полю этого класса idClient присваиваем то, что пришло в конструктор
            this.idClient = idClient;

            // вызываем функции для ндобавление названия формы
            PaintName();
        }


        // функуций в зависимости от того, новый клиент или старый, меняет данные на форме
        private void PaintName ()
        {
            if (isNewClient)
            {
                this.Text = "Добавление клиента";
            }
            else
            {
                this.Text = "Редактирование клиента";
                LoadClientData();
            }
        }

        private void LoadClientData()
        {
            try
            {
                string query = string.Format(Query.GetClientById, idClient);
                DataRow clietnRow = sqlAdapter.SelectActiveRow(query);

                if (clietnRow != null)
                {
                    textEditFirstName.Text = clietnRow["FirstName"].ToString();
                    textEditSecondName.Text = clietnRow["SecondName"].ToString();
                    textEditMiddleName.Text = clietnRow["MiddleName"].ToString();
                    dateEditBirthday.Text = clietnRow["Birthday"].ToString();
                    comboBoxGender.Text = clietnRow["Gender"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Внимание, произошла ошибка при попытки загрузки клиента из БД с id {idClient}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // функций забирает данные клиента с формы и  записывает их в базу данных
        private void RecordClientToDB()
        {
            try
            {
                // получаем данные с формы
                string firstName = textEditFirstName.Text;
                string secondName = textEditSecondName.Text;
                string middleName = textEditMiddleName.Text;
                var birthday = dateEditBirthday.Text;
                var gender = comboBoxGender.Text;

                string query = string.Empty;
                string fullQuery = string.Empty;

                // если новый клиент, то берем строку запрос(insert) на вставку нового клиента
                // а если старый, то о берем  строку запроc на изменение клиента (update)
                if (isNewClient)
                {
                    query = Query.InsertClient;

                    // добавляем в строку запроса данные клиента
                    fullQuery = string.Format(query, firstName, secondName, middleName, birthday, gender);
                }
                else
                {
                    query = Query.UpdateClient;

                    fullQuery = string.Format(query, firstName, secondName, middleName, birthday, gender, idClient);
                }

                // вызываем метод, который принимает строку запроса и выполнит его
                sqlAdapter.RunQuery(fullQuery);

                MessageBox.Show($"Пользователь {secondName} {firstName} успешно сохранен!","Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание, произошла ошибка при вставки / добавление клиента в БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                    
        }


        // при нажатие на кнопку "Ок"
        private void btnClientEditOk_Click(object sender, EventArgs e)
        {
            // в условие if вызываем метод CheckInputDataClient, который проверяет, ведены ли все данные  о клиенте
            // если все данные ведены, возвращает true
            if (CheckInputDataClient())
            {
                // вызываем метод, который записывет данные клиента в БД
                RecordClientToDB();
                this.Close();
            }
        }


        // функций проверяет, что все важные данные клиента внесены, и возвращает true или false
        private bool CheckInputDataClient()
        {
            if (textEditFirstName.Text == string.Empty)
            {
                MessageBox.Show("Введите имя клиента!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textEditSecondName.Text == string.Empty)
            {
                MessageBox.Show("Введите фамилию клиента!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else if (dateEditBirthday.Text == string.Empty)
            {
                MessageBox.Show("Выберете дату рождения клиента!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBoxGender.Text == string.Empty)
            {
                MessageBox.Show("Выберете пол клиента!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
    }
}
