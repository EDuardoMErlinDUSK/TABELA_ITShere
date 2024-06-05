using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoSEMESTRE.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Column("PessoaId")]
        [Display(Name = "Codigo do pessoa")]
        public int PessoaId { get; set; }

        [Column("PessoaNome")]
        [Display(Name = "Nome da pessoa")]
        public string PessoaNome { get; set; } = string.Empty;

        [Column("PessoaRoupa")]
        [Display(Name = "roupa da pessoa")]
        public string PessoaRoupa { get; set; } = string.Empty;

        [Column("PessoaCor")]
        [Display(Name = "roupa da pessoa")]
        public string PessoaCor { get; set; } = string.Empty;

        [Column("PessoaSexo")]
        [Display(Name = "sexo da pessoa")]
        public string PessoaSexo { get; set; } = string.Empty;

        [Column("PessoaObservacao")]
        [Display(Name = "observacao da pessoa")]
        public string PessoaObservacao { get; set; } = string.Empty;

        [Column("PessoaLocalDesaparecimento")]
        [Display(Name = "local de desaparecimento da pessoa")]
        public string PessoaLocalDesaparecimento { get; set; } = string.Empty;

        [Column("PessoaFoto")]
        [Display(Name = "foto da pessoa")]
        public string PessoaFoto { get; set; } = string.Empty;

        [Column("PessoaDtDesaparecimento")]
        [Display(Name = "Data da obssrvacao")]
        public DateTime PessoaDtDesaparecimento { get; set; }

        [Column("PessoaDtEncontro")]
        [Display(Name = "Data de encontro da pessoa")]
        public DateTime? PessoaDtEncontro { get; set; }

        [Column("PessoaStatus")]
        [Display(Name = "Data de encontro da pessoa")]
        public byte PessoaStatus { get; set; }

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
