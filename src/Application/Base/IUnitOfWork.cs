namespace Application.Base
{
    using System.Threading.Tasks;

    public interface IUnitOfWork
    {
        Task<int> SaveAsync();
    }
}