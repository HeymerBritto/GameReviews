using GameReviews.Enums;
using GameReviews.Models.Abstract;
using System.Collections.Generic;

namespace GameReviews.Models
{
    public class Jogo : ModeloBase
    {
        public string Descricao { get; set; }
        public Plataforma Plataforma { get; set; }

        public IList<Reviews> Reviews { get; set; }
    }
}
