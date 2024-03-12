namespace MonolithFormulaOne.Moludes.Driver.Domain.Repositories.Interfaces;

public interface IUnitOfWork
{
    IDriverRepository Drivers { get; }

    Task<bool> CompleteAsync();
}