using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ex007_CRUD.Models
{
    [Table("Serie")]
    public class Series
    {
        [Key]
        public int SerieId { get; set; }

        [Required(ErrorMessage="Nome é obrigatorio")]
        [MaxLength(200, ErrorMessage="Descrição pode exceder {1} caracteres")]
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
    }
}