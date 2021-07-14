using GameReviews.Models.Abstract;
using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameReviews.Models
{
    public class Review : ModeloBase
    {
        public string Descricao { get; set; }
        public int Nota { get; set; }
        public Guid JogoId { get; set; }
        public Jogo Jogo { get; set; }
    }
}
