using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AzureDevopsWebAPI.Models
{
    public class Individual
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }

        [ForeignKey("AccessLevel")]
        public int? AccessLevelId { get; set; }
        public AccessLevel? AccessLevel { get; set; }

    }
}
