using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace drawing_application_p19057.Core
{
    public static class Serialize
    {
        public static void SerializeTimelapseSettings(List<Timelapse> drawings, String timelapseName)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(timelapseName, FileMode.OpenOrCreate, FileAccess.Write);

            formatter.Serialize(stream, drawings);

            stream.Close();
        }
        public static List<Timelapse> DeserializeTimelapseSettings(String name)
        {

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(name, FileMode.OpenOrCreate, FileAccess.Read);
            List<Timelapse> drawingsDeserialized = (List<Timelapse>)formatter.Deserialize(stream);
            stream.Close();
            return drawingsDeserialized;
        }

    }
}
