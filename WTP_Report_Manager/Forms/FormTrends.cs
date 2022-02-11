using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WTP_Report_Manager.Workers;

namespace WTP_Report_Manager.Forms
{
    public partial class FormTrends : Form
    {
        public FormTrends()
        {
            InitializeComponent();
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
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBoxHide.SelectedItem != null)
            {
                WTP_Report_Manager.visualizationData.MovePlotHideToShow(listBoxHide.SelectedItem.ToString());
                listBoxHide.Items.Clear();
                listBoxHide.Items.AddRange(WTP_Report_Manager.visualizationData.HidePlotVar.ToArray());
                listBoxShow.Items.Clear();
                listBoxShow.Items.AddRange(WTP_Report_Manager.visualizationData.ShowPlotVar.ToArray());
            }
            else
            {
                MessageBox.Show("No Item Selected", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

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

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (listBoxShow.SelectedItem != null)
            {
                WTP_Report_Manager.visualizationData.MovePlotShowToHide(listBoxShow.SelectedItem.ToString());
                listBoxHide.Items.Clear();
                listBoxHide.Items.AddRange(WTP_Report_Manager.visualizationData.HidePlotVar.ToArray());
                listBoxShow.Items.Clear();
                listBoxShow.Items.AddRange(WTP_Report_Manager.visualizationData.ShowPlotVar.ToArray());
            }
            else
            {
                MessageBox.Show("No Item Selected", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

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

        private void buttonAddAll_Click(object sender, EventArgs e)
        {
            WTP_Report_Manager.visualizationData.PlotShowAll();
            listBoxHide.Items.Clear();
            listBoxHide.Items.AddRange(WTP_Report_Manager.visualizationData.HidePlotVar.ToArray());
            listBoxShow.Items.Clear();
            listBoxShow.Items.AddRange(WTP_Report_Manager.visualizationData.ShowPlotVar.ToArray());


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

        private void buttonSubAll_Click(object sender, EventArgs e)
        {
            WTP_Report_Manager.visualizationData.PlotHideAll();
            listBoxHide.Items.Clear();
            listBoxHide.Items.AddRange(WTP_Report_Manager.visualizationData.HidePlotVar.ToArray());
            listBoxShow.Items.Clear();
            listBoxShow.Items.AddRange(WTP_Report_Manager.visualizationData.ShowPlotVar.ToArray());


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

        private void buttonShowTrends_Click(object sender, EventArgs e)
        {
            string plotQry = SqlQryBuilder.BuildPlotQry(comboBoxIDList.Text, WTP_Report_Manager.visualizationData.ShowPlotVar);

            DataTable plotTable = new DataTable();

            try
            {
                plotTable = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, plotQry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " plotQry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            dataGridViewPlot.DataSource = plotTable;
            dataGridViewPlot.Update();

            panelPlot.Controls.Clear();

            Chart chart = new Chart();

            Legend legend = new Legend();

            ChartArea chartArea = new ChartArea();
            chartArea.CursorX.IsUserEnabled = true;
            chartArea.CursorX.IsUserSelectionEnabled = true;
            chartArea.CursorX.IntervalType = DateTimeIntervalType.Seconds;
            chartArea.CursorY.IsUserEnabled = true;
            chartArea.CursorY.IsUserSelectionEnabled = true;
            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisX.ScrollBar.Enabled = true;
            chartArea.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea.AxisY.ScaleView.Zoomable = true;
            chartArea.AxisY.ScrollBar.Enabled = true;
            chartArea.AxisY.ScrollBar.IsPositionedInside = false;
            chartArea.AxisX.ScrollBar.Size = 20D;
            chartArea.AxisY.ScrollBar.Size = 20D;
            chartArea.AxisX.IntervalType = DateTimeIntervalType.Seconds;


            chart.DataSource = plotTable;
            chart.Dock = DockStyle.Fill;
            chart.ChartAreas.Add(chartArea);
            chart.Legends.Add(legend);

            foreach (string var in WTP_Report_Manager.visualizationData.ShowPlotVar)
            {
                Series series = new Series();
                series.ChartType = SeriesChartType.Line;
                series.XValueType = ChartValueType.Time;
                series.XValueMember = "DateTime";
                series.YValueMembers = var;
                series.Name = var;
                chart.Series.Add(series);
            }

            panelPlot.Controls.Add(chart);
        }
    }
}
