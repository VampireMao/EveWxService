using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveWxService
{
    public class Items
    {
        public class Rootobject
        {
            public Sell Sell { get; set; }
            public All All { get; set; }
            public Buy Buy { get; set; }
        }

        public class Sell
        {
            public int Volume { get; set; }
            public decimal Max { get; set; }
            public decimal Min { get; set; }
        }

        public class All
        {
            public int Volume { get; set; }
            public decimal Max { get; set; }
            public decimal Min { get; set; }
        }

        public class Buy
        {
            public int Volume { get; set; }
            public decimal Max { get; set; }
            public decimal Min { get; set; }
        }
    }
}
