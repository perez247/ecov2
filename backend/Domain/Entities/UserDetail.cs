using System;

namespace Domain.Entities
{
    public class UserDetail
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public virtual Address Address { get; set; }
        public virtual Contact Contact { get; set; }
    }
}