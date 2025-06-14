using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace Inventory_Managment_System.Classes
{
    public class DBconnection
    {
        private MySqlConnection connection;
        private string connectionString;

        public DBconnection()
        {
            try
            {
                connectionString = "server=localhost;database=inventory_management;user=root;password=;";
                connection = new MySqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Initialization Error: " + ex.Message, "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message, "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Closing Error: " + ex.Message, "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            if (OpenConnection())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Execution Error: " + ex.Message, "Query Execution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

        public DataTable GetData(string query, Dictionary<string, object> parameters = null)
        {
            DataTable table = new DataTable();
            if (OpenConnection())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(table);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data Retrieval Error: " + ex.Message, "Query Execution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    CloseConnection();
                }
            }
            return table;
        }

        public int GetLastInsertId()
        {
            int id = -1;
            if (OpenConnection())
            {
                try
                {
                    string query = "SELECT LAST_INSERT_ID()";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        id = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving last insert ID: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    CloseConnection();
                }
            }
            return id;
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
