using System;
using System.Collections.Generic;

namespace web.Models
{
    public class Oglas
    {
        public int ID { get; set; }
        public int? NepremicninaID { get; set; }
        public float? cena { get; set; }
        public DateTime? datum{get;set;}

    }
}