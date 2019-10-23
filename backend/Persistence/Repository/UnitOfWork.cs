using System.Threading.Tasks;
using Application.Interfaces.IRepositories;

namespace Persistence.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DefaultDataContext _context;
        public ILocationRepository Location { get; set; }

        public UnitOfWork(DefaultDataContext context)
        {
            _context = context;
            Location = new LocationRepository(_context);
        }

        public async Task<bool> Complete()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}