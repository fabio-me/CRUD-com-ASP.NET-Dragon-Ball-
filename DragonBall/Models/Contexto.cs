using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonBall.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Personagem> Personagems { get; set; }
        public Contexto(DbContextOptions<Contexto> op) : base (op)
        {

        }
    }
}
