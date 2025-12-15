using SeguradoraUno.Domain.Entities;
using System.Collections.Generic;

namespace SeguradoraUno.Domain.Interfaces.Repository
{
    public interface IPessoaContatoRepository : IRepository<PessoaContato>
    {
        IEnumerable<PessoaContato> GetPessoaContatos();
    }
}
