using AutoMapper;
using Cakeshop.DTO;
using CakeShop.Ui.Models;

namespace CakeShop.Ui.MappingProfiles;

public class UiMappingProfile : Profile
{
    public UiMappingProfile()
    {
        CreateMap<MenuItemDTO, MenuModel>();
    }
}