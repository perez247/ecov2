using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Project
    {
        // Id,WebLink,Title,Description,Deleted,DateCreated,DateModified,UserId,ProblemBetaId        
        public Guid Id { get; set; }
        public string Description { get; set; }

        public virtual EcoDetails EcoDetails { get; set; }

        // DateTime
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        // Address
        public virtual Address Address { get; set; }

        // User
        public Guid? TypeId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<ProjectUrl> ProjectUrls { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }        
        public virtual ICollection<Comment> Comments { get; set; }

        public Project()
        {
            ProjectUrls = new HashSet<ProjectUrl>();
            Photos = new HashSet<Photo>();
            Votes = new HashSet<Vote>();
            Comments = new HashSet<Comment>();
        }
    }
}