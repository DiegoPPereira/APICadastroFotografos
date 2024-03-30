using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroFotografo.Model
{
    [Table("Visitas")]
    public class Visita
    {
        [Key]
        public int VisitaId { get; set; }

        [Required]
        [StringLength(50)] // Define o tamanho máximo da string para 50 caracteres
        public string? DataHora { get; set; }

        [Required]
        public int FotografoId { get; set; } // Referência ao Fotografo que realizou a visita

        [ForeignKey("FotografoId")]
        public Fotografo? Fotografos { get; set; } // Propriedade de navegação para Fotografo
    }
}
