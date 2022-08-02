using System.Linq;
using System.Net.Http;
using taedisoft.Blazor.DataModels;

namespace taedisoft.BlazorServer.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient client;

        public ProductService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            client.BaseAddress = new Uri("http://localhost:5001");
            client.DefaultRequestHeaders.Add("Accept", "Application/json");

            return await client.GetFromJsonAsync<IEnumerable<Product>>("api/GetProducts"); 
        }
    }
}
