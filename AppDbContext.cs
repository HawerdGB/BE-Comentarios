using BE_Comentarios.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_Comentarios
{
    public class AppDbContext: DbContext
    {
        public DbSet<Comentario> Comentario { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext>options): base(options) { }
    }
}
