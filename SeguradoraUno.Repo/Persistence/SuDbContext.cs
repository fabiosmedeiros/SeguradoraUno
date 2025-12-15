using SeguradoraUno.Domain.Entities;
using SeguradoraUno.Repo.EntityConfiguration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SeguradoraUno.Repo.Persistence
{
    public class SuDbContext : DbContext
    {
        #region "DbSets"
                
        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<PessoaEndereco> PessoaEnderecos { get; set; }

        public DbSet<PessoaContato> PessoaContatos { get; set; }

        #endregion


        #region "Constructor"

        public SuDbContext()
            : base("SuDb1")
        {

        }

        #endregion


        #region "Methods"

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            
            // Definindo que campos terminados com "Id" são chave primária.
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            // Definindo o tipo de dados para campos string.
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(200));

            // Adicionando configurações personalizadas do modelo.
            modelBuilder.Configurations.Add(new PessoaConfig());
            modelBuilder.Configurations.Add(new PessoaEnderecoConfig());
            modelBuilder.Configurations.Add(new PessoaContatoConfig());
        }

        #endregion
    }
}
