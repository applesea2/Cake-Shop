using Cakeshop.Domain.Entities;

namespace CakeShop.Persistance.Repositories;

public interface IMenuRepository
{
    public List<Item?> GetListOfItems();
    
    public Item? GetItemById(int id);
}