using CakeShop.Ui.Models;
using Microsoft.AspNetCore.Mvc;

namespace CakeShop.Ui.Controllers;

public class OrdersController : Controller
{
    
    public OrdersController()
    {
        
    }

    public IActionResult Orders()
    {
        return View();
    }
}