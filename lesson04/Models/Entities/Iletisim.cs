using System;
using System.Collections.Generic;

namespace lesson04.Models.Entities
{
    public partial class Iletisim
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Mesaj { get; set; } = null!;
        public DateTime? Tarih { get; set; }
    }
}
