using SeguradoraUno.Domain.Entities;
using System.Collections.Generic;

namespace SeguradoraUno.Domain.Interfaces.Repository
{
    public interface IPessoaEnderecoRepository : IRepository<PessoaEndereco>
    {
        IEnumerable<PessoaEndereco> GetPessoaEnderecos();
    }
}
