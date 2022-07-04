using System.Linq.Expressions;

namespace HorsePowerLtd.Services.IRepository.Global
{
    public interface IRepository<T> where T : class
    {
        T GetSingleRecord(Expression<Func<T, bool>> filter, string? includeProperties = null);

        IEnumerable<T> GetAllRecords(string? includeProperties = null);

        void CreateRecord(T entity);

        void DeleteRecord(T entity);

        void RemoveMultipleRecords(IEnumerable<T> entities);

        void DefaultUpdateRecord(T entity);
    }
}