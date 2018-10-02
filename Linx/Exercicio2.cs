using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Linx
{
    public class Exercicio2
    {
        public Profissao Nom_Profissao { get; set; }
    }
        public enum Profissao
        {
            Engenheiro,
            Mecânico,
            Motorista,
            Professor,
            Enfermeira
        }
}