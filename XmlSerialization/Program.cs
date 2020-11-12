using System;
using System.IO;
using System.Xml.Serialization;
using XmlSerialization.Models;

namespace XmlSerialization
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var xmlSerializer = new XmlSerializer(typeof(MusicTrack));

            var musicTrack = new MusicTrack() { ID = 1, Artist = new Artist() { Name = "Guns & Roses", Label = "Metal Records" }, Title = "Sweet Child of Mine", Length = 120 };

            using StreamWriter stream = new StreamWriter("C:\\Temp\\XmlSerializationTest.xml", false);
            xmlSerializer.Serialize(stream, musicTrack);

        }
    }
}
