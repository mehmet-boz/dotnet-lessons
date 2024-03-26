using System;
using System.Collections.Generic;

namespace dbconn.Models.Entities
{
    public partial class Table1
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string Telefon { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Sehir { get; set; } = null!;
    }
}
