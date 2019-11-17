using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore;
using Persistence.Repository;

namespace Persistence.Triggers
{
    public class OrganizationTrigger
    {
        public static async Task OnDeletingOrganization(IDeletingEntry<OrganizationDetail, DbContext> entity, DefaultDataContext DataContext) {
            
            var address = await DataContext.Addresses.SingleOrDefaultAsync(c => c.Type == nameof(OrganizationDetail) && c.TypeId == entity.Entity.Id);
                if(address != null)
                    DataContext.Addresses.Remove(address);

            var contact = await DataContext.Contacts.SingleOrDefaultAsync(c => c.Type == nameof(OrganizationDetail) && c.TypeId == entity.Entity.Id);
                if(contact != null)
                    DataContext.Contacts.Remove(contact);

            var collections = await DataContext.Collections.SingleOrDefaultAsync(c => c.Type == nameof(OrganizationDetail) && c.TypeId == entity.Entity.Id);
                if(collections != null)
                    DataContext.Collections.Remove(collections);

            var organizationTypeRoles = await DataContext.OrganizationTypeRoles.Where(p => p.OrganizationId == entity.Entity.Id).ToListAsync();
                if(organizationTypeRoles.Count > 0)
                    DataContext.OrganizationTypeRoles.RemoveRange(organizationTypeRoles);

            var organizationRoles = await DataContext.OrganizationRoles.Where(p => p.BranchId == entity.Entity.Id).ToListAsync();
                if(organizationRoles.Count > 0)
                    DataContext.OrganizationRoles.RemoveRange(organizationRoles);

            var organizationVerification = await DataContext.OrganizationVerifications.Where(p => p.OrganizationDetailId == entity.Entity.Id).ToListAsync();
                if(organizationVerification.Count > 0)
                    DataContext.OrganizationVerifications.RemoveRange(organizationVerification);
            
            if(entity.Entity.HeadQuaters == entity.Entity.Id) {
                var branches = await DataContext.OrganizationDetails.Where(p => p.HeadQuaters == entity.Entity.Id).ToListAsync();
                if (branches.Count > 0)
                    DataContext.OrganizationDetails.RemoveRange(branches);
            }

        }
    }
}