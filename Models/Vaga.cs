using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_jobsnet
{
    [Table("vagas")]
    public class Vaga
    {
        [Key]
        [Column("id")]
        public int Id {get; set;}
        [Column("nome", TypeName = "varchar")]
        [MaxLength(150)]
        [Required]
        public string Nome {get;set;}
        [Column("descricao",TypeName ="varchar")]
        [MaxLength(150)]
        [Required]
        public string Descricao {get; set;}
        

    }
}