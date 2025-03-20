using AutoMapper;
using CakeShop.DAL.Entities;
using Cakeshop.DTO;

namespace CakeShop.Service.MappingProfiles;

public class AutomapProfile : Profile
{
    public AutomapProfile()
    {
        CreateMap<Item, MenuItemDTO>();
    }
}