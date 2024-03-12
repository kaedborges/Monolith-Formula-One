namespace MonolithFormulaOne.Shared.Abstractions.Repository;

public interface IGenericRepository<TResult> where TResult : class
{
    Task<IEnumerable<TResult>> All();
    Task<TResult?> GetById(Guid id);
    Task Add(TResult entity);
    Task<TResult> Update(TResult entity);
    Task<bool> Delete(Guid id);
}