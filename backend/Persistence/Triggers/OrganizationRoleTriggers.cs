using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore;
using Persistence.Repository;

namespace Persistence.Triggers
{
    public class OrganizationRoleTriggers
    {
        public static async Task OnDeletingOrganizationRole(IDeletingEntry<OrganizationRole, DbContext> entity, DefaultDataContext DataContext) {
            var organizationTypeRoles = await DataContext.OrganizationTypeRoles.Where(o => o.OrganizationRoleId == entity.Entity.Id).ToListAsync();
            if( organizationTypeRoles.Count > 0 )
                DataContext.OrganizationTypeRoles.RemoveRange(organizationTypeRoles);
        }
    }
}