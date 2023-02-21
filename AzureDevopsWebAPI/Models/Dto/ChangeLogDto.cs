using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AzureDevopsWebAPI.Models.Dto
{
    public class ChangeLogDto
    {
        [Required] public int IndividualId { get; set; }
        
        [Required] public int ProjectId { get; set; }

        [Required] public int ItemTypeId { get; set; }
        
        [Required] public string? Summary { get; set; }
    }
}
