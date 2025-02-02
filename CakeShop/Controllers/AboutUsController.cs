using Microsoft.AspNetCore.Mvc;

namespace CakeShop.Controllers;

public class AboutUsController : Controller
{
    public IActionResult AboutUs()
    {
        return View();
    }
}