using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;

namespace asdasdasd.Repo
{ 
    interface IAdapter
    {
        void Add(Models.Properties properties);
            
    }
    class Xmladapter : IAdapter
    {
        public XmlDB _db { get; set; }

        public Xmladapter()
        {
          
        }

        public Xmladapter(XmlDB dB)
        {
            //_db = dB;
        }
        public void Add(Models.Properties properties)
        {
           

           // if (properties != null&& _db!=null)
            //{

           _db.Add(properties);
            //}

        }
    }
    class XmlDB
    {
        public XmlDB()
        {

        }

        public void Add(Models.Properties properties)
        {
            string file = $"{properties.Name} - {properties.Surname} - {properties.Email}";


            var xml = new XmlSerializer(typeof(Models.Properties));
                    using (var fs = new FileStream("Translator.xml", FileMode.OpenOrCreate))
                    {
                        xml.Serialize(fs, file);
                    }

        }
    }

    class Jsonadapter : IAdapter
    {
        private JsonDB _db;

        public Jsonadapter()
        {
        }

        public Jsonadapter(JsonDB dB)
        {
            _db = dB;
        }
        public void Add(Models.Properties properties)
        {
            if (properties != null && _db != null)
            {

                
            _db.Add(properties);
            }
        }
    }
    class JsonDB
    {
        public void Add(Models.Properties properties)
        {

            string file = $"{properties.Name} - {properties.Surname} - {properties.Email}";
            System.IO.File.WriteAllText(@"C:\path.txt", file);


        }
    }
}
