using CakeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CakeShop.Controllers;

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