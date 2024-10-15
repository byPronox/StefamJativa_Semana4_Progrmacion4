using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StefamJativa_Semana4_Progrmacion4.Models;

namespace StefamJativa_Semana4_Progrmacion4.Data
{
    public class StefamJativa_Semana4_Progrmacion4Context : DbContext
    {
        public StefamJativa_Semana4_Progrmacion4Context (DbContextOptions<StefamJativa_Semana4_Progrmacion4Context> options)
            : base(options)
        {
        }

        public DbSet<StefamJativa_Semana4_Progrmacion4.Models.Estudiante> Estudiante { get; set; } = default!;
        public DbSet<StefamJativa_Semana4_Progrmacion4.Models.Carrera> Carrera { get; set; } = default!;
    }
}
