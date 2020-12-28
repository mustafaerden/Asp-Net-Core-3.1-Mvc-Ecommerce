using Azlan.Ecommerce.DataAccess.Abstract;
using Azlan.Ecommerce.DataAccess.Concrete.EfCore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.DataAccess.Concrete.EfCore.Repositories
{
    public class EfCoreGenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class, new()
    {
        public async Task Create(TEntity entity)
        {
            using var context = new ApplicationDbContext();

            await context.Set<TEntity>().AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(TEntity entity)
        {
            using var context = new ApplicationDbContext();

            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAll()
        {
            using var context = new ApplicationDbContext();

            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            using var context = new ApplicationDbContext();

            return await context.Set<TEntity>().FindAsync(id);
        }

        // virtual yazarsak bu metodu istegimiz gibi override edebiliriz!
        public virtual void Update(TEntity entity)
        {
            using var context = new ApplicationDbContext();

            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
