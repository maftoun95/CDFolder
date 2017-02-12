using System.Collections.Generic;
using System.Data.Common;
using MySql.Data.MySqlClient;
//remember, the Database needs to be added to the project dependencies in the project.json file.


namespace DbConnection
{
    public class DbConnector
    {
        public static List<Dictionary<string, object>> ExecuteQuery(string queryString)
        {
            //important moves are setting the port listening, p/w
            //most of this info can be found from the our running
            // MAMP instance
            string server = "localhost";
            string db = "users";
            string port = "3306";
            string user = "root";
            string pass = "root";
            using(var connection = new MySqlConnection(
                $"Server={server};Database={db};Port={port};UserID={user};Password={pass};"))
            {
                connection.Open();
                using(var command = new MySqlCommand(queryString, connection))
                {
                    var result = new List<Dictionary<string, object>>();
                    using(DbDataReader rdr = command.ExecuteReader())
                    {
                        while(rdr.Read())
                        {
                            var dict = new Dictionary<string, object>();
                            for( int i = 0; i < rdr.FieldCount; i++ ) {
                                dict.Add(rdr.GetName(i), rdr.GetValue(i));
                            }
                            result.Add(dict);
                        }
                    }
                    return result;
                }
            }
        }
    }
}
