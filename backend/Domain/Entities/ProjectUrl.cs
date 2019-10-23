using System;

namespace Domain.Entities
{
    public class ProjectUrl
    {
        public Guid Id { get; set; }
        public string Titile { get; set; }
        public string Url { get; set; }
        public Guid TypeId { get; set; }
        public string Type { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}