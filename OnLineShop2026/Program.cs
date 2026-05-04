using OnLineShop2026.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IUserRepository, UserRepositoryInMemory>();
builder.Services.AddSingleton<IProductRepository, ProductRepositoryInMemory>();
builder.Services.AddSingleton<ICartRepository, CartRepositoryInMemory>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Catalog}/{id?}");

app.Run();
