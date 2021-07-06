using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleWatchList
{
    class Serie
    {
        public string Name { get; set; }

        public IList<Episode> Episodes { get; set; }

        public string Description { get; set; }
    }
}
