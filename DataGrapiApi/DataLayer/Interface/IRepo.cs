using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrapiApi.DataLayer.Interface
{
    interface IRepo<T> where T : class, IEntity
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}
