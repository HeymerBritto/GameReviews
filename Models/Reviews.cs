using GameReviews.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameReviews.Models
{
    public class Reviews : ModeloBase
    {
        public Guid JogoId { get; set; }
        public string Review { get; set; }
        public int Nota { get; set; }
    }
}
