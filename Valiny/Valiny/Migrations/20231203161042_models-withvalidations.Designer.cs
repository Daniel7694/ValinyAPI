﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Valiny.Data;

#nullable disable

namespace Valiny.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231203161042_models-withvalidations")]
    partial class modelswithvalidations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Valiny.Models.Administrativo", b =>
                {
                    b.Property<int>("AdministrativoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdministrativoId"));

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("P_Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S_Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S_Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("T_Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdministrativoId");

                    b.ToTable("Administrativos");
                });

            modelBuilder.Entity("Valiny.Models.AdministrativoClave", b =>
                {
                    b.Property<int>("AdministrativoClaveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdministrativoClaveId"));

                    b.Property<int>("AdministrativoId")
                        .HasColumnType("int");

                    b.Property<int>("ClaveId")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.HasKey("AdministrativoClaveId");

                    b.HasIndex("AdministrativoId");

                    b.HasIndex("ClaveId");

                    b.ToTable("AdministrativoClave");
                });

            modelBuilder.Entity("Valiny.Models.AdministrativoRol", b =>
                {
                    b.Property<int>("AdministrativoRolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdministrativoRolId"));

                    b.Property<int>("AdministrativoId")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.HasKey("AdministrativoRolId");

                    b.HasIndex("AdministrativoId");

                    b.HasIndex("RolId");

                    b.ToTable("AdministrativoRol");
                });

            modelBuilder.Entity("Valiny.Models.Clave", b =>
                {
                    b.Property<int>("ClaveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClaveId"));

                    b.Property<string>("Contrasenia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.HasKey("ClaveId");

                    b.ToTable("Claves");
                });

            modelBuilder.Entity("Valiny.Models.Curso", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CursoId"));

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CursoId");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("Valiny.Models.Estudiante", b =>
                {
                    b.Property<int>("EstudianteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstudianteId"));

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("P_Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S_Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S_Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("T_Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstudianteId");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("Valiny.Models.Matricula", b =>
                {
                    b.Property<int>("MatriculaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MatriculaId"));

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<int>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("MatriculaId");

                    b.HasIndex("CursoId");

                    b.HasIndex("EstudianteId");

                    b.ToTable("Matricula");
                });

            modelBuilder.Entity("Valiny.Models.Registro", b =>
                {
                    b.Property<int>("RegistroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegistroId"));

                    b.Property<int>("AdministrativoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("MatriculaId")
                        .HasColumnType("int");

                    b.Property<int>("T_DocumentoId")
                        .HasColumnType("int");

                    b.Property<int>("TiposRegistroId")
                        .HasColumnType("int");

                    b.HasKey("RegistroId");

                    b.HasIndex("AdministrativoId");

                    b.HasIndex("MatriculaId");

                    b.HasIndex("TiposRegistroId");

                    b.ToTable("Registros");
                });

            modelBuilder.Entity("Valiny.Models.Rol", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RolId"));

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("NombreRol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RolId");

                    b.ToTable("Rols");
                });

            modelBuilder.Entity("Valiny.Models.TiposRegistro", b =>
                {
                    b.Property<int>("TiposRegistroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TiposRegistroId"));

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("NombreRegistro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TiposRegistroId");

                    b.ToTable("TiposRegistro");
                });

            modelBuilder.Entity("Valiny.Models.AdministrativoClave", b =>
                {
                    b.HasOne("Valiny.Models.Administrativo", "Administrativo")
                        .WithMany("AdministrativoClave")
                        .HasForeignKey("AdministrativoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Valiny.Models.Clave", "Clave")
                        .WithMany("AdministrativoClave")
                        .HasForeignKey("ClaveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Administrativo");

                    b.Navigation("Clave");
                });

            modelBuilder.Entity("Valiny.Models.AdministrativoRol", b =>
                {
                    b.HasOne("Valiny.Models.Administrativo", "Administrativo")
                        .WithMany("AdministrativoRol")
                        .HasForeignKey("AdministrativoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Valiny.Models.Rol", "Rol")
                        .WithMany("AdministrativoRol")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Administrativo");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Valiny.Models.Matricula", b =>
                {
                    b.HasOne("Valiny.Models.Curso", "Curso")
                        .WithMany("Matricula")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Valiny.Models.Estudiante", "Estudiante")
                        .WithMany("Matricula")
                        .HasForeignKey("EstudianteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Estudiante");
                });

            modelBuilder.Entity("Valiny.Models.Registro", b =>
                {
                    b.HasOne("Valiny.Models.Administrativo", "Administrativo")
                        .WithMany("Registro")
                        .HasForeignKey("AdministrativoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Valiny.Models.Matricula", "Matricula")
                        .WithMany("Registro")
                        .HasForeignKey("MatriculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Valiny.Models.TiposRegistro", "TiposRegistro")
                        .WithMany("Registro")
                        .HasForeignKey("TiposRegistroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Administrativo");

                    b.Navigation("Matricula");

                    b.Navigation("TiposRegistro");
                });

            modelBuilder.Entity("Valiny.Models.Administrativo", b =>
                {
                    b.Navigation("AdministrativoClave");

                    b.Navigation("AdministrativoRol");

                    b.Navigation("Registro");
                });

            modelBuilder.Entity("Valiny.Models.Clave", b =>
                {
                    b.Navigation("AdministrativoClave");
                });

            modelBuilder.Entity("Valiny.Models.Curso", b =>
                {
                    b.Navigation("Matricula");
                });

            modelBuilder.Entity("Valiny.Models.Estudiante", b =>
                {
                    b.Navigation("Matricula");
                });

            modelBuilder.Entity("Valiny.Models.Matricula", b =>
                {
                    b.Navigation("Registro");
                });

            modelBuilder.Entity("Valiny.Models.Rol", b =>
                {
                    b.Navigation("AdministrativoRol");
                });

            modelBuilder.Entity("Valiny.Models.TiposRegistro", b =>
                {
                    b.Navigation("Registro");
                });
#pragma warning restore 612, 618
        }
    }
}
