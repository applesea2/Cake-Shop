using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace CakeShop.Ui.Models;

public class ContactUsModel
{
    [Required]
    [DisplayName("Name")]
    [BindProperty]
    public string? Name { get; set; }
    
    [Required]
    [DisplayName("Email")]
    [BindProperty]
    public string? Email { get; set; }
    
    [DisplayName("Phone")]
    [Required]
    [BindProperty]
    public string? Phone { get; set; }
    
    [DisplayName("Comments/Questions")]
    [Required]
    [BindProperty]
    public string? Comment { get; set; }
}