using SeguradoraUno.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SeguradoraUno.Repo.EntityConfiguration
{
    public class PessoaContatoConfig : EntityTypeConfiguration<PessoaContato>
    {
        public PessoaContatoConfig()
        {
            HasKey(c => c.PessoaContatoId);

            Property(c => c.PessoaContatoId)
                .IsRequired();

            Property(c => c.Ddd)
                .IsRequired()
                .HasMaxLength(2);

            Property(c => c.Telefone)
                .IsRequired()
                .HasMaxLength(9);

            Property(c => c.IsTelefonePrincipal)
                .IsRequired();

            Property(c => c.DataRegistro)
                .IsRequired();

            Property(c => c.DataAtualizacao)
                .IsOptional();

            // Navigation properties.
            Property(c => c.PessoaId)
                .IsRequired();
        }
    }
}
