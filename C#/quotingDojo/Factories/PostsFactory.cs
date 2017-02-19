using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using quotingDojo.Models;

namespace quotingDojo.Factory
{
    public class PostsFactory : IFactory<Posts>
    {
        private string connectionString;
        public PostsFactory()
        {
            connectionString = "server=localhost;userid=root;password=root;port=3306;database=quotingDojo;SslMode=None";
        }
        internal IDbConnection Connection
        {
            get {
                return new MySqlConnection(connectionString);
            }
        }
        public void Add(Posts item)
        {
            using (IDbConnection dbConnection = Connection) {
                string query =  "INSERT INTO posts (name, quote, created_at) VALUES (@name, @quote, NOW())";
                dbConnection.Open();
                dbConnection.Execute(query, item);
            }
        }
        public IEnumerable<Posts> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Posts>("SELECT * FROM posts ORDER BY created_at DESC");
            }
        }
    }
}
