using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace CollegeCourseworkHostel.Service
{
    class SQLAdapter
    {
        private SQLiteConnection dbConnection = null;

        private string pathBD = "..\\..\\HostelDB.db";

        public SQLAdapter()
        {
            if (!(File.Exists(pathBD)))    // если файл не найден сообщаем об ошибке 
            {
                string messageError = "File " + pathBD + " not found!" ;
                MessageBox.Show(messageError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dbConnection = new SQLiteConnection("Data Source=" + pathBD);
            }
        }

        public DataTable SelectData(string query)
        {
            // Создаем пустую таблицу.
            DataTable resultDT = new DataTable();

            // Открываем соеденение.
            dbConnection.Open();

            // отправляем комманду в БД
            SQLiteCommand command = new SQLiteCommand(query, dbConnection);

            // создаем Реадер, который считывает результат запроса
            SQLiteDataReader reader = command.ExecuteReader();

            // Загружаем полученные данные из reader в resultDT (таблицу).
            resultDT.Load(reader);

            // Закрываем соеденение с БД
            dbConnection.Close();
            return resultDT;
        }

        public void RunQuery(string query)
        {
            // Открываем соеденение.
            dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand(query, dbConnection);
            SQLiteDataReader wreader = command.ExecuteReader();

            // Закрываем соеденение с БД
            dbConnection.Close();
        }


    }
}
