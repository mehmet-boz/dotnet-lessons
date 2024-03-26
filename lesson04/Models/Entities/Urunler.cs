using System;
using System.Collections.Generic;

namespace lesson04.Models.Entities
{
    public partial class Urunler
    {
        public int Id { get; set; }
        public string Foto { get; set; } = null!;
        public string Baslik { get; set; } = null!;
        public string UstBaslik { get; set; } = null!;
        public string Icerik { get; set; } = null!;
        public sbyte Aktif { get; set; }
        public int Sira { get; set; }
    }
}
