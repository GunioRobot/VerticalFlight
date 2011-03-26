using System.Linq;

namespace VerticalFlight.Core.Data
{
    public interface Repository
    {
        IQueryable<T> All<T>();
        void Save<T>(T item);
        void Delete<T>(T item);
    }
}