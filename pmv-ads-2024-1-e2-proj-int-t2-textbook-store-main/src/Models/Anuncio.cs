using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducaLivros.Models;

[Table("anuncios")]
public class Anuncio
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Anunciante")]
    public int UsuarioId { get; set; }

    [ForeignKey("UsuarioId")]
    public Usuario Anunciante { get; set; }

    [Required(ErrorMessage = "Informa o título é obrigatório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "Informa a edição é obrigatório")]
    public int Edicao { get; set; }

    [Required(ErrorMessage = "Informa o ISBN é obrigatório")]
    public string ISBN { get; set; }
}