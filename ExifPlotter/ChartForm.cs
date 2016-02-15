using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ExifPlotter
{
    public partial class ChartForm : Form
    {

        List<StatItem> stats;

        public ChartForm(List<StatItem> statsList, string type)
        {
            InitializeComponent();
            this.stats = statsList;
            PlotChart(type);
        }

        private void PlotChart(string type)
        {
            if(type.Equals("bar"))
            {
                Series series = this.chart.Series.Add("Focal Length");
                foreach (StatItem stat in stats)
                {
                    this.chart.Series["Focal Length"].Points.AddXY(stat.name, stat.count);
                    //series.Points.Add(Convert.ToDouble(stat.count));
                }
            }
        }
    }
}
