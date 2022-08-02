using taedisoft.Blazor.DataModels;

namespace taedisoft.BlazorServer.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
