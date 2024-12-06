using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducaLivros.Models;

[Table("mensagens")]
public class Mensagem
{
    [Key]
    public int Id { get; set; }

    public int ChatId { get; set; }

    [ForeignKey("ChatId")]
    public Chat Chat { get; set; }

    public int UsuarioId { get; set; }

    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }

    [Required(ErrorMessage = "Informe o conteúdo da mensagem")]
    public string Conteudo { get; set; }

    [Display(Name = "Enviada em")]
    [DefaultValue("CURRENT_TIMESTAMP")]
    public DateTime EnviadaEm { get; set; }
}
