using Shared.DTO.Requests;

namespace Core.CoreFeatures.Interfaces.Services;

public interface IUploadService
{
    string UploadAsync(UploadRequest request);
}