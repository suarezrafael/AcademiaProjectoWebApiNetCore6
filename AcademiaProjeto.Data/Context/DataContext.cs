using AcademiaProjeto.Data.DataConfig;
using AcademiaProjeto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaProjeto.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext( DbContextOptions<DataContext> options) : base(options) { }

        //public DbSet<Curso> Cursos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>(new CursoConfiguration().Configure);
            base.OnModelCreating(modelBuilder);
        }

    }
}
