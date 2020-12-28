using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.DataAccess.Abstract
{
    public interface IGenericDal<TEntity> where TEntity : class, new()
    {
        Task<TEntity> GetById(int id);
        Task<List<TEntity>> GetAll();
        Task Create(TEntity entity);
        void Update(TEntity entity);
        Task Delete(TEntity entity);
    }
}
