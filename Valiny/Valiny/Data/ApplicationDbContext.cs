using Microsoft.EntityFrameworkCore;
using Valiny.Models;

namespace Valiny.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Administrativo> Administrativos { get; set; }
        public DbSet<Clave> Claves { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Directivo> Directivos { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Orientador> Orientadores { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<T_Documento> T_Documentos { get; set; }

    }
}
