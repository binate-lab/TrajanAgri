namespace Operateurs.Api.Models;

public class Operateur
{
    public Guid Id { get; set; }
    public string CodeOp { get; set; } = null!;
    public string Nom { get; set; } = null!;
    public string Prenoms { get; set; } = null!;
    public string? Email { get; set; }
    public string Telephone1 { get; set; } = null!;
    public string? Telephone2 { get; set; }
    public bool EstCooperateur { get; set; } = false;
    public string? Localite { get; set; }
    public string? observations { get; set; }
    public string? Qualite { get; set; }
}
