using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace FindANameFarm.MetaLayer
{
    class DbFactory
    {
        private static IIDbConnection _instance;

        Dictionary<string, string> _properties;
        private static string propfile = "properties.dat";

        private DbFactory()
        {
            _properties = new Dictionary<string, string>();
        }
        public static IIDbConnection Instance()
        {
            if (null == _instance)
            {
                DbFactory factory = new DbFactory();
                _instance = factory.Connection;
            }
            return _instance;
        }
        private IIDbConnection Connection
        {
            get
            {
                IIDbConnection connection;

                try
                {
                    _properties = getProperties();
                    string provider = _properties["Provider"];
                    if (provider.Equals("Microsoft.ACE.OLEDB.12.0"))
                        connection = new OledbConnection(_properties);

                    else if (provider.Equals("Microsoft.ACE.OLEDB.15.0"))
                        connection = new OledbConnection(_properties);
                    else if (provider.Equals("Microsoft.ACE.OLEDB.16.0"))
                        connection = new OledbConnection(_properties);
                    else
                    {
                        // should throw unsupport exception here
                        throw new DBException("Not supported provider '" + provider + "'");
                    }
                }
                catch (FileNotFoundException e)
                {
                    Debug.WriteLine("Error file not found" + e.Message);
                    throw;
                }
                catch (Exception e)
                {
                    Debug.WriteLine("Property file parsing exception thrown : " + e.Message);
                    throw;
                }
                return connection;
            }
        }

        private Dictionary<string, string> getProperties()
        {
            string fileData;
            using (StreamReader sr = new StreamReader(propfile))
            {
                fileData = sr.ReadToEnd().Replace("\r", "");
            }
            Dictionary<string, string> properties = new Dictionary<string, string>();
            string[] kvp;
            string[] records = fileData.Split("\n".ToCharArray());
            foreach (string record in records)
            {
                kvp = record.Split("=".ToCharArray());
                properties.Add(kvp[0], kvp[1]);
            }
            return properties;
        }
    }
}
