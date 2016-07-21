using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace IdentitySample.Models
{
    public class Grupo : IdentityRole<Guid, UsuarioGrupo>
    {
        public Grupo()
        {
            Id = Guid.NewGuid();
        }
    }
}