using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace ChartTest.Controls
{
    public partial class RealtimeChart : TChart
    {
        readonly Line RealtimeCurve;
        public RealtimeChart()
        {
            InitializeComponent();

            this.Size = new Size(550, 380);
            RealtimeCurve = new()
            {
                Color = Color.Red
            };
            this.RealtimeCurve.XValues.DateTime = true;
            this.Series.Add(this.RealtimeCurve);
            this.Aspect.View3D = false;
            this.Axes.Automatic = true;
            this.Axes.Left.FixedLabelSize = false;
            this.Legend.Visible = false;
            this.Header.Visible = false;
        }
    }
}
