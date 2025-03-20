using Cakeshop.DTO;

namespace CakeShop.Service;

public interface IMenuService
{
    List<MenuItemDTO?> GetMenuItems();
    MenuItemDTO? GetMenuItemById(int id);
}