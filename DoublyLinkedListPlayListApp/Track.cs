using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListPlayListApp
{
    public class Track
    {
        public string TrackName {  get; set; }

        public Track(string trackName)
        {
            TrackName = trackName;
        }

        public override string ToString()
        {
            return TrackName;
        }
    }
}
