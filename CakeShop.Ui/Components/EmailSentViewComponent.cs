using Microsoft.AspNetCore.Mvc;

namespace CakeShop.Ui.Components
{
    public class EmailSentViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
