using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcTodo.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TodoText { get; set; }
        [Required]
        public DateTime Deadline { get; set; }
        [Required]
        public bool IsComplete { get; set; }
        [Required]
        [Range(1, 3, ErrorMessage = "Select prioraty correct")]
        public byte Priority { get; set; } = 1;

        [NotMapped]
        public string PrioratyText { get { if (Priority == 1) return "Relax"; else if (Priority == 2) return "Secondary"; return "Immediate"; }}

    }
}
