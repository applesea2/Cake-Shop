using AutoMapper;
using Cakeshop.DTO;
using CakeShop.Ui.Models;

namespace CakeShop.Ui;

public class MenuViewModelMap : Profile
{
    public MenuViewModelMap()
    {
        CreateMap<Item, MenuModel>();
    }
}