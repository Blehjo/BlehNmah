using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesBlehNmah.DAL;
//using RazorPagesBlehNmah.Data;
//using RazorPagesBlehNmah.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
//builder.Services.AddDbContext<RazorPagesCollectionContext>(options =>
//    options.UseSqlite(builder.Configuration.GetConnectionString("RazorPagesCollectionContext") ?? throw new InvalidOperationException("Connection string 'RazorPagesCollectionContext' not found.")));
//builder.Services.AddDbContext<Gallery>(options =>
//    options.UseSqlite(builder.Configuration.GetConnectionString("Gallery") ?? throw new InvalidOperationException("Connection string 'Gallery' not found.")));
//builder.Services.AddDbContext<RazorPagesCollectionContext>(options =>
//    options.UseSqlite(builder.Configuration.GetConnectionString("RazorPagesCollectionContext") ?? throw new InvalidOperationException("Connection string 'RazorPagesCollectionContext' not found.")));

var app = builder.Build();

//using (var scope = app.Services.CreateScope())
//{
//    var services = scope.ServiceProvider;
//}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

