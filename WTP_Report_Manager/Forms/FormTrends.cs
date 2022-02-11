using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using WTP_Report_Manager.Workers;

namespace WTP_Report_Manager.Forms
{
    public partial class FormTrends : Form
    {

        ChartArea chartArea;
        Legend legend;
        Chart chart;
        ToolTip tooltip;

        public FormTrends()
        {
            InitializeComponent();

            chartArea = new ChartArea();
            legend = new Legend();
            chart = new Chart();
            tooltip = new ToolTip();

        }

        private void FormTrends_Load(object sender, EventArgs e)
        {
            comboBoxIDList.Items.AddRange(WTP_Report_Manager.SelectedData.SelectedIDs.ToArray());
            comboBoxIDList.Text = comboBoxIDList.Items[0].ToString();

            listBoxHide.Items.AddRange(WTP_Report_Manager.visualizationData.HidePlotVar.ToArray());
            listBoxHide.Update();

            listBoxShow.Items.AddRange(WTP_Report_Manager.visualizationData.ShowPlotVar.ToArray());
            listBoxHide.Update();

            if (WTP_Report_Manager.visualizationData.ShowPlotVar.Count == 0)
            {
                buttonSub.Visible = false;
                buttonSubAll.Visible = false;
                buttonShowTrends.Visible = false;
            }

            //Init Chart
            chartArea.CursorX.IsUserEnabled = true;
            chartArea.CursorX.IsUserSelectionEnabled = true;
            chartArea.CursorX.IntervalType = DateTimeIntervalType.Seconds;
            chartArea.CursorX.LineColor = Color.Gray;
            chartArea.CursorX.LineWidth = 2;
            chartArea.CursorX.LineDashStyle = ChartDashStyle.Dash;

            chartArea.CursorY.IsUserEnabled = true;
            chartArea.CursorY.IsUserSelectionEnabled = true;
            chartArea.CursorY.LineColor = Color.Gray;
            chartArea.CursorY.LineWidth = 2;
            chartArea.CursorY.LineDashStyle = ChartDashStyle.Dash;

            chartArea.BackColor = panelContainerPlot.BackColor;

            chartArea.AxisX.IntervalType = DateTimeIntervalType.Auto;
            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisX.ScrollBar.Enabled = true;
            chartArea.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea.AxisX.ScrollBar.Size = 20;
            chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;
            chartArea.AxisX.ScrollBar.LineColor = Color.LightGray;
            chartArea.AxisX.ScrollBar.BackColor = Color.LightGray;
            chartArea.AxisX.ScrollBar.ButtonColor = Color.Gray;
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisX.LineColor = Color.LightGray;
            chartArea.AxisX.InterlacedColor = Color.LightGray;
            chartArea.AxisX.TitleForeColor = Color.LightGray;

            chartArea.AxisY.ScaleView.Zoomable = true;
            chartArea.AxisY.ScrollBar.Enabled = true;
            chartArea.AxisY.ScrollBar.IsPositionedInside = false;
            chartArea.AxisY.ScrollBar.Size = 20;
            chartArea.AxisY.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;
            chartArea.AxisY.ScrollBar.LineColor = Color.LightGray;
            chartArea.AxisY.ScrollBar.BackColor = Color.LightGray;
            chartArea.AxisY.ScrollBar.ButtonColor = Color.Gray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.LineColor = Color.LightGray;
            chartArea.AxisY.InterlacedColor = Color.LightGray;
            chartArea.AxisY.TitleForeColor = Color.LightGray;

            legend.BackColor = panelContainerPlot.BackColor;

            chart.BackColor = panelContainerPlot.BackColor;
            chart.Dock = DockStyle.Fill;
            chart.ChartAreas.Add(chartArea);
            chart.Legends.Add(legend);
            chart.MouseMove += Chart_MouseMove;

            //Add Chart to Panel
            panelPlot.Controls.Add(chart);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            int selectedIndex = listBoxHide.SelectedIndices[0];

            if (listBoxHide.SelectedItems != null)
            {

                foreach (string item in listBoxHide.SelectedItems)
                {
                    WTP_Report_Manager.visualizationData.MovePlotHideToShow(item);
                }

                listBoxHide.Items.Clear();
                listBoxHide.Items.AddRange(WTP_Report_Manager.visualizationData.HidePlotVar.ToArray());
                listBoxShow.Items.Clear();
                listBoxShow.Items.AddRange(WTP_Report_Manager.visualizationData.ShowPlotVar.ToArray());

                if (selectedIndex == 0)
                {
                    listBoxHide.SelectedIndex = 0;
                } else
                {
                    listBoxHide.SelectedIndex = selectedIndex - 1;
                }

            }
            else
            {
                MessageBox.Show("No Item Selected", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            setButtonVisibility();

        }

        private void buttonSub_Click(object sender, EventArgs e)
        {

            int selectedIndex = listBoxShow.SelectedIndices[0];

            if (listBoxShow.SelectedItems != null)
            {
                foreach (string item in listBoxShow.SelectedItems)
                {
                    WTP_Report_Manager.visualizationData.MovePlotShowToHide(item);
                }

                listBoxHide.Items.Clear();
                listBoxHide.Items.AddRange(WTP_Report_Manager.visualizationData.HidePlotVar.ToArray());
                listBoxShow.Items.Clear();
                listBoxShow.Items.AddRange(WTP_Report_Manager.visualizationData.ShowPlotVar.ToArray());

                if (selectedIndex == 0)
                {
                    listBoxShow.SelectedIndex = 0;
                }
                else
                {
                    listBoxShow.SelectedIndex = selectedIndex - 1;
                }

            }
            else
            {
                MessageBox.Show("No Item Selected", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            setButtonVisibility();

        }

        private void buttonAddAll_Click(object sender, EventArgs e)
        {
            WTP_Report_Manager.visualizationData.PlotShowAll();
            listBoxHide.Items.Clear();
            listBoxHide.Items.AddRange(WTP_Report_Manager.visualizationData.HidePlotVar.ToArray());
            listBoxShow.Items.Clear();
            listBoxShow.Items.AddRange(WTP_Report_Manager.visualizationData.ShowPlotVar.ToArray());

            setButtonVisibility();
        }

        private void buttonSubAll_Click(object sender, EventArgs e)
        {
            WTP_Report_Manager.visualizationData.PlotHideAll();
            listBoxHide.Items.Clear();
            listBoxHide.Items.AddRange(WTP_Report_Manager.visualizationData.HidePlotVar.ToArray());
            listBoxShow.Items.Clear();
            listBoxShow.Items.AddRange(WTP_Report_Manager.visualizationData.ShowPlotVar.ToArray());

            setButtonVisibility();

        }

        private void buttonShowTrends_Click(object sender, EventArgs e)
        {
            plotChart();
        }

        private void Chart_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;

            var results = chart.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint);

            if (results != null)
            {
                if (results[0].ChartElementType == ChartElementType.DataPoint)
                {
                    var prop = results[0].Object as DataPoint;
                    if (prop != null)
                    {
                        tooltip.Show("VALUE = " + prop.YValues[0], this.chart, pos.X, pos.Y - 15);
                    }
                }
            }
        }

        public async void plotChart()
        {
            string plotQry = SqlQryBuilder.BuildPlotQry(comboBoxIDList.Text, WTP_Report_Manager.visualizationData.ShowPlotVar);
            DataTable dataTable = new DataTable();

            try
            {
                dataTable = await SqlManagment.SqlExecuteQueryAsync(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, plotQry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            chart.Series.Clear();

            foreach (string var in WTP_Report_Manager.visualizationData.ShowPlotVar)
            {
                //Series series = new Series();
                //series.ChartType = SeriesChartType.Line;
                //series.XValueType = ChartValueType.Time;
                //series.XValueMember = "DateTime";
                //series.YValueMembers = var;
                //series.Name = var;
                //chart.Series.Add(series);

                Series series = new Series();
                series.Name = var;
                series.ChartType = SeriesChartType.FastLine;
                series.XValueType = ChartValueType.Time;

                series.BorderWidth = 3;

                foreach (DataRow row in dataTable.Rows)
                {
                    series.Points.AddXY(row["DateTime"], row[var]);
                }

                chart.Series.Add(series);


            }

            //panelPlot.Controls.Add(chart);
            //chart.Show();
        }

        private void setButtonVisibility()
        {
            if (listBoxHide.Items.Count <= 0)
            {
                buttonAdd.Visible = false;
                buttonAddAll.Visible = false;
            }
            else
            {
                buttonAdd.Visible = true;
                buttonAddAll.Visible = true;
            }
            if (listBoxShow.Items.Count <= 0)
            {
                buttonSub.Visible = false;
                buttonSubAll.Visible = false;
                buttonShowTrends.Visible = false;
            }
            else
            {
                buttonSub.Visible = true;
                buttonSubAll.Visible = true;
                buttonShowTrends.Visible = true;
            }
        }

        private void buttonZoomIn_Click(object sender, EventArgs e)
        {
            double startX = chartArea.AxisX.PositionToValue(0);
            double endX = chartArea.AxisX.PositionToValue(100);
            chartArea.AxisX.ScaleView.Zoom((startX * 1.05), (endX * 0.95));
        }

        private void buttonZoomOut_Click(object sender, EventArgs e)
        {
            chartArea.AxisX.ScaleView.ZoomReset();
            chartArea.AxisY.ScaleView.ZoomReset();
        }
        private void buttonTakePicture_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = @"Z:\METIER\";
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath + @"\" + "TrendImage_" + comboBoxIDList.Text + ".png";
                chart.SaveImage(folderPath, ChartImageFormat.Png);
            }
        }
    }
}
