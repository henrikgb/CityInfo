using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityInfo.API.Entities
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Generating primary keys
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }

        public ICollection<PointOfInterest> PointsOfInterest { get; set; }
               = new List<PointOfInterest>();

        // Name should not have a null value...
        // We want City to always have a name...
        public City(string name)
        {
            Name = name;
        }
    }
}