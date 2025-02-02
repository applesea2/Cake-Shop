using Microsoft.AspNetCore.Mvc;

namespace CakeShop.Controllers;

public class MenuController : Controller
{
    public IActionResult Menu()
    {
        return View();
    }
}