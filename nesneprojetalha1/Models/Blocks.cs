using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesneprojetalha1.Models
{
    public class Blocks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }


        public virtual List<CarPark> CarParks { get; set; }
        public virtual List<Doorman> Doormans { get; set; }
    }
}
