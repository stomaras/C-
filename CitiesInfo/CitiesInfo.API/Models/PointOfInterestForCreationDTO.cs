using System.ComponentModel.DataAnnotations;
using FluentValidation;
namespace CitiesInfo.API.Models
{
    public class PointOfInterestForCreationDTO
    {
        /*
         * Use different DTOs for updating, creating, deleting resources
         * 
         */

        
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }

    
}
