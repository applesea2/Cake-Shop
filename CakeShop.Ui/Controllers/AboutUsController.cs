using Microsoft.AspNetCore.Mvc;

namespace CakeShop.Ui.Controllers;

public class AboutUsController : Controller
{
    public IActionResult AboutUs()
    {
        return View();
    }
}