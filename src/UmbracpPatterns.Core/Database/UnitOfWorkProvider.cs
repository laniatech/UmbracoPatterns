using UmbracoPatterns.Core.Interfaces;

namespace UmbracoPatterns.Core.Database
{
    public class UnitOfWorkProvider : IUnitOfWorkProvider
    {
        private readonly IDbFactory _dbFactory;

        public UnitOfWorkProvider(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public IUnitOfWork GetUnitOfWork()
        {
            return new UnitOfWork(_dbFactory);
        }
    }
}