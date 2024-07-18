using System.Threading.Tasks;

namespace WebApi.Core.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<bool> IsBrandUsed(int brandId);
    }
}