using AutoMapper;
using CakeShop.DAL.Repositories;
using Cakeshop.DTO;

namespace CakeShop.Service;

public class MenuService : IMenuService
{
    private readonly IMenuRepository _menuRepository;
    private readonly IMapper _mapper;

    public MenuService(IMenuRepository menuRepository, IMapper mapper)
    {
        _menuRepository = menuRepository;
        _mapper = mapper;
    }

    public List<MenuItemDTO?> GetMenuItems()
    {
        var items = _menuRepository.GetListOfItems().ToList();
        return _mapper.Map<List<MenuItemDTO?>>(items);
    }

    public MenuItemDTO? GetMenuItemById(int id)
    {
        var item = _menuRepository.GetItemById(id);
        return _mapper.Map<MenuItemDTO?>(item);
    }
}