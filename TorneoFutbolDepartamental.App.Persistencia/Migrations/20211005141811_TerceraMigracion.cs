using Microsoft.EntityFrameworkCore.Migrations;

namespace TorneoFutbolDepartamental.App.Persistencia.Migrations
{
    public partial class TerceraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Personas_DirectorTecnicoPersonaId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Personas_ArbitroPersonaId",
                table: "Partidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "ColegioPertenece",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "DirectorTecnico_Equipo",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "IdArbitro",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "IdJugador",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "IdTecnico",
                table: "Personas");

            migrationBuilder.RenameTable(
                name: "Personas",
                newName: "Jugadores");

            migrationBuilder.RenameColumn(
                name: "marcador",
                table: "Partidos",
                newName: "Marcador");

            migrationBuilder.RenameColumn(
                name: "ArbitroPersonaId",
                table: "Partidos",
                newName: "ArbitroId");

            migrationBuilder.RenameIndex(
                name: "IX_Partidos_ArbitroPersonaId",
                table: "Partidos",
                newName: "IX_Partidos_ArbitroId");

            migrationBuilder.RenameColumn(
                name: "cntPartidosJugados",
                table: "Equipos",
                newName: "Cnt_PartidosJugados");

            migrationBuilder.RenameColumn(
                name: "cntPartidosGanados",
                table: "Equipos",
                newName: "Cnt_PartidosGanados");

            migrationBuilder.RenameColumn(
                name: "cntPartidosEmpatados",
                table: "Equipos",
                newName: "Cnt_PartidosEmpatados");

            migrationBuilder.RenameColumn(
                name: "DirectorTecnicoPersonaId",
                table: "Equipos",
                newName: "JugadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_DirectorTecnicoPersonaId",
                table: "Equipos",
                newName: "IX_Equipos_JugadorId");

            migrationBuilder.RenameColumn(
                name: "PersonaId",
                table: "Jugadores",
                newName: "JugadorId");

            migrationBuilder.AddColumn<string>(
                name: "Ciudad",
                table: "Estadios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DirectorTecnicoId",
                table: "Equipos",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Numero",
                table: "Jugadores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jugadores",
                table: "Jugadores",
                column: "JugadorId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_DirectorTecnicoId",
                table: "Equipos",
                column: "DirectorTecnicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_DirectoresTecnicos_DirectorTecnicoId",
                table: "Equipos",
                column: "DirectorTecnicoId",
                principalTable: "DirectoresTecnicos",
                principalColumn: "DirectorTecnicoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Jugadores_JugadorId",
                table: "Equipos",
                column: "JugadorId",
                principalTable: "Jugadores",
                principalColumn: "JugadorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Arbitros_ArbitroId",
                table: "Partidos",
                column: "ArbitroId",
                principalTable: "Arbitros",
                principalColumn: "ArbitroId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_DirectoresTecnicos_DirectorTecnicoId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Jugadores_JugadorId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Arbitros_ArbitroId",
                table: "Partidos");

            migrationBuilder.DropTable(
                name: "Arbitros");

            migrationBuilder.DropTable(
                name: "DirectoresTecnicos");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_DirectorTecnicoId",
                table: "Equipos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jugadores",
                table: "Jugadores");

            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "Estadios");

            migrationBuilder.DropColumn(
                name: "DirectorTecnicoId",
                table: "Equipos");

            migrationBuilder.RenameTable(
                name: "Jugadores",
                newName: "Personas");

            migrationBuilder.RenameColumn(
                name: "Marcador",
                table: "Partidos",
                newName: "marcador");

            migrationBuilder.RenameColumn(
                name: "ArbitroId",
                table: "Partidos",
                newName: "ArbitroPersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_Partidos_ArbitroId",
                table: "Partidos",
                newName: "IX_Partidos_ArbitroPersonaId");

            migrationBuilder.RenameColumn(
                name: "JugadorId",
                table: "Equipos",
                newName: "DirectorTecnicoPersonaId");

            migrationBuilder.RenameColumn(
                name: "Cnt_PartidosJugados",
                table: "Equipos",
                newName: "cntPartidosJugados");

            migrationBuilder.RenameColumn(
                name: "Cnt_PartidosGanados",
                table: "Equipos",
                newName: "cntPartidosGanados");

            migrationBuilder.RenameColumn(
                name: "Cnt_PartidosEmpatados",
                table: "Equipos",
                newName: "cntPartidosEmpatados");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_JugadorId",
                table: "Equipos",
                newName: "IX_Equipos_DirectorTecnicoPersonaId");

            migrationBuilder.RenameColumn(
                name: "JugadorId",
                table: "Personas",
                newName: "PersonaId");

            migrationBuilder.AlterColumn<int>(
                name: "Numero",
                table: "Personas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ColegioPertenece",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DirectorTecnico_Equipo",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdArbitro",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdJugador",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdTecnico",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Personas_DirectorTecnicoPersonaId",
                table: "Equipos",
                column: "DirectorTecnicoPersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Personas_ArbitroPersonaId",
                table: "Partidos",
                column: "ArbitroPersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
