using UmbracoPatterns.Core.Interfaces;
using NPoco;

namespace UmbracoPatterns.Core.Database
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ITransaction _petaTransaction;
        private readonly IDatabase _db;

        public UnitOfWork(IDbFactory dbFactory)
        {
            _db = dbFactory.GetDatabase();
            _petaTransaction = _db.GetTransaction();
        }

        public void Dispose()
        {
            _petaTransaction.Dispose();
        }

        public IDatabase Db
        {
            get { return _db; }
        }

        public void Commit()
        {
            _petaTransaction.Complete();
        }
    }
}