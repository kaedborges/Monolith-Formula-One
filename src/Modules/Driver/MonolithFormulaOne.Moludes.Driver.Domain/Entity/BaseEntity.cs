namespace MonolithFormulaOne.Moludes.Driver.Domain.Entity;

public class BaseEntity : Shared.Abstractions.Entity.Entity
{
    public DateTime AddedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
    public int Stautus { get; set; }
    
    protected BaseEntity(Guid id) : base(id)
    {
    }
}