namespace Core.CoreFeatures.Security.Requests.Identity;

public class RefreshTokenRequest
{
    public string Token { get; set; }
    public string RefreshToken { get; set; }
}