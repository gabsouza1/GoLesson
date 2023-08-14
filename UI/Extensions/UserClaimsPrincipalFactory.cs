using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace UI.Extensions
{
    public class UserClaimsPrincipalFactory : UserClaimsPrincipalFactory<Usuario>
    {
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public UserClaimsPrincipalFactory(UserManager<Usuario> userManager, IOptions<IdentityOptions> optionsAccessor, RoleManager<IdentityRole<int>> roleManager)
            : base(userManager, optionsAccessor)
        {
            _roleManager = roleManager;
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(Usuario user)
        {
            ClaimsIdentity identity = await base.GenerateClaimsAsync(user);

            identity.AddClaim(new Claim("Id", user.Id.ToString()));
            identity.AddClaim(new Claim("Nome", user.UserName));

            foreach (var roleName in await UserManager.GetRolesAsync(user))
            {
                identity.AddClaim(new Claim(Options.ClaimsIdentity.RoleClaimType, roleName));

                var role = await _roleManager.FindByNameAsync(roleName);

                if (role != null)
                    identity.AddClaims(await _roleManager.GetClaimsAsync(role));
            }

            return identity;
        }
    }
}
