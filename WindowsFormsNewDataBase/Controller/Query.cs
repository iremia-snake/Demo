using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsNewDataBase.Controller
{
    internal class Query
    {
        // экземпляры классов
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;

        // класс для работы с базой
        public Query(string Conn){
            // создание экземпляров при вызове конструктора класса
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }
        public DataTable UpdatePerson()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Person", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public void Add(string FirstName, string LastName, int Age)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Person(FirstName, LastName, Age) VALUES(@FirstName,@LastName,@Age)", connection);
            command.Parameters.AddWithValue("FirstName", FirstName);
            command.Parameters.AddWithValue("LastName", LastName);
            command.Parameters.AddWithValue("Age", Age);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(int ID)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Person WHERE Id = {ID}", connection);
            
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
