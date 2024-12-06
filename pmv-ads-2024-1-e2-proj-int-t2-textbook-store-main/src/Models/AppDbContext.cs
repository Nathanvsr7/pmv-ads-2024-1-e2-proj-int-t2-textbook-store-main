using Microsoft.EntityFrameworkCore;

namespace EducaLivros.Models;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; }

    public DbSet<Anuncio> Anuncios { get; set; }

    public DbSet<Avaliacao> Avaliacoes { get; set; }

    public DbSet<Chat> Chats { get; set; }

    public DbSet<Mensagem> Mensagens { get; set; }
}
