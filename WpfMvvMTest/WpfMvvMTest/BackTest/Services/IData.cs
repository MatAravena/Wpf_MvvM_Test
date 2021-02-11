using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BackTest.Services
{
    public interface IData<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByID( int id);
        Task<T> Create(T entity);

        Task<T> Update(int id, T entity);
        Task<bool> Delete(int id);
    }
}
