using Microsoft.EntityFrameworkCore;

namespace troca_games.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

<<<<<<< HEAD
        public DbSet<Jogo> Jogos { get; set; }
=======
        public DbSet<Jogo> Jogos { get; set;}
>>>>>>> bd95efd550002165915ebecd5eff58ffa6c7f621
    }
}
