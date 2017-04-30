using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASAapp
{
    public class Objects
    {
        public List<RootObject> obj { get; set; }

        public Objects()
        {
            obj = new List<RootObject>();
        }

        public override string ToString()
        {
            return obj.ToString();
        }
    }

    public class Geolocation
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }

        public Geolocation() { }

        public Geolocation(string type, List<double> coordinates)
        {
            this.type = type;
            this.coordinates = coordinates;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}", this.coordinates[0], this.coordinates[1]);
        }
    }

    public class RootObject
    {
        public string adminname1 { get; set; }
        public string adminname2 { get; set; }
        public string cat_id { get; set; }
        public string cat_src { get; set; }
        public string changeset_id { get; set; }
        public string continentcode { get; set; }
        public string countrycode { get; set; }
        public string countryname { get; set; }
        public string date { get; set; }
        public string distance { get; set; }
        public string fatalities { get; set; }
        public Geolocation geolocation { get; set; }
        public string hazard_type { get; set; }
        public string id { get; set; }
        public string injuries { get; set; }
        public string key { get; set; }
        public string landslide_size { get; set; }
        public string landslide_type { get; set; }
        public string latitude { get; set; }
        public string location_accuracy { get; set; }
        public string location_description { get; set; }
        public string longitude { get; set; }
        public string near { get; set; }
        public string nearest_RootObjects { get; set; }
        public string population { get; set; }
        public string source_link { get; set; }
        public string source_name { get; set; }
        public string storm_name { get; set; }
        public string trigger { get; set; }
        public string tstamp { get; set; }
        public string version { get; set; }

        public RootObject() { }

        public RootObject(string countryname, string latitude, string longitude)
        {
            this.countryname = countryname;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public RootObject(string adminname1, string adminname2, string cat_id, string cat_src, string changeset_id, string continentcode, string countrycode, string countryname, string date, string distance, string fatalities, Geolocation geolocation, string hazard_type, string id, string injuries, string key, string landslide_size, string landslide_type, string latitude, string location_accuracy, string location_description, string longitude, string near, string nearest_RootObjects, string population, string source_link, string source_name, string storm_name, string trigger, string tstamp, string version)
        {
            this.adminname1 = adminname1;
            this.adminname2 = adminname2;
            this.cat_id = cat_id;
            this.cat_src = cat_src;
            this.changeset_id = changeset_id;
            this.continentcode = continentcode;
            this.countrycode = countrycode;
            this.countryname = countryname;
            this.date = date;
            this.distance = distance;
            this.fatalities = fatalities;
            this.geolocation = geolocation;
            this.hazard_type = hazard_type;
            this.id = id;
            this.injuries = injuries;
            this.key = key;
            this.landslide_size = landslide_size;
            this.landslide_type = landslide_type;
            this.latitude = latitude;
            this.location_accuracy = location_accuracy;
            this.location_description = location_description;
            this.longitude = longitude;
            this.near = near;
            this.nearest_RootObjects = nearest_RootObjects;
            this.population = population;
            this.source_link = source_link;
            this.source_name = source_name;
            this.storm_name = storm_name;
            this.trigger = trigger;
            this.tstamp = tstamp;
            this.version = version;
        }

        public override string ToString()
        {
            return String.Format("Date: {0} Country: {1} Geolocation: {2}", this.date.Substring(0,10) , this.countryname, this.geolocation);
        }
    }
}
