using WebApi.Core.Interfaces.Common;

namespace WebApi.Core.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}