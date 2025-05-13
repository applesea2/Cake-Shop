using Cakeshop.DTO;

namespace CakeShop.Service;

public interface IMenuService
{
    List<Item?> GetMenuItems();
    Item? GetMenuItemById(int id);
}