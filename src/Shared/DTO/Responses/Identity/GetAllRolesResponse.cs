using System.Collections.Generic;

namespace Core.CoreFeatures.Security.Responses.Identity
{
    public class GetAllRolesResponse
    {
        public IEnumerable<RoleResponse> Roles { get; set; }
    }
}