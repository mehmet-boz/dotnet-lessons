using System;
using System.Collections.Generic;

namespace lesson04.Models.Entities
{
    public partial class Magaza
    {
        public int Id { get; set; }
        public string UstBaslik { get; set; } = null!;
        public string AnaBaslik { get; set; } = null!;
        public string Adres { get; set; } = null!;
        public string Telefon { get; set; } = null!;
    }
}
