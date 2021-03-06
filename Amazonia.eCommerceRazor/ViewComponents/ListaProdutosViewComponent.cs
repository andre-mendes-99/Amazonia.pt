using Amazonia.eCommerceRazor.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Amazonia.eCommerceRazor.ViewComponents
{
    public class ListaProdutosViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(List<Product> produtos)
        {
            return Task.FromResult<IViewComponentResult>(View("ListaProdutosDataGrid", produtos));
        }
    }
}
