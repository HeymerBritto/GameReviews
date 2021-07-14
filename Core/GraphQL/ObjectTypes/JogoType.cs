using System.Linq;
using GameReviews.Core.Entity;
using GameReviews.Models;
using HotChocolate;
using HotChocolate.Types;

namespace GameReviews.GraphQL.ObjectTypes
{
    public class JogoType : ObjectType<Jogo>
    {
        protected override void Configure(IObjectTypeDescriptor<Jogo> descriptor)
        {
            descriptor.Description("Jogo de PC, PS, Xbox ou Multiplataforma");

            descriptor.Field(x => x.Descricao)
                .Description("Descrição do jogo");

            descriptor.Field(x => x.Plataforma)
                .Description("Plataforma em que se encontra o jogo");

            //descriptor.Field(x => x.Reviews).Ignore();

            descriptor.Field(x => x.Reviews)
                .ResolveWith<Resolvers>(p => p.GetReviews(default!, default!))
                .UseDbContext<GameReviewContext>()
                .Description("Reviews vinculadas ao jogo");
        }

        private class Resolvers
        {
            public IQueryable<Review> GetReviews(Review review, [ScopedService] GameReviewContext context)
            {
                return context.Review.Where(x => x.Id == review.Id);
            }
        }
    }
}