using System;

namespace drawing_application.Core
{

    [Serializable]
    public class Coordinates
    {
        public int MouseDownX { get; set; }
        public int MouseDownY { get; set; }
        public int MouseUpX { get; set; }
        public int MouseUpY { get; set; }

        public Coordinates(int mouseDownX, int mouseDownY, int mouseUpX, int mouseUpY)
        {
            MouseDownX = mouseDownX;
            MouseDownY = mouseDownY;
            MouseUpX = mouseUpX;
            MouseUpY = mouseUpY;

        }
    }
}
