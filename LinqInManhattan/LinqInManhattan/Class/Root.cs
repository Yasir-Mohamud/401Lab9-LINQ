using System;
using System.Collections.Generic;
using System.Text;

namespace LinqInManhattan.Class
{
   public class Root
    {
        public string type { get; set; }
        public IEnumerable<Feature> features { get; set; }
    }
}
