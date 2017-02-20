using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using loginReg.Models;

namespace loginReg.Factory {
    public class UserFactory : IFactory<User> {
        private string connectionString;
        public UserFactory() {
            connectionString = "server=localhost;userid=root;password=root;port=3306;database=loginReg;SslMode=None";
        }
        internal IDbConnection Connection {
            get {
                return new MySqlConnection(connectionString);
            }
        }
        public void Add(User user) { //time to test it
            using (IDbConnection dbConnection = Connection) {
                string query =  "INSERT INTO user (fistname, lastname, email, password) VALUES (@FirstName, @LastName, @Email, @password)";
                dbConnection.Open();
                dbConnection.Execute(query, user);
            }
        }
    }
}