using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleWatchList
{
    class Episode 
    {
        public string Name { get; set; }

        public int Season { get; set; }

        public int EpisodeNum { get; set; }
        public Serie Serie { get; set; }

        public string Url { get; set; }
    }
}
