using System.Linq;
using System.Net.Http;
using taedisoft.Blazor.DataModels;

namespace taedisoft.BlazorServer.Services
{
    public class ProductService : ServiceBace, IProductService
    {
        public ProductService()
        {
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Product>>("api/GetProducts");
        }
    }
}
