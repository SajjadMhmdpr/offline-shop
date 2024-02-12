using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussiness_entity
{
    public class persion
    {
        public int id { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public byte age { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string telephone { get; set; }
        public string address { get; set; }
        public string codemeli { get; set; }
        public bool status { get; set; }

    }

    public class customer : persion
    {
        public List<sabad> sabad { get; set; } = new List<sabad>();
    }

    public class manager : persion
    {
        public string restoran_name { get; set; }
    }

    public class kala
    {
        public int id { get; set; }
        public string kala_name { get; set; }
        public string kala_date_tolid { get; set; }
        public string kala_date_enqeza { get; set; }
        public bool kala_status { get; set; }
        public int tedad_mojodi { get; set; }
        public string group { get; set; }
    }

    public class sabad
    {
        public int id { get; set; }
        public List<tarikhche> kalaha_dar_sabad { get; set; } = new List<tarikhche>();
        public List<choose_kala> kharid_shode { get; set; } = new List<choose_kala>();
        public double qeimatkol { get; set; }
    }

    public class choose_kala
    {
        public int id { get; set; }
        public kala kalaha { get; set; }
        public int tedad_entekhab { get; set; }
    }

    public class tarikhche
    {
        public int id { get; set; }
        public string date_kharid { get; set; }
        public List<choose_kala> kharid_shode { get; set; } = new List<choose_kala>();
        public double qeimatkol { get; set; }

    }

}
