using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using sorveteria_rai.Data;
using sorveteria_rai.Services;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SorveteriaContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("SorveteriaContext") ?? throw new InvalidOperationException("Connection string 'SorveteriaContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<CategoriaService>();

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
