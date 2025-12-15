using SeguradoraUno.Domain.Interfaces.Repository;
using SeguradoraUno.Domain.Interfaces.UoW;
using SeguradoraUno.Repo.Data.Repository;
using SeguradoraUno.Repo.Persistence;

namespace SeguradoraUno.Repo.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        #region "Attributes"

        private readonly SuDbContext _dbContext = new SuDbContext();

        private bool isDisposed = false;

        #endregion


        #region "Repositories"

        private IPessoaRepository pessoaRepository;

        private IPessoaEnderecoRepository pessoaEnderecoRepository;

        private IPessoaContatoRepository pessoaContatoRepository;


        public IPessoaRepository PessoaRepository
        {
            get
            {
                if (this.pessoaRepository == null)
                {
                    this.pessoaRepository = new PessoaRepository(this._dbContext);
                }

                return this.pessoaRepository;
            }
        }

        public IPessoaEnderecoRepository PessoaEnderecoRepository
        {
            get
            {
                if (this.pessoaEnderecoRepository == null)
                {
                    this.pessoaEnderecoRepository = new PessoaEnderecoRepository(this._dbContext);
                }

                return this.pessoaEnderecoRepository;
            }
        }

        public IPessoaContatoRepository PessoaContatoRepository
        {
            get
            {
                if (this.pessoaContatoRepository == null)
                {
                    this.pessoaContatoRepository = new PessoaContatoRepository(this._dbContext);
                }

                return this.pessoaContatoRepository;
            }
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
