using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.WebHost.UseUrls("http://0.0.0.0:5005");

// Xem xét đặt Startup.Startup  ở đây
// đọc config
var testoptions = builder.Configuration.GetSection("TestOptions");

// Thêm vào dòng lấy IServiceCollection
var services = builder.Services;
/* ============================================================
 * 
     Copy code cũ trong Startup.ConfigureServices vào đây, ví dụ

   =========================================================== */

void ConfigureServices(IServiceCollection services)
{
    services.AddControllersWithViews();
}


services.AddDistributedMemoryCache();
services.AddSession(cfg => {
    cfg.Cookie.Name = "xuanthulab";
    cfg.IdleTimeout = new TimeSpan(0, 30, 0);
});


var app = builder.Build();
/* ============================================================
 * 
    Code viết trong Configure cũ đặt tại đay, ví dụ:

   =========================================================== */


// Configure the HTTP request pipeline.
void Confiure(IApplicationBuilder app, IWebHostEnvironment env) {
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }
    else app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
