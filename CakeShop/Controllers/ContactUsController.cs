using Microsoft.AspNetCore.Mvc;

namespace CakeShop.Controllers;

public class ContactUsController : Controller
{
    public IActionResult ContactUs()
    {
        return View();
    }
}