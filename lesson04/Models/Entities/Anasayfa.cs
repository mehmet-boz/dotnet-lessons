using System;
using System.Collections.Generic;

namespace lesson04.Models.Entities
{
    public partial class Anasayfa
    {
        public int Id { get; set; }
        public string Foto { get; set; } = null!;
        public string UstBaslik { get; set; } = null!;
        public string UstIcerik { get; set; } = null!;
        public string Link { get; set; } = null!;
        public string AltBaslik { get; set; } = null!;
        public string AltIcerik { get; set; } = null!;
    }
}
