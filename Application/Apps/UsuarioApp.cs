﻿using Application.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Apps
{
    public class UsuarioApp : App<UsuarioViewModel, Usuario>, IUsuarioApp
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public UsuarioApp(UserManager<Usuario> userManager, IMapper mapper
            , ILogger<UsuarioApp> logger, IUsuarioRepository usuarioRepository, 
            RoleManager<IdentityRole<int>> roleManager) : base(usuarioRepository ,mapper, logger)
        {
            _mapper = mapper;
            _logger = logger;
            _userManager = userManager;
            _usuarioRepository = usuarioRepository;
            _roleManager = roleManager;
        }

        public async Task<Usuario> AddAsync(RegistroViewModel registro)
        {
            try
            {
                Usuario usuario = new()
                {
                    NomeCompleto = registro.NomeCompleto,
                    UserName = registro.Email,
                    NormalizedUserName = registro.Email.ToUpper(),
                    Email = registro.Email,
                    NormalizedEmail = registro.Email.ToUpper(),
                    CreatedAt = DateTime.UtcNow,
                    LastUpdatedAt = DateTime.UtcNow,
                };
                var result = await _userManager.CreateAsync(usuario, registro.Senha);
                if(result.Succeeded)
                {
                    var roleName = "Administrador";
                    var roleExists = await _roleManager.RoleExistsAsync(roleName);

                    if (!roleExists)
                    {
                        var newRole = new IdentityRole<int> { Name = roleName, NormalizedName = roleName.ToUpper()};  
                        await _roleManager.CreateAsync(newRole);
                    }

                    await _userManager.AddToRoleAsync(usuario, roleName);

                }
                return usuario;
                
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<string?>> GetAllRolesAsync()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return roles.Select(r => r.Name).ToList();
        }

    }
}
