using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SoccerPlayers.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SoccerPlayersContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("SoccerPlayersContext") ?? throw new InvalidOperationException("Connection string 'SoccerPlayersContext' not found.")));


builder.Services.AddControllersWithViews();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=SoccerPlayers}/{action=Index}/{id?}");

app.Run();
