using SeguradoraUno.Domain.Entities;
using SeguradoraUno.Domain.Interfaces.Repository;
using SeguradoraUno.Repo.Persistence;
using System.Collections.Generic;
using System.Data.Entity;

namespace SeguradoraUno.Repo.Data.Repository
{
    public class PessoaContatoRepository : Repository<PessoaContato>, IPessoaContatoRepository
    {
        #region "Constructor"

        public PessoaContatoRepository(SuDbContext dbContext)
            : base(dbContext)
        {

        }

        #endregion


        #region "Methods"

        public IEnumerable<PessoaContato> GetPessoaContatos()
        {
            return this._dbContext.PessoaContatos.Include(p => p.Pessoa);
        }

        #endregion
    }
}
