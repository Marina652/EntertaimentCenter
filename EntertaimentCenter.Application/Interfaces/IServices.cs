using EntertaimentCenter.Application.Entities;

namespace EntertaimentCenter.Application.Interfaces;

public interface IServices<T>
    where T : BaseEntity
{
    /// <summary>
    /// Method for create data.
    /// </summary>
    /// <param name="obj">Generic type.</param>
    /// <returns>Object.</returns>
    Task<int> Create(T obj, CancellationToken token = default);

    /// <summary>
    /// Method for delete data.
    /// </summary>
    /// <param name="id">ID.</param>
    public Task<bool> Delete(int id, CancellationToken token = default);

    /// <summary>
    /// Method for update data.
    /// </summary>
    /// <param name="obj">generic type.</param>
    /// <returns>Object.</returns>
    public Task<T> Update(T obj, CancellationToken token = default);

    /// <summary>
    /// Method for select all data about object.
    /// </summary>
    /// <returns>IEnumerable.</returns>
    public Task<List<T>> SelectAll(CancellationToken token = default);

    public Task<T> FindById(int id, CancellationToken token = default);
}
