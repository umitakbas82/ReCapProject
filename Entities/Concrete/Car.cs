using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car
    {

        public int CarID { get; set; }
        public int BrandID { get; set; }
        public int ColourID { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

    }
}
