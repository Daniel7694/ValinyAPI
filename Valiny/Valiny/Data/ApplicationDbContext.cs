using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Valiny.Models;

namespace Valiny.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aquí puedes configurar las relaciones y claves foráneas como en tu script SQL
            // Por ejemplo:
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Registro>()
                .HasOne(ca => ca.Administrativo)
                .WithMany(f => f.Registro)
                .HasForeignKey(ca => ca.AdministrativoId);

            modelBuilder.Entity<Registro>()
                .HasOne(ca => ca.Matricula)
                .WithMany(f => f.Registro)
                .HasForeignKey(ca => ca.MatriculaId);

            modelBuilder.Entity<Registro>()
                .HasOne(ca => ca.TiposRegistro)
                .WithMany(f => f.Registro)
                .HasForeignKey(ca => ca.TiposRegistroId);

            modelBuilder.Entity<AdministrativoRol>()
                .HasOne(ca => ca.Rol)
                .WithMany(f => f.AdministrativoRol)
                .HasForeignKey(ca => ca.RolId);

            modelBuilder.Entity<AdministrativoRol>()
                .HasOne(ca => ca.Administrativo)
                .WithMany(f => f.AdministrativoRol)
                .HasForeignKey(ca => ca.AdministrativoId);

            modelBuilder.Entity<AdministrativoClave>()
                .HasOne(ca => ca.Clave)
                .WithMany(f => f.AdministrativoClave)
                .HasForeignKey(ca => ca.ClaveId);

            modelBuilder.Entity<AdministrativoClave>()
                .HasOne(ca => ca.Administrativo)
                .WithMany(f => f.AdministrativoClave)
                .HasForeignKey(ca => ca.AdministrativoId);


            modelBuilder.Entity<Matricula>()
                .HasOne(ca => ca.Estudiante)
                .WithMany(f => f.Matricula)
                .HasForeignKey(ca => ca.EstudianteId);

            modelBuilder.Entity<Matricula>()
                .HasOne(ca => ca.Curso)
                .WithMany(f => f.Matricula)
                .HasForeignKey(ca => ca.CursoId);
            // ... otras configu
        }
        public DbSet<Administrativo> Administrativos { get; set; }
        public DbSet<Clave> Claves { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<AppUser> AppUser { get; set; }
    }
}
