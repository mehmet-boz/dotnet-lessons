using System;
using System.Collections.Generic;

namespace lesson04.Models.Entities
{
    public partial class Kullanicilar
    {
        public int Id { get; set; }
        public string Kadi { get; set; } = null!;
        public string Parola { get; set; } = null!;
    }
}
