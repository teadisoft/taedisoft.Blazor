using Microsoft.AspNetCore.Components;
using System.Net.Http;
using taedisoft.Blazor.DataModels;
using taedisoft.BlazorServer.Services;

namespace taedisoft.BlazorServer.Pages.List
{
    public partial class ProductList : ComponentBase
    {
        [Inject]
        protected IProductService ProductService { get; set; }
        
        public ProductList()
        {
        }
      
        IEnumerable<Product> Projects { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Projects = await ProductService.GetProducts();
        }
    }
}
