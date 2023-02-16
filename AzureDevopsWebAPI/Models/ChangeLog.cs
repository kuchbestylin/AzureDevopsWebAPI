using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AzureDevopsWebAPI.Models
{
    public class ChangeLog
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IndividualId { get; set; }
        [Required]
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }

        [ForeignKey(nameof(Project))]
        public int projectId { get; set; }
        public Project? Project { get; set; }

    }
}
