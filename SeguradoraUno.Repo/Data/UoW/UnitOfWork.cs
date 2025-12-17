using SeguradoraUno.Domain.Interfaces.Repository;
using SeguradoraUno.Domain.Interfaces.UoW;
using SeguradoraUno.Repo.Data.Repository;
using SeguradoraUno.Repo.Persistence;

namespace SeguradoraUno.Repo.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        #region "Attributes"

        private readonly SuDbContext _dbContext;

        private bool isDisposed;

        #endregion


        #region "Constructor"

        public UnitOfWork()
        {
            this._dbContext = new SuDbContext();
            this.isDisposed = false;
        }

        #endregion


        #region "Repositories"

        private IPessoaRepository pessoas;

        private IPessoaEnderecoRepository pessoaEnderecos;

        private IPessoaContatoRepository pessoaContatos;


        public IPessoaRepository Pessoas
        {
            get
            {
                if (this.pessoas == null)
                {
                    this.pessoas = new PessoaRepository(this._dbContext);
                }

                return this.pessoas;
            }

            private set { }
        }

        public IPessoaEnderecoRepository PessoaEnderecos
        {
            get
            {
                if (this.pessoaEnderecos == null)
                {
                    this.pessoaEnderecos = new PessoaEnderecoRepository(this._dbContext);
                }

                return this.pessoaEnderecos;
            }

            private set { }
        }

        public IPessoaContatoRepository PessoaContatos
        {
            get
            {
                if (this.pessoaContatos == null)
                {
                    this.pessoaContatos = new PessoaContatoRepository(this._dbContext);
                }

                return this.pessoaContatos;
            }

            private set { }
        }

        #endregion


        #region "Save"

        public void Complete()
        {
            this._dbContext.SaveChanges();
        }

        #endregion


        #region Dispose

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (!this.isDisposed)
            {
                if (isDisposing)
                {
                    this._dbContext.Dispose();
                }
            }

            this.isDisposed = true;
        }

        #endregion
    }
}
