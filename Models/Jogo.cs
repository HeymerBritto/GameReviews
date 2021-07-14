using GameReviews.Enums;
using GameReviews.Models.Abstract;
using HotChocolate;
using System.Collections.Generic;

namespace GameReviews.Models
{
    public class Jogo : ModeloBase
    {
        public string Descricao { get; set; }
        public Plataforma Plataforma { get; set; }

        public IList<Review> Reviews { get; set; }
    }
}
