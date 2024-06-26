﻿using Microsoft.EntityFrameworkCore;

namespace troca_games.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Jogo> Jogos { get; set; }

        public DbSet<Desejo> Desejos { get; set; }
    }
}
