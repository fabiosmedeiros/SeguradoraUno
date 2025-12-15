namespace SeguradoraUno.Repo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PessoaContato",
                c => new
                    {
                        PessoaContatoId = c.Int(nullable: false, identity: true),
                        Ddd = c.String(nullable: false, maxLength: 2, unicode: false),
                        Telefone = c.String(nullable: false, maxLength: 9, unicode: false),
                        IsTelefonePrincipal = c.Boolean(nullable: false),
                        DataRegistro = c.DateTime(nullable: false),
                        DataAtualizacao = c.DateTime(),
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PessoaContatoId)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        PessoaId = c.Int(nullable: false, identity: true),
                        PessoaTipo = c.Int(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        CpfCnpj = c.String(nullable: false, maxLength: 14, unicode: false),
                        Sexo = c.String(nullable: false, maxLength: 1, unicode: false),
                        Email = c.String(nullable: false, maxLength: 80, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        DataRegistro = c.DateTime(nullable: false),
                        DataAtualizacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.PessoaId);
            
            CreateTable(
                "dbo.PessoaEndereco",
                c => new
                    {
                        PessoaEnderecoId = c.Int(nullable: false, identity: true),
                        Logradouro = c.String(nullable: false, maxLength: 50, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 5, unicode: false),
                        Complemento = c.String(maxLength: 30, unicode: false),
                        Cep = c.String(nullable: false, maxLength: 8, unicode: false),
                        IsEnderecoCorrespondencia = c.Boolean(nullable: false),
                        DataRegistro = c.DateTime(nullable: false),
                        DataAtualizacao = c.DateTime(),
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PessoaEnderecoId)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PessoaEndereco", "PessoaId", "dbo.Pessoa");
            DropForeignKey("dbo.PessoaContato", "PessoaId", "dbo.Pessoa");
            DropIndex("dbo.PessoaEndereco", new[] { "PessoaId" });
            DropIndex("dbo.PessoaContato", new[] { "PessoaId" });
            DropTable("dbo.PessoaEndereco");
            DropTable("dbo.Pessoa");
            DropTable("dbo.PessoaContato");
        }
    }
}
