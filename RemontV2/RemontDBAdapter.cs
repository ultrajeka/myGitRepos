using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace RemontV2
{
    class RemontDBAdapter
    {
        SQLiteConnection sqliteConnection;

        private const string connectionString = @"Data source=D:\C# projects\RemontV2\Resources\MastersDB.db; Version=3";

        public RemontDBAdapter()
        {
            sqliteConnection = new SQLiteConnection(connectionString);
        }
        public DataTable ReadTableMasters()
        {
            SQLiteCommand command = new SQLiteCommand("select * from Masters", sqliteConnection);

            DataTable mastersDataTable = new DataTable();
            mastersDataTable.Columns.Add("ID");
            mastersDataTable.Columns.Add("FIO");
            mastersDataTable.Columns.Add("PHONE");
            mastersDataTable.Columns.Add("EMAIL");

            try
            {
                sqliteConnection.Open();
                SQLiteDataReader rdr = command.ExecuteReader();

                while (rdr.Read())
                {
                    var id = rdr["ID"];
                    var fio = rdr["FIO"];
                    var phone = rdr["PHONE"];
                    var email = rdr["EMAIL"];

                    mastersDataTable.Rows.Add(id, fio, phone, email);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqliteConnection.Close();
            }

            return mastersDataTable;
        }
        public void InsertToMasters(string Fio, string Phone, string Email)
        {
            SQLiteCommand command = new SQLiteCommand("insert into Masters(FIO, PHONE, EMAIL) values (@Fio, @Phone, @Email)", sqliteConnection);

            command.Parameters.AddWithValue("FIO", Fio);
            command.Parameters.AddWithValue("Phone", Phone);
            command.Parameters.AddWithValue("Email", Email);

            try
            {
                sqliteConnection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
            finally
            {
                sqliteConnection.Close();
            }

        }
        public void UpdateMasters(string Id, string Fio, string Phone, string Email)
        {
            SQLiteCommand command = new SQLiteCommand("update [Masters] set [FIO] = @Fio, [PHONE] = @Phone, [EMAIL] = @Email where [ID] = @Id", sqliteConnection);

            command.Parameters.AddWithValue("Id", Id);
            command.Parameters.AddWithValue("FIO", Fio);
            command.Parameters.AddWithValue("PHONE", Phone);
            command.Parameters.AddWithValue("EMAIL", Email);

            try
            {
                sqliteConnection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }
            finally
            {
                sqliteConnection.Close();
            }
        }
        public void ClearMastersDB()
        {
            SQLiteCommand command = new SQLiteCommand("DELETE FROM Masters", sqliteConnection);            

            try
            {
                sqliteConnection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqliteConnection.Close();
            }
        }
    }
}
