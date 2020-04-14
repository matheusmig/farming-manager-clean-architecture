namespace Domain.Base.Entities
{
    using System;

    public interface IAuditableEntity
    {
        long Id { get; set; }
        string CreatedBy { get; set; }
        DateTime CreatedOnUtc { get; set; }
        string UpdatedBy { get; set; }
        DateTime? UpdatedOnUtc { get; set; }
    }
}
