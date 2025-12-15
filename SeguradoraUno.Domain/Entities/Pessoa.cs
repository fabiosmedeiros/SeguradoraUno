using System;
using System.Collections.Generic;

namespace SeguradoraUno.Domain.Entities
{
    public class Pessoa
    {
        #region "Attributes"
                
        public int PessoaId { get; set; }

        public PessoaTipo PessoaTipo { get; set; }

        public string Nome { get; set; }

        public string CpfCnpj { get; set; }

        public string Sexo { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime DataRegistro { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        // Navigation properties.
        public virtual ICollection<PessoaEndereco> PessoaEnderecos { get; set; }

        public virtual ICollection<PessoaContato> PessoaContatos { get; set; }

        #endregion
    }
}
