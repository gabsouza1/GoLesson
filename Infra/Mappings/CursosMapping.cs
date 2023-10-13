using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Mappings
{
    public class CursosMapping : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.ToTable("Cursos");
            builder.HasKey(c => c.Id);
            builder.HasOne(c => c.Categorias).WithMany(cat => cat.Cursos).HasForeignKey(c => c.CategoriaId);
            builder.HasMany(c => c.UsuariosCursos).WithOne(uc => uc.Cursos).HasForeignKey(uc => uc.CursoId);
            builder.HasMany(c => c.MateriasCursos).WithOne(mc => mc.Curso).HasForeignKey(mc => mc.CursoId);
            builder.HasMany(c => c.CursosNiveis).WithOne(cn => cn.Curso).HasForeignKey(cn => cn.CursoId);
            builder.HasMany(c => c.Compras).WithOne(c => c.Curso).HasForeignKey(c => c.CursoId);
        }
    }
}
