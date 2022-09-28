using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace gui_demo
{
    class HelperMethods
    {
        
        public static void serializetoXML()
        {
            Int156 int156 = new Int156();

            XmlSerializer serialize = new XmlSerializer(typeof(Int156));
            TextWriter writer = new StreamWriter(@"Int156.xml");
            serialize.Serialize(writer, int156);
        }
    }

    public enum Format
    {
        ASCII,
        Unknown
    };

    public class Int156
    {
        public S_PackageInduction s_PackageInduction { get; set; }
        public S_PackageProperties s_PackageProperties { get; set; }

        public Int156()
        {
            s_PackageInduction = new S_PackageInduction(10, "NGB", 11, Format.ASCII);
            s_PackageProperties = new S_PackageProperties(10, "NGB", 11, Format.Unknown);
        }

    }

    public class S_PackageProperties
    {
        public int Id { get; set; }
        public string BarcodeType { get; set; }
        public double PackageHeight { get; set; }
        public Format BarcodeFormat { get; set; }

        public S_PackageProperties()
        {
        }

        public S_PackageProperties(int id, string barcodeType, double height, Format format)
        {
            Id = id;
            BarcodeType = barcodeType;
            PackageHeight = height;
            BarcodeFormat = format;
        }

    }


    public class S_PackageInduction
    {
        public int Id { get; set; }
        public string InductionType { get; set; }
        public double PackageHeight { get; set; }
        public Format BarcodeFormat { get; set; }

        public S_PackageInduction()
        {
        }

        public S_PackageInduction(int id, string inductionType, double height, Format format)
        {
            Id = id;
            InductionType = inductionType;
            PackageHeight = height;
            BarcodeFormat = format;
        }

    }
}
