using System.ComponentModel.DataAnnotations;

namespace ToDoApi.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(140)]
        public string Name { get; set; }

        [Required]
        public bool IsDone { get; set; }


        // public string Description { get; set; }
    }
}