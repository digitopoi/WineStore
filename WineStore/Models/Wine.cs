using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WineStore.Models
{
    public class Wine
    {
        public int ProductID { get; set; }
        public string Winery { get; set; }
        public DateTime Year { get; set; }
        public string Region { get; set; }
        public string Grape { get; set; }
        public string Color { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
    }
}