using System;

namespace Domain.Entities.Verification
{
    public class OrganizationVerification : BaseVerification
    {
        /// <summary>
        /// 
        /// Once an organisation is created an entry will be created in this table
        /// if this is the first organization then we manually verify the organization and change the validated and answered to true
        /// 
        /// Branch can be verified by the headquarters.!-- This can be done by changing the property of validated and
        /// answered to true
        /// 
        /// </summary>
        public Guid OrganizationDetailId { get; set; }
        public VerificationType RequestType { get; set; }
    }

    public enum VerificationType { 
        VerifyOrganization,
        ChangeHeadQuarters
     };
}