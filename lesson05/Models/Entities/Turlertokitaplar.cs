using System;
using System.Collections.Generic;

namespace lesson05.Models.Entities
{
    public partial class Turlertokitaplar
    {
        public int Id { get; set; }
        public int TurId { get; set; }
        public int KitapId { get; set; }
    }
}
