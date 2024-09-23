using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;  // Identity için gerekli
namespace GoktugMvcProject.Models
{
    public class AppDbContext : DbContext //Buraya Dbcontext sınıfından miras alıyorum.
        //inherit etmek OOP olarak geçer 
        //encapsulation
        //interface
        //abstract class
        //entity framework, ORM
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }


        //DbSet<Kullanici> Kullanicilar: Veritabanında Kullanicilar adlı bir tabloyu temsil eder. Kendi model sınıflarına göre bunu değiştirebilirsin.
        // Veritabanı tabloları için DbSet'ler oluştur
        // Burada DbSet'lerinizi tanımlayın
        // Örneğin:
        // public DbSet<Product> Products { get; set; }

    }
}
