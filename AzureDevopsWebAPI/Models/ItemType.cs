using System.ComponentModel.DataAnnotations;

namespace AzureDevopsWebAPI.Models
{
    public class ItemType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Value { get; set; }
    }
}
