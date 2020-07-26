using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IFCore.WebApi.Models
{
    public class IdentidadeSecreta
    {
        public int Id { get; set; }
        public int NomeReal { get; set; }
        public IdentidadeSecreta Identitidade { get; set; }
        public int HeroiId { get; set; }
        public Heroi Heroi  { get; set; }
    }
}
