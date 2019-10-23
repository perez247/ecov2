using System;

namespace Domain.Entities
{
    public class Vote
    {
        // From Likes
        // Id,ProblemBetaId,UserId
        public Guid Id { get; set; }
        
        // User
        public Guid TypeId { get; set; }
        public string Type { get; set; }

        // Problem
        public Guid VoterTypeId { get; set; }
        public string VoterType { get; set; }
    }
}