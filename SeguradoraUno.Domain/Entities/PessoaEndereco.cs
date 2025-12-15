using System;

namespace SeguradoraUno.Domain.Entities
{
    public class PessoaEndereco
    {
        #region "Attributes"
                
        public int PessoaEnderecoId { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Cep { get; set; }

        public bool IsEnderecoCorrespondencia { get; set; }

        public DateTime DataRegistro { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        // Navigation properties.
        public virtual Pessoa Pessoa { get; set; }

        public int PessoaId { get; set; }

        #endregion
    }
}
