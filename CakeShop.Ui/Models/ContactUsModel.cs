using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace CakeShop.Ui.Models;

public class ContactUsModel
{
    [Required(ErrorMessage = "Name is required")]
    [DisplayName("Name")]
    [BindProperty]
    public string? Name { get; set; }
    
    [Required(ErrorMessage = "Email address is required")]
    [EmailAddress(ErrorMessage = "Please enter a valid email")]
    [DisplayName("Email")]
    [BindProperty]
    public string? Email { get; set; }
    
    [DisplayName("Phone")]
    [Required(ErrorMessage = "Phone number is required")]
    [Phone(ErrorMessage = "Please enter a valid phone number")]
    [BindProperty]
    public string? Phone { get; set; }
    
    [DisplayName("Comments/Questions")]
    [Required(ErrorMessage = "Please enter a valid comment/question")]
    [BindProperty]
    public string? Comment { get; set; }
}