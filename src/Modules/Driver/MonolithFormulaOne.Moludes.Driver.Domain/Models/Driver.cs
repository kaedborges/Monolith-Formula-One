

using MonolithFormulaOne.Moludes.Driver.Domain.Entity;

namespace MonolithFormulaOne.Moludes.Driver.Domain.Models;

public class Driver : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int DriverNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    
    protected Driver(Guid id) : base(id)
    { }
}