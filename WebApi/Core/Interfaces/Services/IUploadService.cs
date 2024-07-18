using BlazorHero.CleanArchitecture.Application.Requests;

namespace WebApi.Core.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}