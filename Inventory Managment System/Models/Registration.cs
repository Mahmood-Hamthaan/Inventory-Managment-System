using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Inventory_Managment_System.Classes;
using MySql.Data.MySqlClient;


namespace Inventory_Managment_System.Models
{
    public class Registration
    {
        public bool RegisterUser(string name, string username, string password, string contactNumber, string role)
        {
            try
            {
                // Check if username already exists
                string checkQuery = "SELECT COUNT(*) FROM users WHERE Username = @Username";
                var checkParams = new Dictionary<string, object> { { "@Username", username } };
                var db = new DBconnection();
                DataTable result = db.GetData(checkQuery, checkParams);

                int userExists = Convert.ToInt32(result.Rows[0][0]);
                if (userExists > 0)
                {
                    MessageBox.Show("Username already exists. Please choose another username.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Insert new user
                string insertQuery = "INSERT INTO users (Name, Username, Password, ContactNumber, Role) " +
                                     "VALUES (@Name, @Username, @Password, @ContactNumber, @Role)";
                var insertParams = new Dictionary<string, object>
                {
                    { "@Name", name },
                    { "@Username", username },
                    { "@Password", password }, // Consider hashing password in real app
                    { "@ContactNumber", contactNumber },
                    { "@Role", role }
                };

                db.ExecuteQuery(insertQuery, insertParams);
                MessageBox.Show("User registered successfully!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration failed: {ex.Message}", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

