using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ExperienceSync.Data;
using ExperienceSync.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionStrings = builder.Configuration.GetConnectionString("ExperienceSyncContextConnection") ?? throw new InvalidOperationException("Connection string 'ExperienceSyncContextConnection' not found.");

#region ConnectionService

var connectionString = builder.Configuration.GetConnectionString("ExperienceSyncContextConnection");

builder.Services.AddDbContext<ExperienceSyncContext>(options =>
        options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 21))
    ));

builder.Services.AddDefaultIdentity<ExperienceSyncUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ExperienceSyncContext>();
#endregion

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

#region Identity
app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();
#endregion

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
