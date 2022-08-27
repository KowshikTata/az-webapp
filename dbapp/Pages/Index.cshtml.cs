using dbapp.Models;
using dbapp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dbapp.Pages
{
    public class IndexModel : PageModel
    {

        public List<Product> Products;
        public void OnGet()
        {
            ProductService productService = new ProductService();
            Products = productService.GetProducts();

        }
    }
}