using Microsoft.EntityFrameworkCore;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Arbitro> Arbitros {get;set;}
        public DbSet<Equipo> Equipos {get;set;}
        public DbSet<Estadio> Estadios {get;set;}
        public DbSet<Jugador> Jugadores {get;set;}
        public DbSet<Municipio> Municipios {get;set;}
        public DbSet<Partido> Partidos {get;set;}
<<<<<<< HEAD
        public DbSet<DirectorTecnico> Tecnicos  {get;set;}
 protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Equipo>()
            .HasOne(p => p.DirectorTecnico)
            .WithOne(i => i.Equipo)
            .HasForeignKey<DirectorTecnico>(b => b.EquipoForeignKey);
    }
=======
        public DbSet<DirectorTecnico> DirectoresTecnicos {get;set;}

>>>>>>> 93787db8daafa996e8308e6a8691930127ebdc74
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if(!optionBuilder.IsConfigured){
                optionBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = TorneoFutbolDepartamental.Data");
            }
        }
    }
}