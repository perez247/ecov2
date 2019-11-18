using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore;
using Persistence.Repository;

namespace Persistence.Triggers
{
    public class WorkTrigger
    {
        public static async Task OnDeletingWork(IDeletingEntry<Work, DbContext> entity, DefaultDataContext DataContext) {
        
            var workVerification = await DataContext.WorkVerifications.Where(w => w.WorkId == entity.Entity.Id).ToListAsync();
            if(workVerification.Count > 0)
                DataContext.WorkVerifications.RemoveRange(workVerification);
        }
    }
}