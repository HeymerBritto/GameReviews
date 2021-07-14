using System.Linq;
using GameReviews.Core.Entity;
using GameReviews.Models;
using HotChocolate;
using HotChocolate.Types;

namespace GameReviews.GraphQL.ObjectTypes
{
    public class ReviewType : ObjectType<Review>
    {
        // since we are inheriting from objtype we need to override the functionality
        protected override void Configure(IObjectTypeDescriptor<Review> descriptor)
        {
            descriptor.Description("Review de um jogo após seu lançamento");

            descriptor.Field(x => x.Descricao)
                .Description("Review feito pela empresa/youtuber");

            descriptor.Field(x => x.Nota)
                .Description("Nota dada ao jogo pela empresa/youtuber");    

            descriptor.Field(x => x.Jogo).Ignore();

            descriptor.Field(x => x.Jogo)
                .ResolveWith<Resolvers>(p => p.GetJogos(default!, default!))
                .UseDbContext<GameReviewContext>()
                .Description("Jogo vinculado ao review");            
        }

        private class Resolvers
        {
            public IQueryable<Jogo> GetJogos(Jogo jogo, [ScopedService] GameReviewContext context)
            {
                return context.Jogo.Where(x => x.Id == jogo.Id);
            }
        }
    }
}