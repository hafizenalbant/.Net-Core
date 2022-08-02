using System.ComponentModel.DataAnnotations;

namespace HafizeNalbant_CodelabProjesi.Models
{
    public class Kişiler
    {
        [Key]
        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Bölüm { get; set; }
        public int Yaş { get; set; }
    }
}
