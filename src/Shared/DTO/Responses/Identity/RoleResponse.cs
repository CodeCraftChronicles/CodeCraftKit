using System.ComponentModel.DataAnnotations;

namespace Core.CoreFeatures.Security.Responses.Identity;

public class RoleResponse
{
    public string Id { get; set; }

    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
}