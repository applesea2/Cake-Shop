using AutoMapper;
using CakeShop.Service;
using CakeShop.Ui.Models;
using Microsoft.AspNetCore.Mvc;

namespace CakeShop.Ui.Controllers;

public class MenuController : Controller
{
    private readonly IMenuService _menuService;
    private readonly IMapper _mapper;

    public MenuController(IMenuService menuService, IMapper mapper)
    {
        _menuService = menuService;
        _mapper = mapper;
    }

    public IActionResult Menu()
    {
        var menuDto = _menuService.GetMenuItems();
        var viewModel = _mapper.Map<List<MenuModel>>(menuDto);
        return View(viewModel);
    }
}