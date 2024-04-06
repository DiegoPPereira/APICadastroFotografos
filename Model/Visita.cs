using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CadastroFotografo.Model
{
    [Table("Visitas")]
    public class Visita
    {
        [Key]
        public int VisitaId { get; set; }

        [Required]
        public DateTime DataHora { get; set; }

        [Required]
        public int FotografoId { get; set; }

        [JsonIgnore]
        [ForeignKey("FotografoId")]
        public Fotografo? Fotografo { get; set; }
    }
}
