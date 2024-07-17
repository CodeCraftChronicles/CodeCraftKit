using Core.CoreFeatures.Security.Requests;

namespace Core.CoreFeatures.Interfaces.Services;

public interface IUploadService
{
    string UploadAsync(UploadRequest request);
}