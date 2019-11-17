using System;

namespace Domain.Entities
{
    /// <summary>
    /// 
    /// Roles assigned to users in an organization
    /// 
    /// </summary>
    public class OrganizationTypeRole
    {
        public Guid Id { get; set; }
        public Guid TypeId { get; set; }
        public string Type { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid OrganizationRoleId { get; set; }
    }
}