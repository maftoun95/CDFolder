using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using loginReg.Models;
using Microsoft.Extensions.Options;

namespace loginReg.Factory {
    public class UserFactory : IFactory<User> {
        private readonly IOptions<MySqlOptions> mysqlConfig;
        public UserFactory(IOptions<MySqlOptions> conf) {
            mysqlConfig = conf;
        }
        internal IDbConnection Connection {
            get {
                return new MySqlConnection(mysqlConfig.Value.ConnectionString);
            }
        }
        public void Add(User user) {
            using (IDbConnection dbConnection = Connection) {
                string query =  "INSERT INTO User (firstname, lastname, email, password) VALUES (@FirstName, @LastName, @Email, @password)";
                dbConnection.Open();
                dbConnection.Execute(query, user);
            }
        }
        public User FetchUser(string email){
            using (IDbConnection dbConnection = Connection) {
                string query = $"SELECT * FROM User WHERE email = '{email}'";
                dbConnection.Open();
                User tester = dbConnection.QuerySingleOrDefault<User>(query, email);
                return tester;
            }
        }
        public bool isRegistered(string email) {
            User logged = FetchUser(email);
            return logged != null;
        }
    }
}