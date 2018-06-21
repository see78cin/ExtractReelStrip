using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
namespace DocumentFormat.OpenXml.Packaging
{
    class Program
    {

        
        

        static void Main(string[] args)
        {
            // using (WordprocessingDocument paytabledoc= WordprocessingDocument.Open(@"AVV045735_Sup_Sub.docx",false))
            // WordprocessingDocument paytabledoc = WordprocessingDocument.Open(@"E:\Work\WOF 3x4x5x\Matrix\AVV045735_Sup_Sub.docx");

            MainReels Reel = new MainReels();
            Reel.setup(@"C:\Users\Public\main_reelstrips.xml");
           // int[] x = Reel.Getweight1();


            int[] y = Reel.GetHighRange(Reel.Getweight2());

            string[] h = Reel.GetReel1Array();
            // XmlNode reel = Reel1.NodeReel1();
            // XmlNode reel1 = Reel1.NodeReel2();
            // XmlNode reel2 = Reel1.NodeReel3();
            // XmlNode reel3 = Reel1.NodeReel4();
            //  XmlNode reel4 = Reel1.NodeReel5();


             Console.WriteLine();

            // Console.WriteLine(x[21]);
            // Console.WriteLine(Reel.GetReel2());
            // Console.WriteLine(Reel.GetReel3());
            //  Console.WriteLine(Reel.GetReel4());
            // Console.WriteLine(Reel.GetReel5());

            //  Console.WriteLine(Reel.Getweight1());
            // Console.WriteLine(Reel.Getweight2());
            // Console.WriteLine(Reel.Getweight3());
            // Console.WriteLine(Reel.Getweight4());
            // Console.WriteLine(Reel.Getweight5());






















            // foreach (XmlNode child in reel)
            // {

            // Console.WriteLine(child.Attributes["symbolname"].Value);

            // }
            // Console.WriteLine("\r\n");
            //   foreach (XmlNode child in reel1)
            //  {

            //    Console.WriteLine(child.Attributes["symbolname"].Value);

            // }
            // Console.WriteLine("\r\n");
            // foreach (XmlNode child in reel2)
            // {

            //  Console.WriteLine(child.Attributes["symbolname"].Value);

            // }

            // Console.WriteLine("\r\n");
            // foreach (XmlNode child in reel3)
            // {

            //  Console.WriteLine(child.Attributes["symbolname"].Value);

            //  }

            // Console.WriteLine("\r\n");

            // foreach (XmlNode child in reel4)
            //  {

            //    Console.WriteLine(child.Attributes["symbolname"].Value);

            //  }
            //  Console.WriteLine("\r\n");
            //Console.WriteLine(stops);
            Console.Read();
         
        }
    }
}
