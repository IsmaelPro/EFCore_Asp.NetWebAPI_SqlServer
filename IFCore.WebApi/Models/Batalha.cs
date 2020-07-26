﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IFCore.WebApi.Models
{
    public class Batalha
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime dtFim { get; set; }
        public List<HeroiBatalha> HeroiBatalhas { get; set; }

    }
}
