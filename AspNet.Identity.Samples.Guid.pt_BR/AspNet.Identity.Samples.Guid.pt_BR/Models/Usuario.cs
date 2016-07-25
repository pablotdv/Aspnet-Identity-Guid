using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AspNet.Identity.Samples.Common.Models
{
    public class Usuario : IdentityUser<Guid, UsuarioLogin, UsuarioGrupo, UsuarioIdentificacao>
    {
        public Usuario()
        {
            Id = Guid.NewGuid();
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Usuario, Guid> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}