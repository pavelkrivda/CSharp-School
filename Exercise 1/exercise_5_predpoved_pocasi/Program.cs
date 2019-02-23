using exercis_5_predpoved_pocasi;
using exercise_5_predpoved_pocasi.Yandex;
using System;
using System.Collections.Generic;
using System.Net;
using System.Xml;

namespace exercis_1_5_predpoved_pocasi
{
    // Ke geolokaci bylo využito řešení z https://github.com/Verhov/YandexGeocoder

    class Program
    {
        private static List<string> teploty = new List<string>();
        private static List<string> rychlostVetru = new List<string>();
        private static List<string> tlak = new List<string>();
        private static List<string> cas = new List<string>();

        public static void Main(string[] args)
        {
            WebClient client = new WebClient();
            XmlDocument xmlDocument = new XmlDocument();

            //string result =
            //    client.DownloadString("https://api.met.no/weatherapi/locationforecast/1.9/?lat=60.10&lon=9.58");

            string location = nactiLokaci();
            string lat, lon;
            zjistiPolohu(location, out lat, out lon);

            string result = client.DownloadString(
                    string.Format("https://api.met.no/weatherapi/locationforecast/1.9/?lat={0}&lon={1}", lat, lon));

            xmlDocument.LoadXml(result);
            xmlParsovaniRekurzivne(xmlDocument);
            //xmlParsovaniJmenoNode(xmlDocument);
        }

        private static string nactiLokaci()
        {
            Console.Write("Zadej místo pro které se zobrazí informace o počasí: ");
            string location = Console.ReadLine();
            return location;
        }

        private static void zjistiPolohu(string location, out string lat, out string lon)
        {
            GeoObjectCollection results = YandexGeocoder.Geocode(location);
            lat = results[0].Point.Lat.ToString().Replace(',', '.');
            lon = results[0].Point.Long.ToString().Replace(',', '.');
            Console.WriteLine($"Souřadnice zadaného místa.\nZeměpisná šířka: {lat}  zeměpisná délka: {lon}");
        }

        private static void xmlParsovaniRekurzivne(XmlDocument xmlDocument)
        {
            Console.WriteLine("Rekurzivně");
            XmlNode hlavniNod = xmlDocument.DocumentElement;
            ProjdiNody(hlavniNod);
            vypisVysledku();
        }

        private static void ProjdiNody(XmlNode hlavniNod)
        {
            foreach (XmlNode podNod in hlavniNod.ChildNodes)
            {
                if (hlavniNod.Name.Equals("product"))
                {
                    if (cas.Count == 0 || !cas.Contains(podNod.Attributes["to"].Value))
                    {
                        cas.Add(podNod.Attributes["to"].Value);
                    }
                }
                else if (hlavniNod.Name.Equals("location"))
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

                ProjdiNody(podNod);
            }
        }

        private static void vypisVysledku()
        {
            for (int i = 0; i < tlak.Count; i++)
            {
                Console.WriteLine($"{cas[i]}\t {teploty[i]}°C\t {rychlostVetru[i]}m/s\t {tlak[i]}hPa");
            }
        }

        private static void xmlParsovaniJmenoNode(XmlDocument xmlDocument)
        {
            Console.WriteLine("Po nodech");
            List<string> teploty = parserXML(xmlDocument, "temperature", "value");
            List<string> rychlostVetru = parserXML(xmlDocument, "windSpeed", "mps");
            List<string> tlak = parserXML(xmlDocument, "pressure", "value");
            List<string> cas = new List<string>();

            for (int i = 0; i < tlak.Count; i++)
            {
                Console.WriteLine($"{teploty[i]}°C\t {rychlostVetru[i]}m/s\t {tlak[i]}hPa");
            }
        }

        private static List<string> parserXML(XmlDocument xmlDocument, string nameXmlNode, string nameAtribute)
        {
            XmlNodeList nodes =
                xmlDocument.DocumentElement.SelectNodes("/weatherdata/product/time/location/" + nameXmlNode);
            List<string> values = new List<string>();
            Console.WriteLine("nodes: " + nodes.Count);
            foreach (XmlNode node in nodes)
            {
                values.Add(node.Attributes[nameAtribute].Value);
            }

            return values;
        }
    }
}