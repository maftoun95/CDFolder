using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore.Extensions;

namespace efcrud.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Person> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string Server = "localhost";
            string Port = "3306";
            string Database = "efcrud";
            string UserId = "root";
            string Password = "root";
            string Connection = $"Server={Server};port={Port};database={Database};uid={UserId};pwd={Password};";
            optionsBuilder.UseMySQL(Connection);
        }
    }
}