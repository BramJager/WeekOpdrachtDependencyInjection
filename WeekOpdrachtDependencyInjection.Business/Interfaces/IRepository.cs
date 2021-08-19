using System.Collections.Generic;

namespace WeekOpdrachtDependencyInjection.Business.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Delete(TEntity entity);
        void Delete(int id);
        List<TEntity> GetAll();
        TEntity Get(int id);
        TEntity Get(string name);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Save();
    }
}
