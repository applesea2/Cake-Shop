namespace Cakeshop.DTO;

public class Item
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public decimal? Price { get; set; }
    public string? ImagePath { get; set; }
    public List<Ingredient> Ingredients { get; set; }
}