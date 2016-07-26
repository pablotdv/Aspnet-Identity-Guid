using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;

namespace AspNet.Identity.Common.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.


    public class ApplicationDbContext : IdentityDbContext<Usuario, Grupo, Guid, UsuarioLogin, UsuarioGrupo, UsuarioIdentificacao>
    {
        public ApplicationDbContext(string nameOrConnectionString) :
            base(nameOrConnectionString)
        { }
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        static ApplicationDbContext()
        {
            // Set the database intializer which is run once during application start
            // This seeds the database with admin user credentials and admin role
            Database.SetInitializer<ApplicationDbContext>(new ApplicationDbInitializer());
        }

        public static ApplicationDbContext Criar()
        {
            return new ApplicationDbContext();
        }
    }
}