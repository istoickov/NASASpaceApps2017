using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using System.Net;
using System.IO;

using Newtonsoft.Json.Linq;
using System.Linq;

namespace NASAapp
{
    public class IPLocation
    {
        public string @as { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string isp { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string org { get; set; }
        public string query { get; set; }
        public string region { get; set; }
        public string regionName { get; set; }
        public string status { get; set; }
        public string timezone { get; set; }
        public string zip { get; set; }

        public IPLocation() { }

        public IPLocation(string @as, string city, string country, string countryCode, string isp, double lat, double lon, string org, string query, string region, string regionName, string status, string timezone, string zip)
        {
            this.@as = @as;
            this.city = city;
            this.country = country;
            this.countryCode = countryCode;
            this.isp = isp;
            this.lat = lat;
            this.lon = lon;
            this.org = org;
            this.query = query;
            this.region = region;
            this.regionName = regionName;
            this.status = status;
            this.timezone = timezone;
            this.zip = zip;
        }

        public override string ToString()
        {
            return this.lat + " " + this.lon;
        }
    }

    public class Functions
    {
        public List<RootObject> check(List<RootObject> RootObjects, string RootObject, string Lat, string Lon)
        {
            List<RootObject> list = new List<RootObject>();
            double lat = double.Parse(Lat), lon = double.Parse(Lon);

            foreach (RootObject p in RootObjects)
                if (p.countryname.Equals(RootObject) || (Math.Abs(Double.Parse(p.latitude) - lat) < 0.5 && (Math.Abs(Double.Parse(p.longitude) - lon) < 0.5)))
                    list.Add(p);

            return list;
        }

        public List<RootObject> nearby(List<RootObject> RootObjects, double dist, string Lat, string Lon)
        {
            List<RootObject> list = new List<RootObject>();
            string ip = MyIP();

            if (ip == null)
            {
                return null;
            }

            string[] part = GetLocation(MyIP()).Trim().Split(' ');

            double x1 = double.Parse(part[0]);
            double y1 = double.Parse(part[1]);
            double x2 = double.Parse(Lat);
            double y2 = double.Parse(Lon);

            foreach (RootObject p in RootObjects)
            {
                double d = distance(x1, y1, x2, y2);
                if (d <= 250)
                    list.Add(p);
            }
            return list;
        }

        public double distance(double lon1, double lat1, double lon2, double lat2)
        {
            double R = 6371e3;
            double fi1 = lat1 * 0.0174533;
            double fi2 = lat2 * 0.0174533;
            double delataFi = (lat2 - lat1) * 0.0174533;
            double delataLambda = (lon2 - lon1) * 0.0174533;

            double a = Math.Sin(delataFi / 2) * Math.Sin(delataFi / 2) +
                    Math.Cos(fi1) * Math.Cos(fi2) *
                    Math.Sin(delataLambda / 2) * Math.Sin(delataLambda / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            double d = R * c;

            return d;
        }

        public string GetLocation(string ip)
        {
            IPLocation data = new IPLocation();
            try
            {
                string info = new WebClient().DownloadString("http://ip-api.com/json/");
                data = JsonConvert.DeserializeObject<IPLocation>(info);
                return data.ToString();
            }
            catch (Exception)
            {

            }
            return "";
        }

        public string MyIP()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return new WebClient().DownloadString(@"http://icanhazip.com").Trim();
                    }
                }
            }
            catch
            {
                return "No";
            }
        }

        public Objects ParseJSON(string query)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            string url = "";
            if (!query.Equals("all"))
            {
                url = "https://data.nasa.gov/resource/tfkf-kniw.json?countryname=" + query;
            }
            else
            {
                url = "https://data.nasa.gov/resource/tfkf-kniw.json";
            }

            using (WebClient client = new WebClient())
            using (Stream stream = client.OpenRead(url))
            using (StreamReader streamReader = new StreamReader(stream))
            using (JsonReader reader = new JsonTextReader(streamReader))
            {
                reader.SupportMultipleContent = true;

                RootObject RootObjects = new RootObject();
                var serializer = new JsonSerializer();

                Objects obj = new Objects();

                while (reader.Read())
                {
                    if (reader.TokenType == JsonToken.StartObject)
                    {
                        RootObject p = serializer.Deserialize<RootObject>(reader);
                        obj.obj.Add(p);
                    }
                }

                return obj;
            }
        }

        public List<RootObject> getByYear(List<RootObject> list, double year)
        {
            List<RootObject> RootObjects = new List<RootObject>();
            foreach (RootObject p in list)
            {
                if (p.tstamp.Contains(year.ToString()))
                {
                    RootObjects.Add(p);
                }
            }
            return RootObjects;
        }

        public double probability(List<RootObject> list, string lat, string lon)
        {
            List<RootObject> nearRootObjects = nearby(list, 200, lat, lon);
            double P = 0;


            return P;
        }
    }
}
