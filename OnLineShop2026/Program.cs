using Microsoft.EntityFrameworkCore;
using OnlineShopp.DB;
using OnLineShop2026.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// получить строку обращения к БД
string connection = builder.Configuration.GetConnectionString("DBonlineShop");

// подлючить контекст
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(connection));


// создать репозиторий
builder.Services.AddTransient<IProductsDBRepository, ProductsDBRepository>();

//builder.Services.AddSingleton<IProductRepository, ProductRepositoryInMemory>();
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
