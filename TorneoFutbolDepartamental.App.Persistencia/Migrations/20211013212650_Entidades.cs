using Microsoft.EntityFrameworkCore.Migrations;

namespace TorneoFutbolDepartamental.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arbitros",
                columns: table => new
                {
                    ArbitroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColegioPertenece = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arbitros", x => x.ArbitroId);
                });

            migrationBuilder.CreateTable(
                name: "DirectoresTecnicos",
                columns: table => new
                {
                    DirectorTecnicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectoresTecnicos", x => x.DirectorTecnicoId);
                });

            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    JugadorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Posicion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Equipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.JugadorId);
                });

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
                name: "Equipos",
                columns: table => new
                {
                    EquipoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cnt_PartidosEmpatados = table.Column<int>(type: "int", nullable: false),
                    Cnt_PartidosGanados = table.Column<int>(type: "int", nullable: false),
                    Cnt_PartidosJugados = table.Column<int>(type: "int", nullable: false),
                    GolesContra = table.Column<int>(type: "int", nullable: false),
                    GolesFavor = table.Column<int>(type: "int", nullable: false),
                    Puntos = table.Column<int>(type: "int", nullable: false),
                    JugadorId = table.Column<int>(type: "int", nullable: true),
                    DirectorTecnicoId = table.Column<int>(type: "int", nullable: true),
                    MunicipioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.EquipoId);
                    table.ForeignKey(
                        name: "FK_Equipos_DirectoresTecnicos_DirectorTecnicoId",
                        column: x => x.DirectorTecnicoId,
                        principalTable: "DirectoresTecnicos",
                        principalColumn: "DirectorTecnicoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipos_Jugadores_JugadorId",
                        column: x => x.JugadorId,
                        principalTable: "Jugadores",
                        principalColumn: "JugadorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipos_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "MunicipioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estadios",
                columns: table => new
                {
                    EstadioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Partidos",
                columns: table => new
                {
                    PartidoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marcador = table.Column<int>(type: "int", nullable: false),
                    ArbitroId = table.Column<int>(type: "int", nullable: true),
                    EquipoLocalEquipoId = table.Column<int>(type: "int", nullable: true),
                    EquipoVisitanteEquipoId = table.Column<int>(type: "int", nullable: true),
                    EstadioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidos", x => x.PartidoId);
                    table.ForeignKey(
                        name: "FK_Partidos_Arbitros_ArbitroId",
                        column: x => x.ArbitroId,
                        principalTable: "Arbitros",
                        principalColumn: "ArbitroId",
                        onDelete: ReferentialAction.Restrict);
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
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_DirectorTecnicoId",
                table: "Equipos",
                column: "DirectorTecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_JugadorId",
                table: "Equipos",
                column: "JugadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_MunicipioId",
                table: "Equipos",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Estadios_MunicipioId",
                table: "Estadios",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_ArbitroId",
                table: "Partidos",
                column: "ArbitroId");

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
                name: "Arbitros");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Estadios");

            migrationBuilder.DropTable(
                name: "DirectoresTecnicos");

            migrationBuilder.DropTable(
                name: "Jugadores");

            migrationBuilder.DropTable(
                name: "Municipios");
        }
    }
}
