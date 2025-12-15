using SeguradoraUno.Domain.Interfaces.Repository;
using System;

namespace SeguradoraUno.Domain.Interfaces.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        #region "Repositories"

        IPessoaRepository PessoaRepository { get; }

        IPessoaEnderecoRepository PessoaEnderecoRepository { get; }

        IPessoaContatoRepository PessoaContatoRepository { get; }

        #endregion


        #region "Save"

        void Complete();

        #endregion
    }
}
