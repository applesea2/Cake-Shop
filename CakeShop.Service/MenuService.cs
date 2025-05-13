using AutoMapper;
using Cakeshop.DTO;
using CakeShop.Persistance.Repositories;

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

    public List<Item?> GetMenuItems()
    {
        var items = _menuRepository.GetListOfItems().ToList();
        return _mapper.Map<List<Item?>>(items);
    }

    public Item? GetMenuItemById(int id)
    {
        var item = _menuRepository.GetItemById(id);
        return _mapper.Map<Item?>(item);
    }
}