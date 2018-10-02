using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class Nota
    {
        [Key]
        public int Cod_Cedula { get; set; }
        public string Cedula { get; set; }
        public byte Quantidade { get; set; }
        public TipoDeCedula Vlr_Cedula { get; set; }
    }

    public enum TipoDeCedula
    {
        Dez,
        Vinte,
        Cinquenta,
        Cem
    }
}
