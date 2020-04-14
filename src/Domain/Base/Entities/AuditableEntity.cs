using System;

namespace Domain.Base.Entities
{
    public class AuditableEntity : IAuditableEntity
    {
        public long Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
    }
}
