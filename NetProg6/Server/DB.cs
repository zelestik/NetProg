using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Server
{
    class DB
    {
        private string dbFileName = @"DB.sqlite3";

        public string ExceptionMessages { get; private set; } // Поле с сообщениями об ошибках для отладки

        public DB()
        {
            CheckDB();
        }

        private void CheckDB() // Проверка на существование БД, при отсутствии - создаем
        {
            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName);
            using (var sqlite = new SQLiteConnection("Data source =" + dbFileName))
            {
                try
                {
                    sqlite.Open();
                    // Запрос для создания таблиц БД и наполнения основными данными
                    string sql = @"CREATE TABLE IF NOT EXISTS cards
                    (cardNum integer not null constraint statuses_pk primary key autoincrement, balance INTEGER not null DEFAULT 0);";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    ExceptionMessages = e.Message;
                }
            }
        }

        public long getBalance(long cardNum) // Загрузка задач из БД
        {
            // Запрос на получение задач
            var sql = $"SELECT balance " +
                $"FROM cards where cardNum = {cardNum}";
            using (var con = new SQLiteConnection("Data source =" + dbFileName))
            {
                SQLiteCommand Command = new SQLiteCommand(sql, con);
                try
                {
                    con.Open();
                    using (var reader = Command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return (long)reader["balance"];
                        }
                    }
                    con.Close();
                }
                catch (Exception e)
                {
                    ExceptionMessages = e.Message;
                }
                return long.MinValue;
            }
        }
        public bool ChangeBalance(long cardNum, long moneyToAdd)
        {
            var sql = $"UPDATE cards SET balance = balance + {moneyToAdd} WHERE cardnum = {cardNum}";
            using (var con = new SQLiteConnection("Data source =" + dbFileName))
            {
                try
                {
                    con.Open();
                    SQLiteCommand command = new SQLiteCommand(sql, con);
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception e)
                {
                    ExceptionMessages = e.Message;
                }
            }

            return false;
        }
        public bool AddCard(long cardNum) // Добавление новой задачи
        {
            var sql = $"INSERT INTO 'cards' " +
                $"('cardNum') " +
                $"VALUES ('{cardNum}'); ";
            using (var con = new SQLiteConnection("Data source =" + dbFileName))
            {
                try
                {
                    SQLiteCommand Command = new SQLiteCommand(sql, con);
                    con.Open();
                    Command.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                catch (Exception e)
                {
                    // Записываем сообщение ошибки
                    ExceptionMessages = e.Message;
                    return false;
                }
            }
        }
    }
}
