using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Euneo.Models;

public class ConversationType
{
    [Key]
    public int ConversationTypeId { get; set; }

    [Required]
    [Display(Name = "Nombre de tipo de Conversación")]
    public string? ConversationTypeName { get; set; }

    public virtual ICollection<Conversation>? Conversations { get; set; }


}
