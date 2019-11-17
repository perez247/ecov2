using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    /// <summary>
    /// 
    /// When organization is created if this is the first to be created then there is a need to manually verify the 
    /// organization.
    /// 
    /// Irresptive of the branch that was created first, the first becomes the headquarters and can be used to verify other branches . One of the headquarters
    /// functions is to verify other branches. Any verified branch can be made an HeadQuarters by the owners of the company. 
    /// A headquarters not verified cannot verify any other branch.
    /// 
    /// If a branch is the headquarters it cannot be deleted
    /// Once an organization is deleted:
    ///         Organsation role, organisation role type, collections, address and contacts
    /// 
    /// </summary>
    public class OrganizationDetail
    {
        public Guid Id { get; set; }
        public String Name { get; set; }        
        
        // User
        public Guid? TypeId { get; set; }
        public string Type { get; set; }
        public virtual Address Address { get; set; }
        public virtual Contact Contact { get; set; }
        public Guid HeadQuaters { get; set; }
        public bool Verified { get; set; }
        public virtual Collection Collection { get; set; }
        public OrganizationDetail()
        {}
    }
}