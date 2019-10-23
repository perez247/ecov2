using System;
using System.Collections.Generic;

namespace Domain.Entities
{
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