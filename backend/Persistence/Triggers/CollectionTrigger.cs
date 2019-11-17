using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore;
using Persistence.Repository;

namespace Persistence.Triggers
{
    public class CollectionTrigger
    {
        public static async Task OnDeletingCollection(IDeletingEntry<Collection, DbContext> entity, DefaultDataContext DataContext) 
        {
            var problems = await DataContext.Problems.Where(p => p.Type == nameof(entity.Entity.Type) && p.TypeId == entity.Entity.TypeId).ToListAsync();
                if(problems.Count > 0)
                    DataContext.Problems.RemoveRange(problems);

            var ideas = await DataContext.Ideas.Where(p => p.Type == nameof(entity.Entity.Type) && p.TypeId == entity.Entity.TypeId).ToListAsync();
                if(ideas.Count > 0)
                    DataContext.Ideas.RemoveRange(ideas);

            var projects = await DataContext.Projects.Where(p => p.Type == nameof(entity.Entity.Type) && p.TypeId == entity.Entity.TypeId).ToListAsync();
                if(projects.Count > 0)
                    DataContext.Projects.RemoveRange(projects);

            var photos = await DataContext.Photos.Where(p => p.Type == nameof(entity.Entity.Type) && p.TypeId == entity.Entity.TypeId).ToListAsync();
                if(photos.Count > 0)
                    DataContext.Photos.RemoveRange(photos);

            var work = await DataContext.Works.Where(p => p.UserId == entity.Entity.TypeId).ToListAsync();
                if(work.Count > 0)
                    DataContext.Works.RemoveRange(work);
        }
    }
}