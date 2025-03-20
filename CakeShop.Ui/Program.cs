using System.ComponentModel.Design;
using CakeShop.DAL.Context;
using CakeShop.DAL.Repositories;
using CakeShop.Service;
using CakeShop.Service.MappingProfiles;
using CakeShop.Ui.MappingProfiles;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer((builder.Configuration.GetConnectionString("MenuDatabase"))));

builder.Services.AddAutoMapper(typeof(AutomapProfile), typeof(UiMappingProfile));

builder.Services.AddScoped<IMenuRepository, MenuRepository>();

builder.Services.AddScoped<IMenuService, MenuService>();

builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));

builder.Services.AddScoped<IContactUs, ContactUs>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();