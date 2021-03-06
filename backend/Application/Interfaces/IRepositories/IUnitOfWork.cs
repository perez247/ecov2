using System;
using System.Threading.Tasks;

namespace Application.Interfaces.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        ILocationRepository Location { get; set; }
        Task<bool> Complete();
    }
}