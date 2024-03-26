using System;
using System.Collections.Generic;

namespace lesson04.Models.Entities
{
    public partial class Magazasaat
    {
        public int Id { get; set; }
        public string Gun { get; set; } = null!;
        public string Saat { get; set; } = null!;
    }
}
