using Microsoft.EntityFrameworkCore.Migrations;

namespace TorneoFutbolDepartamental.App.Persistencia.Migrations
{
    public partial class PrimeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    MunicipioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.MunicipioId);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    PersonaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdArbitro = table.Column<int>(type: "int", nullable: true),
                    ColegioPertenece = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdTecnico = table.Column<int>(type: "int", nullable: true),
                    DirectorTecnico_Equipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdJugador = table.Column<int>(type: "int", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: true),
                    Posicion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Equipo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PersonaId);
                });

            migrationBuilder.CreateTable(
                name: "Estadios",
                columns: table => new
                {
                    EstadioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdMunicipio = table.Column<int>(type: "int", nullable: false),
                    MunicipioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadios", x => x.EstadioId);
                    table.ForeignKey(
                        name: "FK_Estadios_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "MunicipioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    EquipoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cntPartidosEmpatados = table.Column<int>(type: "int", nullable: false),
                    cntPartidosGanados = table.Column<int>(type: "int", nullable: false),
                    cntPartidosJugados = table.Column<int>(type: "int", nullable: false),
                    GolesContra = table.Column<int>(type: "int", nullable: false),
                    GolesFavor = table.Column<int>(type: "int", nullable: false),
                    Puntos = table.Column<int>(type: "int", nullable: false),
                    DirectorTecnicoPersonaId = table.Column<int>(type: "int", nullable: true),
                    MunicipioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.EquipoId);
                    table.ForeignKey(
                        name: "FK_Equipos_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "MunicipioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipos_Personas_DirectorTecnicoPersonaId",
                        column: x => x.DirectorTecnicoPersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Partidos",
                columns: table => new
                {
                    PartidoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    marcador = table.Column<int>(type: "int", nullable: false),
                    ArbitroPersonaId = table.Column<int>(type: "int", nullable: true),
                    EquipoLocalEquipoId = table.Column<int>(type: "int", nullable: true),
                    EquipoVisitanteEquipoId = table.Column<int>(type: "int", nullable: true),
                    EstadioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidos", x => x.PartidoId);
                    table.ForeignKey(
                        name: "FK_Partidos_Equipos_EquipoLocalEquipoId",
                        column: x => x.EquipoLocalEquipoId,
                        principalTable: "Equipos",
                        principalColumn: "EquipoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Equipos_EquipoVisitanteEquipoId",
                        column: x => x.EquipoVisitanteEquipoId,
                        principalTable: "Equipos",
                        principalColumn: "EquipoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Estadios_EstadioId",
                        column: x => x.EstadioId,
                        principalTable: "Estadios",
                        principalColumn: "EstadioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Personas_ArbitroPersonaId",
                        column: x => x.ArbitroPersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_DirectorTecnicoPersonaId",
                table: "Equipos",
                column: "DirectorTecnicoPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_MunicipioId",
                table: "Equipos",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Estadios_MunicipioId",
                table: "Estadios",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_ArbitroPersonaId",
                table: "Partidos",
                column: "ArbitroPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_EquipoLocalEquipoId",
                table: "Partidos",
                column: "EquipoLocalEquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_EquipoVisitanteEquipoId",
                table: "Partidos",
                column: "EquipoVisitanteEquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_EstadioId",
                table: "Partidos",
                column: "EstadioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partidos");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Estadios");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Municipios");
        }
    }
}
