using Microsoft.EntityFrameworkCore; // Ensure this directive is present to resolve 'UseSqlServer'
using Microsoft.EntityFrameworkCore.SqlServer; // Add this directive to ensure the extension method is available

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DataDbContext>(options =>
 options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // Ensure the 'Microsoft.EntityFrameworkCore.SqlServer' package is installed

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

//app.MapStaticAssets();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}")
//    .WithStaticAssets();

app.Run();
