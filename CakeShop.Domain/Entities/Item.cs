namespace Cakeshop.Domain.Entities;

public class Item
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public decimal? Price { get; set; }
    public string? ImagePath { get; set; }
    public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
}