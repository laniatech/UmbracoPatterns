using NPoco;

namespace UmbracoPatterns.Core.Interfaces
{
    public interface IDbFactory
    {
        IDatabase GetDatabase();
    }
}