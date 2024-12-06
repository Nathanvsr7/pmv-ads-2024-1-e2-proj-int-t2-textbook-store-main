using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducaLivros.Models;

[Table("usuarios")]
public class Usuario
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "É obrigatório informar o nome.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "É obrigatório informar o e-mail")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Required(ErrorMessage = "É obrigatório informar a senha")]
    [MinLength(6, ErrorMessage = "A senha deve ter no mínimo 6 caracteres")]
    public string Senha { get; set; }

    public TipoUsuario Tipo { get; set; } = TipoUsuario.Usuario;
}

public enum TipoUsuario
{
    Administrador,
    Usuario
}