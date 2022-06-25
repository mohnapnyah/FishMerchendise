using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string[] temperatures = Temps.Text.Split("");
            maxTemperature = Convert.ToInt32(MaxTemperatureValue.Text);
            minTemperature = Convert.ToInt32(MinTemperatureValue.Text);
            maxTime = Convert.ToDateTime(MaxTimeValue.Text);
            minTime = Convert.ToDateTime(MinTimeValue.Text);
        }
        static void ReportParse(int maxTemperature, int minTemperature, DateTime maxTime, DateTime minTime, DateTime measuringTime, string[] temperatures)
        {
            string factTemperature;
            //DateTime timeDeviation;
            int temperatureDeviation = 0;
            string[] finishReport = new string[4];
            for (int i = 0; i < temperatures.Length; i++)
            {
                finishReport[0] = Convert.ToString(measuringTime);
                factTemperature = Convert.ToString(temperatures[i]);
                finishReport[1] = factTemperature;
                finishReport[2] = Convert.ToString(maxTemperature);
                //finishReport[3] = Convert.ToString(timeDeviations);


            }
        }
    }
}
