using System;
using System.Collections.Generic;

namespace dbconn.Models.Entities
{
    public partial class Ogrenci
    {
        public int Id { get; set; }
        public string Adi { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int SinifId { get; set; }
        public int Cinsiyet { get; set; }
        public DateOnly Dtarihi { get; set; }
    }
}
