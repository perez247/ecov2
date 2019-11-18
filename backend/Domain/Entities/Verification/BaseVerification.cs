using System;

namespace Domain.Entities.Verification
{
    public class BaseVerification
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Validated { get; set; }
        public bool Answered { get; set; }
    }
}