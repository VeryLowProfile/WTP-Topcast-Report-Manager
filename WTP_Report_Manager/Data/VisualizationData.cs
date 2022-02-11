using System.Collections.Generic;

namespace WTP_Report_Manager.Data
{
    public class VisualizationData
    {
        public List<string> HidePlotVar { get; set; }
        public List<string> ShowPlotVar { get; set; }
        public List<string> HideReportID { get; set; }
        public List<string> ShowReportID { get; set; }

        public VisualizationData()
        {
            HidePlotVar = new List<string>();
            ShowPlotVar = new List<string>();
            HideReportID = new List<string>();
            ShowReportID = new List<string>();
        }

        public void MovePlotHideToShow(string var)
        {
            HidePlotVar.Remove(var);
            ShowPlotVar.Add(var);
        }

        public void MovePlotShowToHide(string var)
        {
            HidePlotVar.Add(var);
            ShowPlotVar.Remove(var);
        }

        public void PlotHideAll()
        {
            foreach (string var in ShowPlotVar)
            {
                HidePlotVar.Add(var);
            }
            ShowPlotVar.Clear();
        }

        public void PlotShowAll()
        {
            foreach (string var in HidePlotVar)
            {
                ShowPlotVar.Add(var);
            }
            HidePlotVar.Clear();
        }

        public void MoveIdHideToShow(string var)
        {
            HideReportID.Remove(var);
            ShowReportID.Add(var);
        }

        public void MoveIdShowToHide(string var)
        {
            HideReportID.Add(var);
            ShowReportID.Remove(var);
        }

        public void IdHideAll()
        {
            foreach (string var in ShowReportID)
            {
                HideReportID.Add(var);
            }
            ShowReportID.Clear();
        }

        public void IdShowAll()
        {
            foreach (string var in HideReportID)
            {
                ShowReportID.Add(var);
            }
            HideReportID.Clear();
        }
    }
}
