using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AzureDevopsWebAPI.Models.Dto
{
    public class IndividualDto
    {

        [Required]
        public string? Email { get; set; }

        public string? Password { get; set; }
    }
}
