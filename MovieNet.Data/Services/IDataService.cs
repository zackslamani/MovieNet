using System;
using System.Collections.Generic;
using System.Text;
using MovieNet.Data.Models;
using System.Threading.Tasks;

namespace MovieNet.Data.Services
{
    public interface IDataService<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Create(T entity);
        Task<T> Update(int id, T entity);
        Task<bool> Delete(int id);
    }
}
