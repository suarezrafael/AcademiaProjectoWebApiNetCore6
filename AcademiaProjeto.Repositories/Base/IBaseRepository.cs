using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaProjeto.Repositories.Base
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(int Id, T entity);
        Task DeleteAsync(int Id);
        Task<T> GetByIdAsync(int Id);
        Task<IEnumerable<T>> GetAll();
    }
}
