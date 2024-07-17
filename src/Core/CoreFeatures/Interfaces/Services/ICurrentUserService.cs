using Core.CoreFeatures.Interfaces.Common;

namespace Core.CoreFeatures.Interfaces.Services;

public interface ICurrentUserService : IService
{
    string UserId { get; }
}