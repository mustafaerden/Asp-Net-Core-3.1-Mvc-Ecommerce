using Azlan.Ecommerce.Business.Abstract;
using Azlan.Ecommerce.DataAccess.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, new()
    {
        private readonly IGenericDal<TEntity> _genericDal;

        public GenericManager(IGenericDal<TEntity> genericDal)
        {
           _genericDal = genericDal;
        }

        public async Task Create(TEntity entity)
        {
            await _genericDal.Create(entity);
        }

        public async Task Delete(TEntity entity)
        {
            await _genericDal.Delete(entity);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _genericDal.GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _genericDal.GetById(id);
        }

        public void Update(TEntity entity)
        {
            _genericDal.Update(entity);
        }
    }
}
