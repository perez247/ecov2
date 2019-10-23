using System;

namespace Domain.Entities
{
    public class OrganizationRole
    {
        public Guid Id { get; set; }

        // null if its ment for the public
        public Guid BranchId { get; set; }

        //  null if its ment for the public role
        public Guid HeadQuarterId { get; set; }

        public string Name { get; set; }
    }
}

