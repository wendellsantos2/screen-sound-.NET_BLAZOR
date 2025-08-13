namespace ScreenSound.Web.Response;

public record ArtistaResponse(int Id, string Nome, string Bio, string? FotoPerfil)
{
    public int ?Classificacao { get; set; } = 0;
};