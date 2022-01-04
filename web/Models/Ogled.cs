using System;
using System.Collections.Generic;

namespace web.Models
{
    public class Ogled
    {
        public int ID { get; set; }
        public int? agentID { get; set; }
        public int? strankaID { get; set; }
        public int? nepremicninaID { get; set; }
        public DateTime? datum{get;set;}
        
    }
}