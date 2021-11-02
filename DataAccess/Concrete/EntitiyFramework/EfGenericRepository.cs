using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace BilsemTeknik.DataAccess.Concrete.EntitiyFramework
{
    /*
     *
     *  Bahadır AKKÖY 2022 - abahad
     *
     */
    public class EfGenericRepository<TEntity, TContext> : IGenericDAL<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        private readonly TContext _context;
        public EfGenericRepository()
        {
            _context = new TContext();
        }
        public async Task AddAsnyc(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task AddRangeAsnyc(List<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
            await _context.SaveChangesAsync();
        }

        public async Task<TEntity> GetAsnyc(Expression<Func<TEntity, bool>> predicate) => await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);

        public async Task<TEntity> GetByIdAsnyc(int id) => await _context.Set<TEntity>().FindAsync(id);

        public Task<int> GetCountAsnyc(Expression<Func<TEntity, bool>> predicate = null) => (predicate!=null? _context.Set<TEntity>().CountAsync(predicate): _context.Set<TEntity>().CountAsync());

        public async Task<List<TEntity>> GetListAsnyc(Expression<Func<TEntity, bool>> predicate = null, int limit = 100)
        {
            return (predicate!=null) ? await _context.Set<TEntity>().Where(predicate).ToListAsync() : await _context.Set<TEntity>().Take(limit).ToListAsync();
        }

        public async Task RemoveAsnyc(int id)
        {
            var entity = await GetByIdAsnyc(id);
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsnyc(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveRangeAsnyc(List<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsnyc(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRangeAsnyc(List<TEntity> entities)
        {
            _context.Set<TEntity>().UpdateRange(entities);
            await _context.SaveChangesAsync();
        }


        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void AddRange(List<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
            _context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate) => _context.Set<TEntity>().FirstOrDefault(predicate);

        public TEntity GetById(int id) => _context.Set<TEntity>().Find(id);

        public int GetCount(Expression<Func<TEntity, bool>> predicate = null) => (predicate != null ? _context.Set<TEntity>().Count(predicate) : _context.Set<TEntity>().Count());

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> predicate = null, int limit = 100)
        {
            return (predicate != null) ? _context.Set<TEntity>().Where(predicate).ToList() : _context.Set<TEntity>().Take(limit).ToList();
        }

        public void Remove(int id)
        {
            _context.Set<TEntity>().Remove(GetById(id));
            _context.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public void RemoveRange(List<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void UpdateRange(List<TEntity> entities)
        {
            _context.Set<TEntity>().UpdateRange(entities);
            _context.SaveChanges();
        }
    }
}
