using SeguradoraUno.Domain.Entities;
using SeguradoraUno.Domain.Interfaces.Repository;
using SeguradoraUno.Repo.Persistence;
using System.Collections.Generic;
using System.Data.Entity;

namespace SeguradoraUno.Repo.Data.Repository
{
    public class PessoaEnderecoRepository : Repository<PessoaEndereco>, IPessoaEnderecoRepository
    {
        #region "Constructor"

        public PessoaEnderecoRepository(SuDbContext dbContext)
            : base(dbContext)
        {

        }

        #endregion


        #region "Methods"

        public IEnumerable<PessoaEndereco> GetPessoaEnderecos()
        {
            return this._dbContext.PessoaEnderecos.Include(p => p.Pessoa);
        }

        #endregion
    }
}
