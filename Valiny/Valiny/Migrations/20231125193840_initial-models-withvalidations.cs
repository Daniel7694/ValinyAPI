using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Valiny.Migrations
{
    /// <inheritdoc />
    public partial class initialmodelswithvalidations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Claves",
                columns: table => new
                {
                    ID_Clave = table.Column<int>(type: "int", maxLength: 1, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contrasenia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claves", x => x.ID_Clave);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    ID_Curso = table.Column<int>(type: "int", maxLength: 1, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Num_Curso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.ID_Curso);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    ID_Genero = table.Column<int>(type: "int", maxLength: 1, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_Genero = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.ID_Genero);
                });

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    ID_Registro = table.Column<int>(type: "int", maxLength: 1, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_Registro = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.ID_Registro);
                });

            migrationBuilder.CreateTable(
                name: "Rols",
                columns: table => new
                {
                    ID_Rol = table.Column<int>(type: "int", maxLength: 1, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rols", x => x.ID_Rol);
                });

            migrationBuilder.CreateTable(
                name: "T_Documentos",
                columns: table => new
                {
                    ID_Documento = table.Column<int>(type: "int", maxLength: 1, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo_Documento = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Documentos", x => x.ID_Documento);
                });

            migrationBuilder.CreateTable(
                name: "Administrativos",
                columns: table => new
                {
                    ID_Admin = table.Column<int>(type: "int", maxLength: 15, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Genero = table.Column<int>(type: "int", nullable: false),
                    ID_Rol = table.Column<int>(type: "int", nullable: false),
                    ID_Clave = table.Column<int>(type: "int", nullable: false),
                    ID_Documento = table.Column<int>(type: "int", nullable: false),
                    P_Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    S_Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    T_Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    P_Apellido = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    S_Apellido = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrativos", x => x.ID_Admin);
                    table.ForeignKey(
                        name: "FK_Administrativos_Claves_ID_Clave",
                        column: x => x.ID_Clave,
                        principalTable: "Claves",
                        principalColumn: "ID_Clave",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Administrativos_Generos_ID_Genero",
                        column: x => x.ID_Genero,
                        principalTable: "Generos",
                        principalColumn: "ID_Genero",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Administrativos_Rols_ID_Rol",
                        column: x => x.ID_Rol,
                        principalTable: "Rols",
                        principalColumn: "ID_Rol",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Administrativos_T_Documentos_ID_Documento",
                        column: x => x.ID_Documento,
                        principalTable: "T_Documentos",
                        principalColumn: "ID_Documento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    ID_Estudiante = table.Column<int>(type: "int", maxLength: 15, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Curso = table.Column<int>(type: "int", nullable: false),
                    ID_Registro = table.Column<int>(type: "int", nullable: false),
                    ID_Documento = table.Column<int>(type: "int", nullable: false),
                    ID_Genero = table.Column<int>(type: "int", nullable: false),
                    ID_Admin = table.Column<int>(type: "int", nullable: false),
                    P_Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    S_Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    T_Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    P_Apellido = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    S_Apellido = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.ID_Estudiante);
                    table.ForeignKey(
                        name: "FK_Estudiantes_Administrativos_ID_Admin",
                        column: x => x.ID_Admin,
                        principalTable: "Administrativos",
                        principalColumn: "ID_Admin",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Estudiantes_Cursos_ID_Curso",
                        column: x => x.ID_Curso,
                        principalTable: "Cursos",
                        principalColumn: "ID_Curso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Estudiantes_Generos_ID_Genero",
                        column: x => x.ID_Genero,
                        principalTable: "Generos",
                        principalColumn: "ID_Genero",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Estudiantes_Registros_ID_Registro",
                        column: x => x.ID_Registro,
                        principalTable: "Registros",
                        principalColumn: "ID_Registro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Estudiantes_T_Documentos_ID_Documento",
                        column: x => x.ID_Documento,
                        principalTable: "T_Documentos",
                        principalColumn: "ID_Documento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administrativos_ID_Clave",
                table: "Administrativos",
                column: "ID_Clave");

            migrationBuilder.CreateIndex(
                name: "IX_Administrativos_ID_Documento",
                table: "Administrativos",
                column: "ID_Documento");

            migrationBuilder.CreateIndex(
                name: "IX_Administrativos_ID_Genero",
                table: "Administrativos",
                column: "ID_Genero");

            migrationBuilder.CreateIndex(
                name: "IX_Administrativos_ID_Rol",
                table: "Administrativos",
                column: "ID_Rol");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_ID_Admin",
                table: "Estudiantes",
                column: "ID_Admin");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_ID_Curso",
                table: "Estudiantes",
                column: "ID_Curso");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_ID_Documento",
                table: "Estudiantes",
                column: "ID_Documento");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_ID_Genero",
                table: "Estudiantes",
                column: "ID_Genero");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_ID_Registro",
                table: "Estudiantes",
                column: "ID_Registro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Administrativos");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Registros");

            migrationBuilder.DropTable(
                name: "Claves");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "Rols");

            migrationBuilder.DropTable(
                name: "T_Documentos");
        }
    }
}
