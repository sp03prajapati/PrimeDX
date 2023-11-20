using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DostarGarage.Models
{
    public class BrandNameMode
    {
        public int id { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
    }

    public class CarPart
    {
        public int id { get; set; }
        public string Name { get; set; }
    }
}