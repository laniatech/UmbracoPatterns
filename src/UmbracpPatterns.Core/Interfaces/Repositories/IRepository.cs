using System.Collections.Generic;

namespace UmbracoPatterns.Core.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> List();
        TEntity GetByID(int id);
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        void DeleteById(int id);
    }
}