using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducaLivros.Models;

[Table("chats")]
public class Chat
{
    [Key]
    public int Id { get; set; }

    public int AnuncioId { get; set; }

    [ForeignKey("AnuncioId")]
    public Anuncio Anuncio { get; set; }

    [Display(Name = "Chat iniciado em:")]
    public DateTime Inicio { get; set; }
}