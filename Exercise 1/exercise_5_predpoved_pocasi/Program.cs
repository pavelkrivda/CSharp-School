using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Xml;

namespace exercis_1_5_predpoved_pocasi
{
    class Program
    {
        public static void Main(string[] args)
        {
            WebClient client = new WebClient();
            XmlDocument xmlDocument = new XmlDocument();

            string result =
                client.DownloadString("https://api.met.no/weatherapi/locationforecast/1.9/?lat=60.10&lon=9.58");


//            double lat = 60.10, lon = 9.58;
//            string result =
//                client.DownloadString($"https://api.met.no/weatherapi/locationforecast/1.9/?lat={lat}&lon={lon}");

            xmlDocument.LoadXml(result);

//            Console.WriteLine("Po nodech");
            // Po nodech dle nazvu
//            List<string> teploty = parserXML(xmlDocument, "temperature", "value");
//            List<string> rychlostVetru = parserXML(xmlDocument, "windSpeed", "mps");
//            List<string> tlak = parserXML(xmlDocument, "pressure", "value");
//            List<string> cas = new List<string>();
//
//            for (int i = 0; i < tlak.Count; i++)
//            {
//                Console.WriteLine($"{teploty[i]}°C\t {rychlostVetru[i]}m/s\t {tlak[i]}hPa");
//            }

            // Rekurzivně 
            List<string> teploty = new List<string>();
            List<string> rychlostVetru = new List<string>();
            List<string> tlak = new List<string>();
            List<string> cas = new List<string>();
            Console.WriteLine("Rekurzivně");
            XmlNode hlavniNod = xmlDocument.DocumentElement;
            ProjdiNody(teploty, rychlostVetru, tlak, cas, hlavniNod);

            for (int i = 0; i < tlak.Count; i++)
            {
                Console.WriteLine($"{cas[i]}\t {teploty[i]}°C\t {rychlostVetru[i]}m/s\t {tlak[i]}hPa");
            }
        }

        private static void ProjdiNody(List<string> teploty, List<string> rychlostVetru, List<string> tlak,
            List<string> cas, XmlNode hlavniNod)
        {
            foreach (XmlNode podNod in hlavniNod.ChildNodes)
            {
                XmlAttributeCollection atributes = podNod.Attributes;

                if (hlavniNod.Name.Equals("product"))
                {
                    if (podNod.Name.Equals("time"))
                    {
                        if (cas.Count == 0)
                        {
                            cas.Add(podNod.Attributes["to"].Value);
                        }
                        else if (!cas.Contains(podNod.Attributes["to"].Value))
                        {
                            cas.Add(podNod.Attributes["to"].Value);
                        }
                    }
                }

                if (hlavniNod.Name.Equals("location"))
                {
                    if (podNod.Name.Equals("temperature"))
                    {
                        teploty.Add(podNod.Attributes["value"].Value);
                    }
                    else if (podNod.Name.Equals("windSpeed"))
                    {
                        rychlostVetru.Add(podNod.Attributes["mps"].Value);
                    }
                    else if (podNod.Name.Equals("pressure"))
                    {
                        tlak.Add(podNod.Attributes["value"].Value);
                    }
                }

                ProjdiNody(teploty, rychlostVetru, tlak, cas, podNod);
            }
        }

//        private static List<string> parserXML(XmlDocument xmlDocument, string nameXmlNode, string nameAtribute)
//        {
//            XmlNodeList nodes =
//                xmlDocument.DocumentElement.SelectNodes("/weatherdata/product/time/location/" + nameXmlNode);
//            List<string> values = new List<string>();
//            Console.WriteLine("nodes: " + nodes.Count);
//            foreach (XmlNode node in nodes)
//            {
//                values.Add(node.Attributes[nameAtribute].Value);
//            }
//
//            return values;
//        }
    }
}