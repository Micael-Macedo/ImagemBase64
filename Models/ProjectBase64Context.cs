using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoBase64.Models
{
    public class ProjectBase64Context : DbContext
    {
        public ProjectBase64Context(DbContextOptions<ProjectBase64Context> options) : base(options){}
        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Foto>? Fotos { get; set; }
        public DbSet<Curriculo>? Curriculos { get; set; }
    }
}