using System.ComponentModel.DataAnnotations;

namespace Euneo.Models;

// TODO crear modelo para filtrar conversaciones.
// TODO Fecha de importación como campo no editable fijado en creación.
public class Conversation
{
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    [Display(Name = "Título")]
    public string? Title { get; set; }

    [Display(Name = "Fecha importación")]
    [DataType(DataType.Date)]
    public DateTime ImportedDate { get; set; }

    [Required]
    [Display(Name = "Tipo de chat")]
    public string? Type { get; set; }
}
