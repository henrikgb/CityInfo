using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Entities
{
    public class PointOfInterest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Generating primary keys
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }

        [ForeignKey("CityId")]
        public City? City { get; set; }
        public int CityId { get; set; }

        // Name should not have a null value...
        // We want PointOfInterest to always have a name...
        public PointOfInterest(string name)
        {
            Name = name;
        }
    }
}