using CityInfo.API.Models;
using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Models
{
    public class WindDirectionDescriptionsDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Range(0, 360, ErrorMessage = "IntervalStart must be greater than or equal to 0, and smaller than 360")]
        [CompareIntervals(ErrorMessage = "IntervalStop must be greater than IntervalStart")]
        public int IntervalStart { get; set; }
        [Required]
        [Range(0, 360, ErrorMessage = "IntervalStop must be greater than or equal to 0, and smaller than 360")]
        public int IntervalStop { get; set; }
        [Required]
        [Range(0, 4, ErrorMessage = "Score must be between 0 and 4")]
        public WindCategory Category { get; set; }
    }
        public enum WindCategory
        {
            SideOnshore = 0,
            Onshore = 1,
            OverLand = 2,
            SideOffshore = 3,
            Offshore = 4,
        }
}
public class CompareIntervalsAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var windDirectionDescriptionsDto = (WindDirectionDescriptionsDto)validationContext.ObjectInstance;
        if (windDirectionDescriptionsDto.IntervalStart >= windDirectionDescriptionsDto.IntervalStop)
        {
            return new ValidationResult("IntervalStop must be greater than IntervalStart");
        }
        return ValidationResult.Success;
    }
}