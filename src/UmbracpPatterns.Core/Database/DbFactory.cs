using UmbracoPatterns.Core.Interfaces;
using NPoco;

namespace UmbracoPatterns.Core.Database
{
    public class DbFactory : IDbFactory
    {
        private readonly string _connectionString;

        public DbFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDatabase GetDatabase()
        {
            return new NPoco.Database(_connectionString);
        }
    }
}