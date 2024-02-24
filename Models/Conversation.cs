using System.ComponentModel.DataAnnotations;

namespace Euneo.Models;

// TODO crear modelo para filtrar conversaciones.
// TODO el campo de tipo de chat debe tener sólo las posibles opciones.

public class Conversation
{
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    [Display(Name = "Título")]
    public string? Title { get; set; }

    [Display(Name = "Fecha importación")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm:ss}")]
    public DateTime ImportedDate { get; set; }

    [Display(Name = "Fecha modificación")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm:ss}")]
    public DateTime ModifiedDate { get; set; }

    [Required]
    [Display(Name = "Tipo de chat")]
    public string? Type { get; set; }

}


// ¿Cambios en el modelo?
// Add-Migration <NombreMigracion>
// Update-Database