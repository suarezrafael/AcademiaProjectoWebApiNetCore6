using AcademiaProjeto.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaProjeto.Repositories.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public DataContext _dataContext { get; set; }
        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<T> CreateAsync(T entity)
        {
            await _dataContext.Set<T>().AddAsync(entity);
            await _dataContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int Id)
        {
            var entity = await GetByIdAsync(Id);
            _dataContext.Set<T>().Remove(entity);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dataContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int Id)
        {
            return await _dataContext.Set<T>().FindAsync(Id);
        }

        public async Task<T> UpdateAsync(int Id, T entity)
        {
            _dataContext.Set<T>().Update(entity);
            await _dataContext.SaveChangesAsync();
            return entity;
        }
    }
}
