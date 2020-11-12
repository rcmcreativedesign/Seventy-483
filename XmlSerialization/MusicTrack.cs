using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XmlSerialization.Models
{
    public class MusicTrack
    {
        public MusicTrack() { }

        public int ID { get; set; }
        public Artist Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
    }
}
