using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    /// <summary>
    /// A class/table that represent the list of entities it has.
    /// Its more like a one to many relationship
    /// </summary>
    public class Collection
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public Guid TypeId { get; set; }
        public virtual ICollection<Problem> Problems { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Idea> Ideas { get; set; }
        public virtual  ICollection<Photo> Photos { get; set; }
        public virtual ICollection<Work> Work { get; set; }
        public virtual ICollection<OrganizationDetail> Organizations { get; set; }

        public Collection()
        {
            Problems = new HashSet<Problem>();
            Ideas = new HashSet<Idea>();
            Photos = new HashSet<Photo>();
            Organizations = new HashSet<OrganizationDetail>();
        }
    }
}