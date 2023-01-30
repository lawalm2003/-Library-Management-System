using LMS.Domain.MODELS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Repositories
{
    public interface IBaseRepo<T> where T : ModelBase
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<List<T>> FindByPredicate(Expression<Func<T,bool>> predicate);
        Task<bool> Add(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(int id);        
    }
}
