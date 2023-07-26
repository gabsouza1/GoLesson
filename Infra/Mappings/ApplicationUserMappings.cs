﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Mappings
{
    public class AppliactionUserMapping : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasKey(a => a.Id);
            builder.HasOne(a => a.Generos).WithMany(g => g.User).HasForeignKey(fk => fk.GeneroId);
            builder.HasMany(a => a.UsuariosCursos).WithOne(uc => uc.User).HasForeignKey(fk => fk.UsuarioId);
            builder.HasMany(a => a.Favoritos).WithOne(f => f.Usuarios).HasForeignKey(fk => fk.UsuarioId);
            builder.HasMany(a => a.Avaliacoes).WithOne(ac => ac.Usuarios).HasForeignKey(fk => fk.UsuarioId);
            builder.HasMany(a => a.Enderecos).WithOne(e => e.Usuarios).HasForeignKey(fk => fk.UsuarioId);
            builder.HasMany(a => a.NotasAvaliacoes).WithOne(na => na.Usuarios).HasForeignKey(fk => fk.UsuarioId);
        }
    }
}
