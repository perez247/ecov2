using System;

namespace Domain.Entities.CoreComponents
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Log { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Guid? TypeId { get; set; }
        public string Type { get; set; }
    }
}