using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AzureDevopsWebAPI.Models
{
    public class Individual
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [ForeignKey(nameof(ChangeLog))]
        public int ChangeLogId { get; set; }
        public ChangeLog? ChangeLog { get; set; }

    }
}
