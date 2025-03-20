using CakeShop.DAL.Context;
using CakeShop.DAL.Entities;

namespace CakeShop.DAL.Repositories;

public class MenuRepository : IMenuRepository
{
    private readonly MyDbContext _db;

    public MenuRepository(MyDbContext db)
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