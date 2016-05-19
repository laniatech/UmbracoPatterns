namespace UmbracoPatterns.Core.Interfaces
{
    public interface IUnitOfWorkProvider
    {
        IUnitOfWork GetUnitOfWork();
    }
}