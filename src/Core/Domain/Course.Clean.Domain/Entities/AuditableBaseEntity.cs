namespace Course.Clean.Domain.Entities
{
    public class AuditableBaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime? ModifyDate { get; set; }
    }
}