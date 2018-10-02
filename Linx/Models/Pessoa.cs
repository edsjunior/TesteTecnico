using System.ComponentModel.DataAnnotations;

namespace Linx.Models
{
    public class Pessoa
    {
        [Key]
        public int Cod_Pessoa { get; set; }
        [Required(ErrorMessage = "Digite um nome.")]
        public string Nom_Pessoa { get; set; }
        [Required(ErrorMessage = "Selecione uma profissão.")]
        public string Nom_Profissao { get; set; }

        public enum Profissao
        {
            Engenheiro,
            Mecânico,
            Motorista,
            Professor,
            Enfermeira
        }

    }
}