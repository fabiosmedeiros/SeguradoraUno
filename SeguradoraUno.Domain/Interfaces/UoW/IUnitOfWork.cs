using SeguradoraUno.Domain.Interfaces.Repository;
using System;

namespace SeguradoraUno.Domain.Interfaces.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        #region "Repositories"

        IPessoaRepository Pessoas { get; }

        IPessoaEnderecoRepository PessoaEnderecos { get; }

        IPessoaContatoRepository PessoaContatos { get; }

        #endregion


        #region "Save"

        void Complete();

        #endregion
    }
}
