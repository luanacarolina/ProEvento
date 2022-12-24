using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{
    public class EventoContext : DbContext
    {
        public EventoContext(DbContextOptions<EventoContext> options): base(options)
        {
            
        }

        public DbSet<Evento> Eventos { get; set; } = null!;
    }
}