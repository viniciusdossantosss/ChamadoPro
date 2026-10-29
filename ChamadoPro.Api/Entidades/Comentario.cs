namespace ChamadoPro.Api.Entidades;

public class Comentario
{
    public int Id { get; set; }
    public string Texto { get; set; } = string.Empty;
    public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
    public int ChamadoId { get; set; }
    public Chamado Chamado { get; set; } = null!;
}
