using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FishMerchendise
{
    public partial class FishMerchendise : Form
    {
        public FishMerchendise()
        {
            InitializeComponent();
        }

        private int maxTemperature;
        DateTime maxTime;
        DateTime minTime;
        private int minTemperature;
        DateTime measuringTime;

        private void TakeReport_Click(object sender, EventArgs e)
        {
            string[] temperatures = Temps.Text.Split(" ");
            maxTemperature = Convert.ToInt32(MaxTemperatureValue.Text);
            minTemperature = Convert.ToInt32(MinTemperatureValue.Text);
            //maxTime = new DateTime(1, 1, 1, 1, minute: Convert.ToInt32(MaxTimeValue.Text), 1);
            //minTime = new DateTime(1, 1, 1, 1, minute: Convert.ToInt32(MinTimeValue.Text), 1);
            measuringTime = DateTime.ParseExact(TimePicker.Text, "dd.M.yyyy H:mm", null);
            ReportParse(maxTemperature, minTemperature,measuringTime, temperatures);
        }
        static void ReportParse(int maxTemperature, int minTemperature, DateTime measuringTime, string[] temperatures)
        {
            string factTemperature;
            DateTime timeDeviation = measuringTime;
            int temperatureDeviation = 0;
            string[] finishReport = new string[4];
            for (int i = 0; i < temperatures.Length; i++)
            {
                finishReport[0] = Convert.ToString(measuringTime);
                factTemperature = temperatures[i];
                finishReport[1] = factTemperature;
                finishReport[2] = Convert.ToString(maxTemperature);
                if (Convert.ToInt32(factTemperature) < minTemperature)
                {
                    temperatureDeviation = Math.Abs( int.Parse(factTemperature) - minTemperature);
                }
                else if (Convert.ToInt32(factTemperature) > maxTemperature)
                {
                    temperatureDeviation = Math.Abs(int.Parse(factTemperature) - maxTemperature);
                }
                finishReport[3] = Convert.ToString(temperatureDeviation);
                measuringTime = measuringTime.AddMinutes(10);
                Save($"{finishReport[0]}, {finishReport[1]}, {finishReport[2]}, {finishReport[3]}");
            }
        }
        static void Save(string newLine)
        {
            string path = @"\\NAS36D451\user-domain$\stud\212008\Desktop\fish\result.txt";
            using (StreamWriter dataWriter = new StreamWriter(path, true))
            {
                dataWriter.WriteLine(newLine);
            }
        }
    }
}
