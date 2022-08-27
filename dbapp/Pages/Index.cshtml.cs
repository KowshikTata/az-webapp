using dbapp.Models;
using dbapp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dbapp.Pages
{
    public class IndexModel : PageModel
    {

        public List<Product> Products;
        private readonly IProductService _productService;
        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }
        public void OnGet()
        {
            
            Products = productService.GetProducts();

        }
    }
}