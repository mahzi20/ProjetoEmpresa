using ProjEmpresa.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ProjEmpresa.Dao
{
        public class EFContext : DbContext
        {
            public EFContext() : base("EFConnectionString") { }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                base.OnModelCreating(modelBuilder);

            }

            public DbSet<Empresa> Empresas { get; set; }
        }
 }