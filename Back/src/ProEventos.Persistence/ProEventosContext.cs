using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;


namespace ProEventos.Persistence
{
    public class ProEventosContext : DbContext
    {
         public ProEventosContext(DbContextOptions<ProEventosContext> options) : base(options)  { }       
         public DbSet<Evento> Eventos { get; set; }
         public DbSet<Palestrante> Palestrantes { get; set; }  
         public DbSet<Lote> Lotes { get; set; }  
         public DbSet<RedeSocial> RedesSocials { get; set; }  
         public DbSet<PalestranteEvento> PalestrantesEventos { get; set; }  

         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             modelBuilder.Entity<PalestranteEvento>()
             .HasKey(PE => new {PE.EventoId, PE.PalestranteId});
             // dado um palestrante e um evento, o evento pode ter muitos palestrantes e o palestrante pode ter muitos eventos
         }

    }
}