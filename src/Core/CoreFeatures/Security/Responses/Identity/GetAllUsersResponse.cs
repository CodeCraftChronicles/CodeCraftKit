using System.Collections.Generic;

namespace Core.CoreFeatures.Security.Responses.Identity;

public class GetAllUsersResponse
{
    public IEnumerable<UserResponse> Users { get; set; }
}