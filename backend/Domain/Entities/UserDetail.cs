using System;

namespace Domain.Entities
{
    public class UserDetail
    {
        
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        // 0 = Male, 1 = Female, 2 = I dont want to answer
        public Byte Gender { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public virtual Address Address { get; set; }
        public virtual Contact Contact { get; set; }
        public DateTime DateCreated { get; set; }
    }
}