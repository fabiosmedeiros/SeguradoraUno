using SeguradoraUno.Domain.Entities;
using SeguradoraUno.Domain.Interfaces.Repository;
using SeguradoraUno.Repo.Persistence;

namespace SeguradoraUno.Repo.Data.Repository
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        #region "Constructor"

        public PessoaRepository(SuDbContext dbContext)
            : base(dbContext)
        {
            
        }

        #endregion
    }
}
