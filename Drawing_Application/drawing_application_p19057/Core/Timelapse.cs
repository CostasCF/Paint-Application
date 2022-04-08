using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static drawing_application_p19057.MainWindow;

namespace drawing_application_p19057.Core
{
    [Serializable]
    public class Timelapse
    {
        public string Name { get; set; }
        public List<Shapes> AllcurvesTimelapse { get; set; }
        public int ListIndex { get; set; } = 0;
        public int SecondsAnimation { get; set; } = 0;

        public Coordinates Coordinates { get; set; }
        [NonSerialized]
        public MainWindow form;
        [NonSerialized]
        public System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Timelapse(string name, List<Shapes> allcurvesTimelapse, int secondsAnimation, Coordinates coordinates)
        {
            Name = name;
            AllcurvesTimelapse = allcurvesTimelapse.ToList();
            SecondsAnimation = secondsAnimation;
            Coordinates = new Coordinates(coordinates.MouseDownX, coordinates.MouseDownY, coordinates.MouseUpX, coordinates.MouseUpY);

            //adding the tick event to the timer
            timer.Tick += new EventHandler(timelapseTimer_Tick);
            if (AllcurvesTimelapse.Count > 0)
            {
                //finding the interval based on the desired animation's duration of it.
                timer.Interval = (secondsAnimation * 1000) / AllcurvesTimelapse.Count;
            }
        }

        public void timelapseTimer_Tick(object sender, EventArgs e)
        {
            try
            {

                Allcurves.Add(AllcurvesTimelapse[ListIndex]);
                form.drawingBox.Invalidate();
                ListIndex++;
            }
            catch (ArgumentOutOfRangeException)
            {
                ListIndex = 0;
                timer.Stop();
            }
        }


        public void timerStarter()
        {
            form = (MainWindow)Application.OpenForms[0];
            timer.Start(); //starts the timer
        }
    }
}
