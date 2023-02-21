using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AzureDevopsWebAPI.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string? Name { get; set; }

        [Required]


        [ForeignKey("AccessLevel")]
        public int AccessLevelId { get; set; }
        public AccessLevel? AccessLevel { get; set; }

    }
}
