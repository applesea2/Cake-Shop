using AutoMapper;
using Cakeshop.Domain.Entities;
using Cakeshop.DTO;

namespace CakeShop.Service.MappingProfiles;

public class AutomapProfile : Profile
{
    public AutomapProfile()
    {
        CreateMap<Cakeshop.Domain.Entities.Item, Cakeshop.DTO.Item>();
    }
}