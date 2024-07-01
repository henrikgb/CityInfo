using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Models
{
    public class KiteSpotsLocationForUpdateDto
    {
        [Required]
        [MaxLength(50)]
        public string NameId { get; set; } = string.Empty;
        [Required]
        [Range(-90, 90, ErrorMessage = "Latitude must be between -90 and 90.")]
        public double Latitude { get; set; }
        [Required]
        [Range(-180, 180, ErrorMessage = "Longitude must be between -180 and 180.")]
        public double Longitude { get; set; }
    }
}
