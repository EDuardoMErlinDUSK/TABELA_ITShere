using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoSEMESTRE.Models
{
    [Table("Observacoes")]
    public class Observacoes
    {
        [Column("ObservacoesId")]
        [Display(Name = "Codigo do observacoes")]
        public int ObservacoesId { get; set; }

        [Column("ObservacaoDescricao")]
        [Display(Name = "Nome do usuario")]
        public string ObservacaoDescricao { get; set; } = string.Empty;

        [Column("ObservacaoLocal")]
        [Display(Name = "Codigo do observacoes")]
        public string ObservacaoLocal { get; set; } = string.Empty;

        [Column("ObservacaoData")]
        [Display(Name = "Data da obssrvacao")]
        public DateTime ObservacaoData { get; set; }

        [ForeignKey("PessoaId")]
        public int PessoaId { get; set; }
        public Pessoa? Pessoa { get; set; }

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }


    }
}
