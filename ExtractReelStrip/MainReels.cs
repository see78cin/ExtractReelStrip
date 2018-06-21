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
    public class MainReels
    {
        XmlNodeList list;
        XmlElement element;
        XmlDocument paytable;
        int reelcount = 0;
        int reel_length = 0;
       

        public void setup(string filename)
        {
         paytable = new XmlDocument();
         paytable.Load(filename);
         element = paytable.DocumentElement;
         list = element.GetElementsByTagName("reelstripdef");
         reelcount = list.Count;
         reel_length = list[2].ChildNodes.Count; //used for physical reel
           // Console.Write(reel_length);

        }
        public int GetReel1Length()
        {

            return list[0].ChildNodes.Count;

        }

        public int GetReel2Length()
        {

            return list[1].ChildNodes.Count;

        }


        public int GetReel3Length()
        {

            return list[2].ChildNodes.Count;

        }



        public int GetReel4Length()
        {

            return list[3].ChildNodes.Count;

        }


        public int GetReel5Length()
        {

            return list[4].ChildNodes.Count;

        }






        public XmlNode NodeReel1()
        {
            return list[0];
        }

        public XmlNode NodeReel2()
        {
            return list[1];
        }

        public XmlNode NodeReel3()
        {
            return list[2];
        }
        public XmlNode NodeReel4()
        {
            return list[3];
        }
        public XmlNode NodeReel5()
        {
            return list[4];
        }

        //returns symbols from reel one

        public string[] GetReel1Array()
        {

            string[] reel = new string[GetReel1Length()];
            int count = 0;
            XmlNode NodeReel = this.NodeReel1();
            foreach (XmlNode child in NodeReel)
            {
                reel[count++] = child.Attributes["symbolname"].Value;
              

            }
            return reel;


        }
          public string GetReel1()
         {
            string tmpReel="";
            XmlNode NodeReel1 = this.NodeReel1();
           foreach (XmlNode child in NodeReel1)
          {

             tmpReel+=child.Attributes["symbolname"].Value + " ";

          }
          return tmpReel;
          }

        public string[] GetReel2Array()
        {

            string[] reel = new string[GetReel2Length()];
            int count = 0;
            XmlNode NodeReel = this.NodeReel2();
            foreach (XmlNode child in NodeReel)
            {
                reel[count++] = child.Attributes["symbolname"].Value;


            }
            return reel;
        }

         public string GetReel2()
         {
          string tmpReel = "";
          XmlNode NodeReel2 = this.NodeReel2();
          foreach (XmlNode child in NodeReel2)
          {

           tmpReel += child.Attributes["symbolname"].Value + " ";
        
         }
          return tmpReel;
          }
        



        public string[] GetReel3Array()
        {

            string[] reel = new string[GetReel3Length()];
            int count = 0;
            XmlNode NodeReel = this.NodeReel3();
            foreach (XmlNode child in NodeReel)
            {
                reel[count++] = child.Attributes["symbolname"].Value;


            }
            return reel;
        }


        public string GetReel3()
        {
            string tmpReel = "";
            XmlNode NodeReel3 = this.NodeReel3();
          foreach (XmlNode child in NodeReel3)
          {

                tmpReel += child.Attributes["symbolname"].Value + " ";

            }
            return tmpReel;
        }



        public string[] GetReel4Array()
        {

            string[] reel = new string[GetReel4Length()];
            int count = 0;
            XmlNode NodeReel = this.NodeReel4();
            foreach (XmlNode child in NodeReel)
            {
                reel[count++] = child.Attributes["symbolname"].Value;


            }
            return reel;
        }

         public string GetReel4()
         {
            string tmpReel = "";
            XmlNode NodeReel4 = this.NodeReel4();
         foreach (XmlNode child in NodeReel4)
           {

             tmpReel += child.Attributes["symbolname"].Value + " ";

           }
           return tmpReel;
         }





        public string[] GetReel5Array()
        {

            string[] reel = new string[GetReel5Length()];
            int count = 0;
            XmlNode NodeReel = this.NodeReel5();
            foreach (XmlNode child in NodeReel)
            {
                reel[count++] = child.Attributes["symbolname"].Value;


            }
            return reel;
        }

        public string GetReel5()
        {
           string tmpReel = "";
           XmlNode NodeReel5 = this.NodeReel5();
            foreach (XmlNode child in NodeReel5)
            {

                tmpReel += child.Attributes["symbolname"].Value+" ";

            }
            return tmpReel;
        }


        public int[] GetHighRange(int[]tmpArray)// gets upper ranger

        {
            int tmp = 0;
            int[] weightArray=tmpArray;
            for(int x = 0; x < weightArray.Length; x++)
            {
                tmp = tmp + weightArray[x];
                weightArray[x] = tmp - 1;


            }

            return weightArray;
                
                
        }

        public int[] GetLowRange(int[] tmpArray, int[] tmpweight) //gets lower range

        {

            int[] weightArray = new int[tmpArray.Length];
            for (int x = tmpArray.Length - 1; x > 0; x--)
            {
                weightArray[x] = (tmpArray[x] - tmpweight[x]) + 1;

            }

            return weightArray;


        }
        //   public int[]GetLowRange(int[] tmpArray)

        // {
        //   int tmp = 0;
        //  int[] weightArray = tmpArray;
        //  for (int x = 0; x < weightArray.Length; x++)
        //  {
        //    tmp = tmp + weightArray[x];
        //    weightArray[x] = tmp - 1;

        //
        // }

        // return weightArray;


        // }

        /////get weights
        public int[] Getweight1()
        {
          
            int count = 0;
            XmlNode NodeReel1 = this.NodeReel1();
            int[] range = new int[list[0].ChildNodes.Count];
            foreach (XmlNode child in NodeReel1)
            {

                range[count++] = Convert.ToInt16(child.Attributes["weight"].Value);
                

            }
            return range;
        }

        public int[] Getweight2()
        {
            int count = 0;
           
            XmlNode NodeReel2 = this.NodeReel2();
            int[] range = new int[list[1].ChildNodes.Count];
            foreach (XmlNode child in NodeReel2)
            {

                range[count++] = Convert.ToInt16(child.Attributes["weight"].Value);


            }
            return range;
        }

        public int[] Getweight3()
        {
            int count = 0;

            XmlNode NodeReel3 = this.NodeReel3();
            int[] range = new int[list[2].ChildNodes.Count];
            foreach (XmlNode child in NodeReel3)
            {

                range[count++] = Convert.ToInt16(child.Attributes["weight"].Value);


            }
            return range;
        }
        public int[] Getweight4()
        {
            int count = 0;

            XmlNode NodeReel4 = this.NodeReel4();
            int[] range = new int[list[3].ChildNodes.Count];
            foreach (XmlNode child in NodeReel4)
            {

                range[count++] = Convert.ToInt16(child.Attributes["weight"].Value);


            }
            return range;
        }
        public int[] Getweight5()
        {
            int count = 0;

            XmlNode NodeReel5 = this.NodeReel5();
            int[] range = new int[list[4].ChildNodes.Count];
            foreach (XmlNode child in NodeReel5)
            {

                range[count++] = Convert.ToInt16(child.Attributes["weight"].Value);


            }
            return range;
        }

        ////get low range

       // public int[] Getweightlow1()
       // {
       //
         //   int count = 0;
         //   XmlNode NodeReel1 = this.NodeReel1();
          //  int[] range = new int[list[0].ChildNodes.Count];
          //  foreach (XmlNode child in NodeReel1)
          //  {
            //    count++;
            //    range[0]= 0;
               
            //    if (count!=0)

              //  range[count-1] = Convert.ToInt16(child.Attributes["weight"].Value)-1;
            //

           // }
           // return range;
      //  }
       
      //  public int[] GetHighLow1(int[] tmpArray)

       // {
         //   int tmp = 0;
         //   int[] weightArray = tmpArray;
          //  for (int x = 0; x < weightArray.Length; x++)
           // {
           //     tmp = tmp - weightArray[x];
            //    weightArray[x] = tmp - 1;


           // }

          //  return weightArray;


       // }
    }

    public class Reelstop
    {
       private string symbol;
        private string range;
       

        public Reelstop(string tmpsymbol,int tmphigh,int tmplow)
        {

          this.symbol=  tmpsymbol;
            this.range = "" + Convert.ToString(tmplow) + "  -  " + Convert.ToString(tmphigh);
           
        }

        public string Symbols
        {
            get
            {
                return symbol;
            }
        }


        public string Range
        {
            get
            {
                return range;
            }
        }


    }




}







