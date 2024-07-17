using System.ComponentModel.DataAnnotations;

namespace Core.CoreFeatures.Security.Requests.Identity;

public class ForgotPasswordRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}