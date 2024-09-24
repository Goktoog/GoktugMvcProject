using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoktugMvcProject.Models
{
    public class Car
    {
        
        public int Id { get; set; } //Birincil anahtar(ID) burayı belirtmezsen migration işkemi başarısız oluyor.

        [StringLength(50)] // nvarchar(50)
        public string Marka { get; set; }

        [StringLength(50)] // nvarchar(50)
        public string Model { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal Fiyat { get; set; }
    }
}