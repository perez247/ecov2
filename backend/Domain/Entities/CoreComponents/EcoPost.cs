using System.Collections.Generic;

namespace Domain.Entities.CoreComponents
{
    public class EcoPost : Post
    {
        public EcoDetails EcoDetails { get; set; }
                
        // Address
        public Address Address { get; set; }
        public ICollection<ProjectUrl> ProjectUrls { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<Vote> Votes { get; set; }        
        public ICollection<Comment> Comments { get; set; }

        public EcoPost()
        {
            ProjectUrls = new HashSet<ProjectUrl>();
            Photos = new HashSet<Photo>();
            Votes = new HashSet<Vote>();
            Comments = new HashSet<Comment>();
        }
    }
}