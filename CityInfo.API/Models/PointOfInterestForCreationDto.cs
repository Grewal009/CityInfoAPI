using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Models;

public class PointOfInterestForCreationDto
{
    [Required(ErrorMessage = "You should provide a name value.")]  //System.ComponentModel.DataAnnotations
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "You should provide a description.")]
    [MaxLength(200)]
    public string? Description { get; set; }
    
    
    
}