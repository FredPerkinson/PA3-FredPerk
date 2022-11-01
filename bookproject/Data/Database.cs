using database.Models;
namespace database.data
{
    public class Database
    {
        private string cs {get; set;}
        public Database() {
            ConnectionString connectionString = new ConnectionString();
            cs = connectionString.cs;
        }
    }
}