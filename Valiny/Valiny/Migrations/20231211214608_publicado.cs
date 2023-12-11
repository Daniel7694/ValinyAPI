using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Valiny.Migrations
{
    /// <inheritdoc />
    public partial class publicado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrativos",
                columns: table => new
                {
                    AdministrativoId = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    P_Nombre = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    S_Nombre = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    T_Nombre = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    P_Apellido = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    S_Apellido = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    T_Documento = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrativos", x => x.AdministrativoId);
                });

            migrationBuilder.CreateTable(
                name: "Claves",
                columns: table => new
                {
                    ClaveId = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contrasenia = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claves", x => x.ClaveId);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    CursoId = table.Column<int>(type: "int", maxLength: 2, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.CursoId);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    EstudianteId = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    P_Nombre = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    S_Nombre = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    T_Nombre = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    P_Apellido = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    S_Apellido = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    T_Documento = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.EstudianteId);
                });

            migrationBuilder.CreateTable(
                name: "Rols",
                columns: table => new
                {
                    RolId = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreRol = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rols", x => x.RolId);
                });

            migrationBuilder.CreateTable(
                name: "TiposRegistro",
                columns: table => new
                {
                    TiposRegistroId = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreRegistro = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposRegistro", x => x.TiposRegistroId);
                });

            migrationBuilder.CreateTable(
                name: "AdministrativoClave",
                columns: table => new
                {
                    AdministrativoClaveId = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdministrativoId = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    ClaveId = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdministrativoClave", x => x.AdministrativoClaveId);
                    table.ForeignKey(
                        name: "FK_AdministrativoClave_Administrativos_AdministrativoId",
                        column: x => x.AdministrativoId,
                        principalTable: "Administrativos",
                        principalColumn: "AdministrativoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdministrativoClave_Claves_ClaveId",
                        column: x => x.ClaveId,
                        principalTable: "Claves",
                        principalColumn: "ClaveId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matricula",
                columns: table => new
                {
                    MatriculaId = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstudianteId = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    CursoId = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matricula", x => x.MatriculaId);
                    table.ForeignKey(
                        name: "FK_Matricula_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matricula_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "EstudianteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdministrativoRol",
                columns: table => new
                {
                    AdministrativoRolId = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdministrativoId = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    RolId = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdministrativoRol", x => x.AdministrativoRolId);
                    table.ForeignKey(
                        name: "FK_AdministrativoRol_Administrativos_AdministrativoId",
                        column: x => x.AdministrativoId,
                        principalTable: "Administrativos",
                        principalColumn: "AdministrativoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdministrativoRol_Rols_RolId",
                        column: x => x.RolId,
                        principalTable: "Rols",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    RegistroId = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TiposRegistroId = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    MatriculaId = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    AdministrativoId = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.RegistroId);
                    table.ForeignKey(
                        name: "FK_Registros_Administrativos_AdministrativoId",
                        column: x => x.AdministrativoId,
                        principalTable: "Administrativos",
                        principalColumn: "AdministrativoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registros_Matricula_MatriculaId",
                        column: x => x.MatriculaId,
                        principalTable: "Matricula",
                        principalColumn: "MatriculaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registros_TiposRegistro_TiposRegistroId",
                        column: x => x.TiposRegistroId,
                        principalTable: "TiposRegistro",
                        principalColumn: "TiposRegistroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdministrativoClave_AdministrativoId",
                table: "AdministrativoClave",
                column: "AdministrativoId");

            migrationBuilder.CreateIndex(
                name: "IX_AdministrativoClave_ClaveId",
                table: "AdministrativoClave",
                column: "ClaveId");

            migrationBuilder.CreateIndex(
                name: "IX_AdministrativoRol_AdministrativoId",
                table: "AdministrativoRol",
                column: "AdministrativoId");

            migrationBuilder.CreateIndex(
                name: "IX_AdministrativoRol_RolId",
                table: "AdministrativoRol",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_CursoId",
                table: "Matricula",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_EstudianteId",
                table: "Matricula",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_AdministrativoId",
                table: "Registros",
                column: "AdministrativoId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_MatriculaId",
                table: "Registros",
                column: "MatriculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_TiposRegistroId",
                table: "Registros",
                column: "TiposRegistroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdministrativoClave");

            migrationBuilder.DropTable(
                name: "AdministrativoRol");

            migrationBuilder.DropTable(
                name: "Registros");

            migrationBuilder.DropTable(
                name: "Claves");

            migrationBuilder.DropTable(
                name: "Rols");

            migrationBuilder.DropTable(
                name: "Administrativos");

            migrationBuilder.DropTable(
                name: "Matricula");

            migrationBuilder.DropTable(
                name: "TiposRegistro");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Estudiantes");
        }
    }
}
