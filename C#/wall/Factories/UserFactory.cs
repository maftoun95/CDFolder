using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using wall.Models;
using Microsoft.Extensions.Options;

namespace wall.Factory {
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
                string query =  "INSERT INTO user (firstname, lastname, email, password, created_at, updated_at) VALUES (@FirstName, @LastName, @Email, @password, NOW(), NOW())";
                dbConnection.Open();
                dbConnection.Execute(query, user);
            }
        }
        public User FetchUser(string email){
            using (IDbConnection dbConnection = Connection) {
                string query = $"SELECT * FROM user WHERE email = '{email}'";
                dbConnection.Open();
                User tester = dbConnection.QuerySingleOrDefault<User>(query);
                return tester;
            }
        }
        public User UIDFetcher(int uid){
            using (IDbConnection dbConnection = Connection) {
                string query = $"SELECT * FROM user WHERE id = '{uid}'";
                dbConnection.Open();
                User tester = dbConnection.QuerySingleOrDefault<User>(query);
                return tester;
            }
        }
        public void addMessage(Message messi, int uid){
            using (IDbConnection dbConnection = Connection){
                string query =  $"INSERT INTO messages (uid, text, created_at, updated_at) VALUES ( {uid}, {messi.text}, NOW(), NOW())";
                dbConnection.Open();
                dbConnection.Execute(query);
            }
        }
        public bool isRegistered(string email) {
            User logged = FetchUser(email);
            return logged != null;
        }
    }
}