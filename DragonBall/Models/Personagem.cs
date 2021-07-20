using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DragonBall.Models
{
    public class Personagem
    {
        [Key]
        public int PersonagemId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string UrlImg { get; set; }
    }
}
