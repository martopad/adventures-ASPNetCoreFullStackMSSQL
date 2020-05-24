using System.ComponentModel.DataAnnotations;

namespace ToDoApi.Dtos
{
    public class ToDoCreateDto
    {
        [Required]
        [MaxLength(140)]
        public string Name { get; set; }

        [Required]
        public bool IsDone { get; set; }

        // public string Description { get; set; }
    }
}