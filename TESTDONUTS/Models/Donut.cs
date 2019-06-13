using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TESTDONUTS.Models
{
    public class Donut
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public string PhotoURL { get; set; }
        public string[] Extras { get; set; }


    }
}