using Cakeshop.Domain.Entities;
using CakeShop.Persistance.Context;

namespace CakeShop.Persistance.Repositories;

public class MenuRepository : IMenuRepository
{
    private readonly ApplicationContext _db;

    public MenuRepository(ApplicationContext db)
    {
        _db = db;
    }
    public List<Item?> GetListOfItems()
    {
        return _db.Items.ToList();
    }

    public Item? GetItemById(int id)
    {
        return _db.Items.Find(id);
    }
}