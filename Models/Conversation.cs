using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

    [ForeignKey("ConversationTypeId")]
    public int? ConversationTypeId { get; set; }

    [Display(Name = "Tipo de Conversación")]
    public virtual ConversationType? ConversationType { get; set; }

    // TODO definir que ocurre con el modelo cuando se le borra una clave foranea
    //ModelBuilder.Entity<Conversation>().HasOne(c => c.ConversationType).WithMany().OnDelete(DeleteBehavior.SetNull);

    
}



// ¿Cambios en el modelo?
// Add-Migration <NombreMigracion>
// Update-Database