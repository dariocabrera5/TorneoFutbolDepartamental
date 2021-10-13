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
<<<<<<< HEAD:TorneoFutbolDepartamental.App.Persistencia/Migrations/20210930000330_Entidades.cs
                name: "Equipos",
=======
                name: "DirectoresTecnicos",
>>>>>>> 93787db8daafa996e8308e6a8691930127ebdc74:TorneoFutbolDepartamental.App.Persistencia/Migrations/20211013212650_Entidades.cs
                columns: table => new
                {
                    DirectorTecnicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
<<<<<<< HEAD:TorneoFutbolDepartamental.App.Persistencia/Migrations/20210930000330_Entidades.cs
                    cntPartidosEmpatados = table.Column<int>(type: "int", nullable: false),
                    cntPartidosGanados = table.Column<int>(type: "int", nullable: false),
                    cntPartidosJugados = table.Column<int>(type: "int", nullable: false),
                    GolesContra = table.Column<int>(type: "int", nullable: false),
                    GolesFavor = table.Column<int>(type: "int", nullable: false),
                    Puntos = table.Column<int>(type: "int", nullable: false),
                    municipioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipos_Municipios_municipioId",
                        column: x => x.municipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estadios",
=======
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectoresTecnicos", x => x.DirectorTecnicoId);
                });

            migrationBuilder.CreateTable(
                name: "Jugadores",
>>>>>>> 93787db8daafa996e8308e6a8691930127ebdc74:TorneoFutbolDepartamental.App.Persistencia/Migrations/20211013212650_Entidades.cs
                columns: table => new
                {
                    JugadorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
<<<<<<< HEAD:TorneoFutbolDepartamental.App.Persistencia/Migrations/20210930000330_Entidades.cs
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estadios_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
=======
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
>>>>>>> 93787db8daafa996e8308e6a8691930127ebdc74:TorneoFutbolDepartamental.App.Persistencia/Migrations/20211013212650_Entidades.cs
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    MunicipioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
<<<<<<< HEAD:TorneoFutbolDepartamental.App.Persistencia/Migrations/20210930000330_Entidades.cs
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColegioPertenece = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipoForeignKey = table.Column<int>(type: "int", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: true),
                    Posicion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_Equipos_EquipoForeignKey",
                        column: x => x.EquipoForeignKey,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personas_Equipos_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
=======
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.MunicipioId);
>>>>>>> 93787db8daafa996e8308e6a8691930127ebdc74:TorneoFutbolDepartamental.App.Persistencia/Migrations/20211013212650_Entidades.cs
                });

            migrationBuilder.CreateTable(
                name: "Partidos",
                columns: table => new
                {
                    EquipoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
<<<<<<< HEAD:TorneoFutbolDepartamental.App.Persistencia/Migrations/20210930000330_Entidades.cs
                    FechaHora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    marcadorEquipoLocal = table.Column<int>(type: "int", nullable: false),
                    maracadorEquipoVisitante = table.Column<int>(type: "int", nullable: false),
                    ArbitroId = table.Column<int>(type: "int", nullable: true),
                    EquipoLocalId = table.Column<int>(type: "int", nullable: true),
                    EquipoVisitanteId = table.Column<int>(type: "int", nullable: true),
                    EstadioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partidos_Equipos_EquipoLocalId",
                        column: x => x.EquipoLocalId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Equipos_EquipoVisitanteId",
                        column: x => x.EquipoVisitanteId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Estadios_EstadioId",
                        column: x => x.EstadioId,
                        principalTable: "Estadios",
                        principalColumn: "Id",
=======
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
>>>>>>> 93787db8daafa996e8308e6a8691930127ebdc74:TorneoFutbolDepartamental.App.Persistencia/Migrations/20211013212650_Entidades.cs
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
<<<<<<< HEAD:TorneoFutbolDepartamental.App.Persistencia/Migrations/20210930000330_Entidades.cs
                        name: "FK_Partidos_Personas_ArbitroId",
                        column: x => x.ArbitroId,
                        principalTable: "Personas",
                        principalColumn: "Id",
=======
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
>>>>>>> 93787db8daafa996e8308e6a8691930127ebdc74:TorneoFutbolDepartamental.App.Persistencia/Migrations/20211013212650_Entidades.cs
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
<<<<<<< HEAD:TorneoFutbolDepartamental.App.Persistencia/Migrations/20210930000330_Entidades.cs
                name: "IX_Equipos_municipioId",
=======
                name: "IX_Equipos_DirectorTecnicoId",
                table: "Equipos",
                column: "DirectorTecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_JugadorId",
>>>>>>> 93787db8daafa996e8308e6a8691930127ebdc74:TorneoFutbolDepartamental.App.Persistencia/Migrations/20211013212650_Entidades.cs
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
<<<<<<< HEAD:TorneoFutbolDepartamental.App.Persistencia/Migrations/20210930000330_Entidades.cs

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EquipoForeignKey",
                table: "Personas",
                column: "EquipoForeignKey",
                unique: true,
                filter: "[EquipoForeignKey] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EquipoId",
                table: "Personas",
                column: "EquipoId");
=======
>>>>>>> 93787db8daafa996e8308e6a8691930127ebdc74:TorneoFutbolDepartamental.App.Persistencia/Migrations/20211013212650_Entidades.cs
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
<<<<<<< HEAD:TorneoFutbolDepartamental.App.Persistencia/Migrations/20210930000330_Entidades.cs
=======
            migrationBuilder.DropTable(
                name: "Partidos");

            migrationBuilder.DropTable(
                name: "Arbitros");

>>>>>>> 93787db8daafa996e8308e6a8691930127ebdc74:TorneoFutbolDepartamental.App.Persistencia/Migrations/20211013212650_Entidades.cs
            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Estadios");

            migrationBuilder.DropTable(
<<<<<<< HEAD:TorneoFutbolDepartamental.App.Persistencia/Migrations/20210930000330_Entidades.cs
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
=======
                name: "DirectoresTecnicos");

            migrationBuilder.DropTable(
                name: "Jugadores");

            migrationBuilder.DropTable(
>>>>>>> 93787db8daafa996e8308e6a8691930127ebdc74:TorneoFutbolDepartamental.App.Persistencia/Migrations/20211013212650_Entidades.cs
                name: "Municipios");
        }
    }
}
