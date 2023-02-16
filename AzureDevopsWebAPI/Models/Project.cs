using System.ComponentModel.DataAnnotations;

namespace AzureDevopsWebAPI.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
