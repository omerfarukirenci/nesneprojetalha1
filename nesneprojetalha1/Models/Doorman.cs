using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesneprojetalha1.Models
{
    public class Doorman
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        public string Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }


        public virtual Blocks Blocks { get; set; }
    }
}
