using System;

namespace Domain.Entities
{
    /// <summary>
    /// Comments made on another entity
    /// 
    /// Type and TypeId represents the entity (Table/class) making the comment
    /// 
    /// TargetType and TargetTypeId represents the entity (Table/class) the comment is made for
    ///  
    /// </summary>
    public class Comment
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public Guid TypeId { get; set; }
        public string TargetType { get; set; }
        public Guid TargetTypeId { get; set; }
        public string Message { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        
    }
}