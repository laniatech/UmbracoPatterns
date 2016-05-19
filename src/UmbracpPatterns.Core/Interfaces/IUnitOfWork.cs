using NPoco;
using System;

namespace UmbracoPatterns.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        IDatabase Db { get; }
    }
}