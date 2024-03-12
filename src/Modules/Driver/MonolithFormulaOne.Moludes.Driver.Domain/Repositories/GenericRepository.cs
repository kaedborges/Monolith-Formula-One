using MonolithFormulaOne.Shared.Abstractions.Repository;

namespace MonolithFormulaOne.Moludes.Driver.Domain.Repositories;

public class GenericRepository<TResult> : IGenericRepository<TResult> where TResult : class
{
    public Task<IEnumerable<TResult>> All()
    {
        throw new NotImplementedException();
    }

    public Task<TResult?> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task Add(TResult entity)
    {
        throw new NotImplementedException();
    }

    public Task<TResult> Update(TResult entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}