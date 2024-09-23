using System.ComponentModel.DataAnnotations;

namespace GoktugMvcProject.Models
{
    public class Kullanici
    {
        
        public int Id { get; set; } //Birincil anahtar(ID) burayı belirtmezsen migration işkemi başarısız oluyor.

        [StringLength(50)] // nvarchar(50)
        public string Ad { get; set; }

        [StringLength(50)] // nvarchar(50)
        public string Soyad { get; set; }

        [StringLength(100)] // nvarchar(100)
        public string Email { get; set; }
    }
}