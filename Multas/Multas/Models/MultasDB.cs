using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class MultasDB : DbContext
    {
        //Identificar  qual o SGBD a usar


        //Definir as tabelas da BD
        public DbSet<Agentes> Agentes { get; set; }
        public DbSet<Condutores> Condutores { get; set; }
        public DbSet<Multas> Multas { get; set; }
        public DbSet<Viaturas> Viaturas { get; set; }

        //Método a ser executado no início da criação do Modelo
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Eliminar a convenção de atribuir automáticamente o 'on Delete Cascade' nas FK's
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}

