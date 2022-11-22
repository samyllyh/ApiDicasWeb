using System.ComponentModel.DataAnnotations;

namespace ApiDicasWeb.Model;

public class Dica
{
    public int DicaId { get; set; }

    [Required]
    [StringLength(80)]
    public string Titulo { get; set; }

    [Required]
    [StringLength(int.MaxValue)]
    public string? Descrição { get; set; } 
}