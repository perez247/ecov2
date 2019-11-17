using System;

namespace Domain.Entities
{
    /// <summary>
    /// Roles found in an organization
    /// </summary>
    public class OrganizationRole
    {
        public Guid Id { get; set; }

        public Guid BranchId { get; set; }

        public string Name { get; set; }
    }
}

