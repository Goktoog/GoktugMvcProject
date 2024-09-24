using GoktugMvcProject.Models;  // Model sınıfların burada olacak
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

var builder = WebApplication.CreateBuilder(args);

// Veritabanı bağlantısı
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Identity ve Razor Pages
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AppDbContext>();
builder.Services.AddRazorPages();  // Razor Pages'ı ekliyoruz

// MVC ve Controller yapılandırması
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IEmailSender, EmailSender>();


var app = builder.Build();

// Hata sayfaları ve HTTPS yönlendirmesi
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();  // Kimlik doğrulama işlemi
app.UseAuthorization();   // Yetkilendirme işlemi

// Varsayılan rota ayarı
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Razor Pages rotalarını ekle
app.MapRazorPages();

app.Run();
