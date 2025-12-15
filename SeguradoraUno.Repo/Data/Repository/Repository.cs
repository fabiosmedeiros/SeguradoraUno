using SeguradoraUno.Domain.Interfaces.Repository;
using SeguradoraUno.Repo.Persistence;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SeguradoraUno.Repo.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        #region "Attributes"

        protected readonly SuDbContext _dbContext;

        private readonly DbSet<TEntity> _dbSet;

        #endregion


        #region "Constructor"

        public Repository(SuDbContext dbContext)
        {
            this._dbContext = dbContext;
            this._dbSet = this._dbContext.Set<TEntity>();
        }

        #endregion


        #region "Create"

        public void Add(TEntity entity)
        {
            this._dbSet.Add(entity);
        }

        #endregion


        #region "Recovery"

        public TEntity GetById(object id)
        {
            return this._dbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this._dbSet.ToList();
        }

        #endregion


        #region "Update"

        public void Update(TEntity entity)
        {
            this._dbSet.Attach(entity);

            this._dbContext.Entry(entity).State = EntityState.Modified;
        }

        #endregion


        #region "Delete"

        public void Delete(object id)
        {
            TEntity entity = this._dbSet.Find(id);

            Delete(entity);
        }

        public void Delete(TEntity entity)
        {
            if (this._dbContext.Entry(entity).State == EntityState.Detached)
            {
                this._dbSet.Attach(entity);
            }

            this._dbSet.Remove(entity);
        }

        #endregion
    }
}
