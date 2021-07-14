using GameReviews.Enums;
using GameReviews.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameReviews.Core.Entity
{
    public class GameReviewContext : DbContext
    {
        public GameReviewContext(DbContextOptions<GameReviewContext> options) : base(options)
        {
        }

        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<Review> Review { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // modelBuilder.Entity<Jogo>().Property(e => e.Plataforma)
            //     .HasConversion(
            //         v => v.ToString(),
            //         v => (Plataforma)Enum.Parse(typeof(Plataforma), v))
            //         .IsUnicode(false);

            // var meusJogos = new List<Jogo>()
            // {
            //     new Jogo() { Id = Guid.NewGuid(), Descricao = "God of War", Plataforma = Plataforma.PS },
            //     new Jogo() { Id = Guid.NewGuid(), Descricao = "The Last of Us - Part 2", Plataforma = Plataforma.PS },
            //     new Jogo() { Id = Guid.NewGuid(), Descricao = "Final Fantasy VII - Remake", Plataforma = Plataforma.PS },
            // };

            // modelBuilder.Entity<Jogo>().HasData(meusJogos);

            // var meusReviews = new List<Review>()
            // {
            //     new Review() {
            //         Id = Guid.NewGuid(),
            //         JogoId = meusJogos[0].Id,
            //         Descricao = "God of War doesn’t just feel like the next step for the franchise, but for the entire video game industry. Phenomenal visuals, rewarding exploration, and a deep, nuanced combat system contribute to an epic adventure that should be experienced by every human on earth. Santa Monica Studio is taking us all to Valhalla.",
            //         Nota = 100
            //     },
            //      new Review() {
            //         Id = Guid.NewGuid(),
            //         JogoId = meusJogos[1].Id,
            //         Descricao = "The Last of Us Part II is the perfect combination of an excellent Hollywood movie with a fat budget with fun and flowing gameplay. The phenomenal writing will touch every player and won't leave an eye dry of tears. Combat and exploration are challenging and lead the player to use creativity and improvisation. A real masterpiece and a must-have for every PS4 owner.",
            //         Nota = 100
            //     },
            //       new Review() {
            //         Id = Guid.NewGuid(),
            //         JogoId = meusJogos[2].Id,
            //         Descricao = "Final Fantasy VII Remake is the best JRPG from Square since Final Fantasy VII. It takes a classic, carefully builds on it, and although certain changes made to the story may not be as well-received by all players, overall there's no denying that it's a massive success.",
            //         Nota = 100
            //     },
            // };

            // modelBuilder.Entity<Review>().HasData(meusReviews);
        }
    }
}
