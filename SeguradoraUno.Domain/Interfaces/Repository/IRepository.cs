using System.Collections.Generic;

namespace SeguradoraUno.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        #region "Create"

        void Add(TEntity entity);

        #endregion


        #region "Recovery"

        TEntity GetById(object id);

        IEnumerable<TEntity> GetAll();

        #endregion


        #region "Update"

        void Update(TEntity entity);

        #endregion


        #region "Delete"

        void Delete(object id);

        void Delete(TEntity entity);

        #endregion
    }
}
