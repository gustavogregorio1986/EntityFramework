using EntityFramework.Dominio.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Data.Contexto
{
    public class EntityFrameworkComtexto : DbContext
    {
        public EntityFrameworkComtexto(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Candidato> Candidatos { get; set; }

        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Recrutador> Recrutadores { get; set; }

        public DbSet<Setor> Setores { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
