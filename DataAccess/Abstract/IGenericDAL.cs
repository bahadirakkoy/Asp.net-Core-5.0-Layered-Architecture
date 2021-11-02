using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGenericDAL<T> where T : class, IEntity, new()
    {
        Task<T> GetByIdAsnyc(int id);

        Task<T> GetAsnyc(Expression<Func<T, bool>> predicate);
        Task<int> GetCountAsnyc(Expression<Func<T, bool>> predicate = null);
        Task<List<T>> GetListAsnyc(Expression<Func<T, bool>> predicate = null, int limit = 100);

        Task AddAsnyc(T entity);
        Task AddRangeAsnyc(List<T> entities);
        Task UpdateAsnyc(T entity);
        Task UpdateRangeAsnyc(List<T> entities);
        Task RemoveAsnyc(int id);
        Task RemoveAsnyc(T entity);
        Task RemoveRangeAsnyc(List<T> entities);

        T GetById(int id);

        T Get(Expression<Func<T, bool>> predicate);
        int GetCount(Expression<Func<T, bool>> predicate = null);
        List<T> GetList(Expression<Func<T, bool>> predicate = null, int limit = 100);

        void Add(T entity);
        void AddRange(List<T> entities);
        void Update(T entity);
        void UpdateRange(List<T> entities);
        void Remove(int id);
        void Remove(T entity);
        void RemoveRange(List<T> entities);
    }
}