using CakeShop.DAL.Entities;

namespace CakeShop.DAL.Repositories;

public interface IMenuRepository
{
    public List<Item?> GetListOfItems();
    
    public Item? GetItemById(int id);
}