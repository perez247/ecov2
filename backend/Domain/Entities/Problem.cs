using System;
using System.Collections.Generic;
using Domain.Entities.CoreEntities;

namespace Domain.Entities
{
    public class Problem
    {
        // From ProblemBeta
        // Id,Description,Eco,EcoUn,EcoUnOther,Ico,IcoOther,CountryId,StateId,Deleted,UserId,DateCreated,DateModified
        public Guid Id { get; set; }
        public string Description { get; set; }

        public EcoDetails EcoDetails { get; set; }

        // DateTime
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        // Address
        public Address Address { get; set; }

        // User
        public Guid? TypeId { get; set; }
        public string Type { get; set; }

        public ICollection<ProjectUrl> ProjectUrls { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<Vote> Votes { get; set; }        
        public ICollection<Comment> Comments { get; set; }

        public Problem()
        {
            ProjectUrls = new HashSet<ProjectUrl>();
            Photos = new HashSet<Photo>();
            Votes = new HashSet<Vote>();
            Comments = new HashSet<Comment>();
        }
    }
}