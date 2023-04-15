using System.ComponentModel.DataAnnotations;

namespace Euneo.Models
{
    public class Conversation
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ImportedDate { get; set; }
    }
}
