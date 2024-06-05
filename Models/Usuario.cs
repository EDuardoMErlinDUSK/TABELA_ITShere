using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoSEMESTRE.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("UsuarioId")]
        [Display(Name = "Codigo do Usuario")]
        public int UsuarioId { get; set; }

        [Column("UsuarioNome")]
        [Display(Name = "Nome do usuario")]
        public string UsuarioNome { get; set; } = string.Empty;

        [Column("UsuarioTelefone")]
        [Display(Name = "Tell do Usuario")]
        public string UsuarioTelefone { get; set;} = string.Empty;

        [Column("UsuarioEmail")]
        [Display(Name = "Email do usuario")]
        public string UsuarioEmail { get; set; } =string.Empty;

        [Column("UsuarioSenha")]
        [Display(Name = "Senha do usuario")]
        public string UsuarioSenha { get; set; } = string.Empty;
    }
}
