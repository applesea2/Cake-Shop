using CakeShop.Service;
using CakeShop.Ui.Models;
using Microsoft.AspNetCore.Mvc;

namespace CakeShop.Ui.Controllers;

public class ContactUsController : Controller
{
    private readonly IContactUs _contactUs;

    public IActionResult ContactUs()
    {
        return View();
    }
    public ContactUsController(IContactUs contactUs)
    {
        _contactUs = contactUs;
    }

    [HttpPost]
    public async Task<IActionResult> OnSubmit(ContactUsModel model)
    {
        if (ModelState.IsValid)
        {
            await _contactUs.SendEmailAsync(model.Name, model.Email, model.Phone, model.Comment);
            ViewData["EmailSent"] = true;      
        }
        return View("ContactUs", model);
    }
}