using System;

namespace Domain.Entities.Verification
{
    /// <summary>
    /// Once user enters a work place (i.e. an entry in the ../Work.cs Table)
    /// Then create an entry in this table. This acts as a request from the user
    /// and also a notification to the organization.
    /// 
    /// Once answered (i.e. organization has accepted the user's request by changing Validated to true)
    /// Then the Answered will be true. Create a role for that user as a member.
    /// 
    /// Answering should remove the entry as a new/unanswered notification from a user. 
    /// 
    /// User can be removed from an organization by removing every role they are in an aorganization.
    /// </summary>
    public class WorkVerification : BaseVerification
    {
        public Guid WorkId { get; set; }
    }
}