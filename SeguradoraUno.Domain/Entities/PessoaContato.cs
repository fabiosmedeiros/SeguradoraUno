using System;

namespace SeguradoraUno.Domain.Entities
{
    public class PessoaContato
    {
        #region "Attributes"
                
        public int PessoaContatoId { get; set; }

        public string Ddd { get; set; }

        public string Telefone { get; set; }

        public bool IsTelefonePrincipal { get; set; }

        public DateTime DataRegistro { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        // Navigation properties.
        public virtual Pessoa Pessoa { get; set; }

        public int PessoaId { get; set; }

        #endregion
    }
}
