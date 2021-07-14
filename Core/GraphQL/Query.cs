using System.Linq;
using GameReviews.Core.Entity;
using GameReviews.Models;
using HotChocolate;
using HotChocolate.Data;

namespace GameReviews.Core.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(GameReviewContext))]
        public IQueryable<Review> GetReviews([ScopedService] GameReviewContext context)
        {
            return context.Review;
        }

        [UseDbContext(typeof(GameReviewContext))]
        public IQueryable<Jogo> GetJogos([ScopedService] GameReviewContext context)
        {
            return context.Jogo;
        }
    }
}