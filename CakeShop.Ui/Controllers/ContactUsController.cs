using Microsoft.AspNetCore.Mvc;

namespace CakeShop.Ui.Controllers;

public class ContactUsController : Controller
{
    public IActionResult ContactUs()
    {
        return View();
    }
}