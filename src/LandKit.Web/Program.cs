using LandKit.Core.Entities;
using LandKit.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

//———————————— إنشاء التطبيق ————————————
var builder = WebApplication.CreateBuilder(args);

//———————————— قاعدة البيانات ————————————
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<LandKitDbContext>(options =>
    options.UseNpgsql(connectionString));

//———————————— ASP.NET Core Identity ————————————
builder.Services.AddIdentity<User, IdentityRole<Guid>>()
    .AddEntityFrameworkStores<LandKitDbContext>()
    .AddDefaultTokenProviders();

//———————————— Blazor ————————————
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//———————————— بناء التطبيق ————————————
var app = builder.Build();

//———————————— HTTP Pipeline ————————————
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAntiforgery();

//———————————— Blazor Endpoints ————————————
app.MapRazorComponents<LandKit.Web.Components.App>()
    .AddInteractiveServerRenderMode();

app.Run();
