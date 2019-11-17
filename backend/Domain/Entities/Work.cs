using System;

namespace Domain.Entities
{
    /// <summary>
    /// This class is a table in the database and responsible
    /// for creating/storing a request to be made to the 
    /// organization to verify if user is part of that organization
    /// 
    /// Once request is made, am entry will be made on the ./Verification/WorkVerification.cs (Table)
    /// Check file for details about it. Purpose is for the organization to update entry
    /// 
    /// This verifies the user's by switiching the verified property from false to true
    /// </summary>
    public class Work
    {
        public Guid Id { get; set; }
        public string Position { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
        public OrganizationDetail Organization { get; set; }
        public Guid OrganizationId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Verified { get; set; }
    }
}