namespace Infrastructure.InMemoryDataAccess
{
    using Application.Base;
    using System;
    using System.Threading.Tasks;

    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly CleanArchContext _context;

        public UnitOfWork(CleanArchContext context)
        {
            _context = context;
        }

        public async Task<int> SaveAsync()
        {
            return await Task.FromResult<int>(0);
        }
    }
}
