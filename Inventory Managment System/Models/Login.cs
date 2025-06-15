using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Inventory_Managment_System.Classes;
using Inventory_Managment_System;

namespace Inventory_Managment_System
{
    public class Login
    {
        private readonly DBconnection db;

        public Login()
        {
            db = new DBconnection();
        }

        public (bool IsValid, string Message) Authenticate(string username, string password, string selectedRole)
        {
            string query = "SELECT Role FROM users WHERE Username = @Username AND Password = @Password";
            var parameters = new Dictionary<string, object>
            {
                { "@Username", username },
                { "@Password", password }
            };

            DataTable result = db.GetData(query, parameters);

            if (result.Rows.Count > 0)
            {
                string roleFromDb = result.Rows[0]["Role"].ToString();

                if (roleFromDb.Equals(selectedRole, StringComparison.OrdinalIgnoreCase))
                {
                    return (true, "Login successful!");
                }
                else
                {
                    return (false, "Selected role does not match the user credentials.");
                }
            }

            return (false, "Invalid username or password.");
        }
    }
}
