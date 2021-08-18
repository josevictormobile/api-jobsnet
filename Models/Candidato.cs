using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_jobsnet
{
    [Table("candidatos")]
    public class Candidato
    {
        [Key]
        [Column("id")]
        public int Id {get; set;}
        [Column("nome", TypeName = "varchar")]
        [MaxLength(150)]
        [Required]
        public string Nome {get;set;}
        [Column("cpf",TypeName ="varchar")]
        [MaxLength(150)]
        [Required]
        public string Cpf {get; set;}
        [Column("nascimento",TypeName ="varchar")]
        [MaxLength(150)]
        [Required]
        public string Nascimento {get; set;}
        [Column("cep",TypeName = "varchar")]
        [MaxLength(150)]
        [Required]
        public string Cep {get; set;}
        [Column("logradouro", TypeName = "varchar")]
        [MaxLength(150)]
        [Required]
        public string Logradouro {get; set;}
        [Column("numero_logradouro",TypeName ="int")]
        [Required]
        public int Numero {get; set;}
        [Column("bairro",TypeName ="varchar")]
        [MaxLength(150)]
        [Required]
        public string Bairro {get; set;}
        [Column("cidade",TypeName ="varchar")]
        [MaxLength(150)]
        [Required]
        public string Cidade {get; set;}
        [Column("Estado",TypeName = "varchar")]
        [MaxLength(150)]
        [Required]
        public string Estado {get; set;}
        [Column("telefone",TypeName = "varchar")]
        [MaxLength(150)]
        public string Telefone {get; set;}
        [Column("email",TypeName = "varchar")]
        [MaxLength(150)]
        [Required]
        public string Email {get; set;}

        [Column("id_vaga",TypeName = "int")]
        [Required]
        [ForeignKey("Vaga")]
        public int Id_Vaga {get; set;}

    }
}