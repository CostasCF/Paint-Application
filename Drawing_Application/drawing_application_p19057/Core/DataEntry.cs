using System;

namespace drawing_application_p19057.Core
{
    public class DataEntry
    {
        public String Name { get; set; }
        public String timeStamp { get; set; }
        public DataEntry(String name)
        {
            Name = name;
            timeStamp = DateTime.Now.ToString();
        }
    }
}
