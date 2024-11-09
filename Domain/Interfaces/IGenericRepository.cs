using Domain.Entities;

namespace Domain.Interfaces;

public interface IGenericRepository<T> where T : BaseRecord
{
    Task<IEnumerable<T>> GetAll();
}