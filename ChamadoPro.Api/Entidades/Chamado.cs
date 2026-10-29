namespace ChamadoPro.Api.Entidades;

public class Chamado
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public PrioridadeChamado Prioridade { get; set; }
    public StatusChamado Status { get; set; } = StatusChamado.Aberto;
    public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; } = null!;
    public List<Comentario> Comentarios { get; set; } = [];
}
