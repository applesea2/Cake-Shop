namespace CakeShop.Service;

public interface IContactUs
{
    public Task SendEmailAsync(string? name, string? email, string? phone, string? comment);
}