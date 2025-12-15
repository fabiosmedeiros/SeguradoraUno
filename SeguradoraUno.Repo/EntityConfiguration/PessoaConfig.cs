using SeguradoraUno.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SeguradoraUno.Repo.EntityConfiguration
{
    public class PessoaConfig : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfig()
        {
            HasKey(c => c.PessoaId);

            Property(c => c.PessoaId)
                .IsRequired();

            Property(c => c.PessoaTipo)
                .IsRequired();

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.CpfCnpj)
                .IsRequired()
                .HasMaxLength(14);

            Property(c => c.Sexo)
                .IsRequired()
                .HasMaxLength(1);

            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(80);

            Property(c => c.DataNascimento)
                .IsRequired();

            Property(c => c.DataRegistro)
                .IsRequired();

            Property(c => c.DataAtualizacao)
                .IsOptional();
        }
    }
}
