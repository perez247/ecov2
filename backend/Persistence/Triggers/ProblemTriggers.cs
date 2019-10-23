using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore;
using Persistence.Repository;

namespace Persistence.Triggers
{
    public class ProblemTriggers
    {
        public static async Task OnDeletingProblem(IDeletingEntry<Problem, DbContext> entity, DefaultDataContext DataContext) {
            var ecoDetail = await DataContext.EcoDetails.SingleOrDefaultAsync(e => e.Type == nameof(Problem) && e.TypeId == entity.Entity.Id);
            if (ecoDetail != null)
                DataContext.EcoDetails.Remove(ecoDetail);

            
            var address = await DataContext.Addresses.SingleOrDefaultAsync(e => e.Type == nameof(Problem) && e.TypeId == entity.Entity.Id);
            if (address != null)
                DataContext.Addresses.Remove(address);
            

            var projectsUrls = await DataContext.ProjectUrls.Where(p => p.Type == nameof(Problem) && p.TypeId == entity.Entity.Id).ToListAsync();
            if (projectsUrls.Count > 0)
                DataContext.ProjectUrls.RemoveRange(projectsUrls);

            var photos = await DataContext.Photos.Where(p => p.Type == nameof(Problem) && p.TypeId == entity.Entity.Id).ToListAsync();
            if (photos.Count > 0)
                DataContext.Photos.RemoveRange(photos);

            var votes = await DataContext.Votes.Where(p => p.Type == nameof(Problem) && p.TypeId == entity.Entity.Id).ToListAsync();
            if (votes.Count > 0)
                DataContext.Votes.RemoveRange(votes);

            var comments = await DataContext.Comments.Where(p => p.Type == nameof(Problem) && p.TypeId == entity.Entity.Id).ToListAsync();
            if (comments.Count > 0)
                DataContext.Comments.RemoveRange(comments);
        }
    }
}