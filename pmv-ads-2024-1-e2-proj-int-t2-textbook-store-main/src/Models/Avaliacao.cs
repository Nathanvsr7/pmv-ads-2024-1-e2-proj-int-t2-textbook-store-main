using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducaLivros.Models;

[Table("avaliacaoes")]
public class Avaliacao
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Avaliador")]
    public int UsuarioId { get; set; }

    [ForeignKey("UsuarioId")]
    public Usuario Avaliador { get; set; }

    [Display(Name = "Avaliação do livro")]
    [Required(ErrorMessage = "Informe a nota dada a esse livro")]
    public int NotaLivro { get; set; }

    [Display(Name = "Cometário sobre o livro")]
    public string ComentarioLivro { get; set; }

    [Display(Name = "Avaliação do Anunciante")]
    [Required(ErrorMessage = "Informe a nota dada ao Anunciante")]
    public int NotaAnunciante { get; set; }

    [Display(Name = "Cometário sobre o anunciante")]
    public string ComentarioAnunciante { get; set; }


}