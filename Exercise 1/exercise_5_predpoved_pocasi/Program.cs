using System;
using System.Collections.Generic;
using System.Net;
using System.Xml;
using exercise_5_predpoved_pocasi.Yandex;

namespace exercis_1_5_predpoved_pocasi
{
    // Ke geolokaci bylo využito řešení z https://github.com/Verhov/YandexGeocoder

    internal class Program
    {
        private static readonly List<string> teploty = new List<string>();
        private static readonly List<string> rychlostVetru = new List<string>();
        private static readonly List<string> tlak = new List<string>();
        private static readonly List<string> cas = new List<string>();

        public static void Main(string[] args)
        {
            var client = new WebClient();
            var xmlDocument = new XmlDocument();

            //string result =
            //    client.DownloadString("https://api.met.no/weatherapi/locationforecast/1.9/?lat=60.10&lon=9.58");

            var location = nactiLokaci();
            zjistiPolohu(location, out var lat, out var lon);

            var result = client.DownloadString(
                $"https://api.met.no/weatherapi/locationforecast/1.9/?lat={lat}&lon={lon}");

            xmlDocument.LoadXml(result);
            xmlParsovaniRekurzivne(xmlDocument);
            //xmlParsovaniJmenoNode(xmlDocument);
        }

        private static string nactiLokaci()
        {
            Console.Write("Zadej místo pro které se zobrazí informace o počasí: ");
            var location = Console.ReadLine();
            return location;
        }

        private static void zjistiPolohu(string location, out string lat, out string lon)
        {
            var results = YandexGeocoder.Geocode(location);
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
                hledanyUdaj(hlavniNod, podNod);
                ProjdiNody(podNod);
            }
        }

        private static void hledanyUdaj(XmlNode hlavniNod, XmlNode podNod)
        {
            if (hlavniNod.Name.Equals("product"))
                zpracujCas(podNod);
            else if (hlavniNod.Name.Equals("location")) zpracujUdaj(podNod);
        }

        private static void zpracujCas(XmlNode podNod)
        {
            var value = podNod.Attributes["to"].Value;
            if (cas.Count == 0 || !cas.Contains(value)) cas.Add(value);
        }

        private static void zpracujUdaj(XmlNode podNod)
        {
            switch (podNod.Name)
            {
                case "temperature":
                    teploty.Add(podNod.Attributes["value"].Value);
                    break;
                case "windSpeed":
                    rychlostVetru.Add(podNod.Attributes["mps"].Value);
                    break;
                case "pressure":
                    tlak.Add(podNod.Attributes["value"].Value);
                    break;
            }
        }

        private static void vypisVysledku()
        {
            for (var i = 0; i < tlak.Count; i++)
                Console.WriteLine($"{cas[i]}\t {teploty[i]}°C\t {rychlostVetru[i]}m/s\t {tlak[i]}hPa");
        }

        private static void xmlParsovaniJmenoNode(XmlDocument xmlDocument)
        {
            Console.WriteLine("Po nodech");
            var teploty = parserXML(xmlDocument, "temperature", "value");
            var rychlostVetru = parserXML(xmlDocument, "windSpeed", "mps");
            var tlak = parserXML(xmlDocument, "pressure", "value");

            for (var i = 0; i < tlak.Count; i++)
                Console.WriteLine($"{teploty[i]}°C\t {rychlostVetru[i]}m/s\t {tlak[i]}hPa");
        }

        private static List<string> parserXML(XmlDocument xmlDocument, string nameXmlNode, string nameAtribute)
        {
            var nodes =
                xmlDocument.DocumentElement.SelectNodes("/weatherdata/product/time/location/" + nameXmlNode);
            var values = new List<string>();

            if (nodes == null) return values;
            Console.WriteLine("nodes: " + nodes.Count);
            foreach (XmlNode node in nodes)
                if (node.Attributes != null)
                    values.Add(node.Attributes[nameAtribute].Value);

            return values;
        }
    }
}