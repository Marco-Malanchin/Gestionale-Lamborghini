using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using LamborghiniAuto.Models;

namespace LamborghiniAuto.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LamborghiniAuto.Models.Persona> Persona { get; set; }
        public DbSet<LamborghiniAuto.Models.Dipendente> Dipendente { get; set; }
        public DbSet<LamborghiniAuto.Models.Auto> Auto { get; set; }
        public DbSet<LamborghiniAuto.Models.Cliente> Cliente { get; set; }
    }
}
