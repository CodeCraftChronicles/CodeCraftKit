using System.ComponentModel.DataAnnotations;

namespace Shared.DTO.Requests.Identity;

public class ForgotPasswordRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}