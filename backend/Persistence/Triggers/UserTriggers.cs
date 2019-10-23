using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore;
using Persistence.Repository;

namespace Persistence.Triggers
{
    public class UserTriggers
    {
        public static async Task OnDeletingUser(IDeletingEntry<User, DbContext> entity, DefaultDataContext DataContext) {
            
            var address = await DataContext.Addresses.SingleOrDefaultAsync(c => c.Type == nameof(User) && c.TypeId == entity.Entity.Id);
                if(address != null)
                    DataContext.Addresses.Remove(address);

            var contact = await DataContext.Contacts.SingleOrDefaultAsync(c => c.Type == nameof(User) && c.TypeId == entity.Entity.Id);
                if(contact != null)
                    DataContext.Contacts.Remove(contact);

            var collections = await DataContext.Collections.SingleOrDefaultAsync(c => c.Type == nameof(User) && c.TypeId == entity.Entity.Id);
                if(collections != null)
                    DataContext.Collections.Remove(collections);

            var problems = await DataContext.Problems.Where(p => p.Type == nameof(User) && p.TypeId == entity.Entity.Id).ToListAsync();
                if(problems.Count > 0)
                    DataContext.Problems.RemoveRange(problems);

            var projects = await DataContext.Projects.Where(p => p.Type == nameof(User) && p.TypeId == entity.Entity.Id).ToListAsync();
                if(projects.Count > 0)
                    DataContext.Projects.RemoveRange(projects);

            var photos = await DataContext.Photos.Where(p => p.Type == nameof(User) && p.TypeId == entity.Entity.Id).ToListAsync();
                if(photos.Count > 0)
                    DataContext.Photos.RemoveRange(photos);

            var organizationTypeRoles = await DataContext.OrganizationTypeRoles.Where(p => p.Type == nameof(User) && p.TypeId == entity.Entity.Id).ToListAsync();
                if(organizationTypeRoles.Count > 0)
                    DataContext.OrganizationTypeRoles.RemoveRange(organizationTypeRoles);

        }
    }
}