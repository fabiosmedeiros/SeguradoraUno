using SeguradoraUno.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SeguradoraUno.Repo.EntityConfiguration
{
    public class PessoaEnderecoConfig : EntityTypeConfiguration<PessoaEndereco>
    {
        public PessoaEnderecoConfig()
        {
            HasKey(c => c.PessoaEnderecoId);

            Property(c => c.PessoaEnderecoId)
                .IsRequired();

            Property(c => c.Logradouro)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Numero)
                .IsRequired()
                .HasMaxLength(5);

            Property(c => c.Complemento)
                .IsOptional()
                .HasMaxLength(30);

            Property(c => c.Cep)
                .IsRequired()
                .HasMaxLength(8);

            Property(c => c.IsEnderecoCorrespondencia)
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
