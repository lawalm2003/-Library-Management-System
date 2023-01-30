using LMS.Domain.MODELS;
using LMS.Domain.Repositories;
using LMS.Persistence.EF_Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Persistence.Repositories
{
    public class BaseRepo<T> : IBaseRepo<T> where T : ModelBase
    {
        private readonly LMSContext _context;

        public BaseRepo(LMSContext context)
        {
            _context = context;
        }
        public async Task<bool> Add(T entity)
        {
            _context.Set<T>().Add(entity);
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Delete(int id)
        {
            var entity =  _context.Set<T>().Find(id);
            try
            {
                if (entity != null)
                {
                    _context.Remove(entity);
                    await _context.SaveChangesAsync();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }       

        public async Task<List<T>> FindByPredicate(Expression<Func<T, bool>> predicate)
        {
           return await _context.Set<T>().Where(predicate).ToListAsync();
        }

        public virtual async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().OrderBy(p => p.Id).ToListAsync();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<bool> Update(T entity)
        {
            _context.Set<T>().Update(entity);
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        
    }
}
