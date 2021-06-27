using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleWatchList
{
    interface IEpisode 
    {
        public string Name { get; set; }

        public int Season { get; set; }

        public int Episode { get; set; }

        public ISerie Serie { get; set; }

        public string Url { get; set; }
    }
}
