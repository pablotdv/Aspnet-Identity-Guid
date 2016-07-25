using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace AspNet.Identity.Common.Models
{
    public class Grupo : IdentityRole<Guid, UsuarioGrupo>
    {
        public Grupo()
        {
            Id = Guid.NewGuid();
        }
    }
}