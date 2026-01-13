using Microsoft.EntityFrameworkCore;
using StoreApp.Models;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();//burda bir services açtık yani controllar ve views kullanıcaz haberin olsun dedik

builder.Services.AddDbContext<RepositoryContext>(options=>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("sqlconnection"));
});

var app = builder.Build();

app.UseStaticFiles();
app.UseHttpsRedirection();//http gelirse otomatik https yönlerdin
app.UseRouting();//aşağıdaki kodun çalşıması için var

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{id?}");
//burda mapcontrolar Route sayesinde default olarak home ındex calışsın dedik 

app.Run();
 