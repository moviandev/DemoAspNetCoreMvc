using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DemoMvc.ViewComponents
{
    [ViewComponent(Name = "Shopping")]
    public class ShoppingCartViewComponent : ViewComponent
    {
        public int Products { get; protected set; }

        public ShoppingCartViewComponent()
        {
            Products = 3;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(Products);
        }
    }
}
