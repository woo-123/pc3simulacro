using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace pc3simulacro.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
         public DbSet<pc3simulacro.Models.Solicitud> solicitud { get; set; }
         public DbSet<pc3simulacro.Models.Usuario> Usuarios { get; set; }
    }
}
