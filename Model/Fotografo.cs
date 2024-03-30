using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroFotografo.Model
{
    [Table("Fotografos")]
    public class Fotografo
    {
        [Key]
        public int FotografoId { get; set; }

        [Required]
        [StringLength(100)]
        public string NomeCompleto { get; set; }

        [Required]
        [StringLength(14)]
        [DisplayFormat(DataFormatString = "{0:###.###.###-##}")]
        public string CPF { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Telefone { get; set; }

        [Required]
        [StringLength(200)]
        public string Endereco { get; set; }

        [Required]
        [StringLength(100)]
        public string CameraFotografica { get; set; }

        public DateTime? DataUltimaVisita { get; set; }

        public ICollection<Visita> Visitas { get; set; }

        public Fotografo() => Visitas = new Collection<Visita>();
    }
}
