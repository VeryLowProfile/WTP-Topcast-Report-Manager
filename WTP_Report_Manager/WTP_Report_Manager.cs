using System;
using System.Windows.Forms;
using WTP_Report_Manager.Forms;
using WTP_Report_Manager.Data;

namespace WTP_Report_Manager
{
    public partial class WTP_Report_Manager : UserControl
    {
        private Form activeForm;
        public static AppConfig AppConfig { get; set; }
        public static SearchParam SearchParam { get; set;}
        public static SelectedData SelectedData { get; set; }
        public static VisualizationData visualizationData { get; set; }

        public WTP_Report_Manager()
        {
            InitializeComponent();
            AppConfig = new AppConfig();
            SearchParam = new SearchParam();
            SelectedData = new SelectedData();
            visualizationData = new VisualizationData();
            FillAppconfig();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormVisualizationManagment.CloseForm(activeForm);
            activeForm = FormVisualizationManagment.OpenFormInPanel(new FormSearch(), panelChildform);
        }

        private void buttonResume_Click(object sender, EventArgs e)
        {
            FormVisualizationManagment.CloseForm(activeForm);
            activeForm = FormVisualizationManagment.OpenFormInPanel(new FormResume(), panelChildform);
        }

        private void buttonEventMessages_Click(object sender, EventArgs e)
        {
            FormVisualizationManagment.CloseForm(activeForm);
            activeForm = FormVisualizationManagment.OpenFormInPanel(new FormEvents(), panelChildform);
        }

        private void buttonTrends_Click(object sender, EventArgs e)
        {
            FormVisualizationManagment.CloseForm(activeForm);
            activeForm = FormVisualizationManagment.OpenFormInPanel(new FormTrends(), panelChildform);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            FormVisualizationManagment.CloseForm(activeForm);
            activeForm = FormVisualizationManagment.OpenFormInPanel(new FormReports(), panelChildform);
        }

        private void FillAppconfig()
        {
            AppConfig.SqlConnConfig.SqlServerIP = "192.168.10.33";
            AppConfig.SqlConnConfig.SqlServerName = "SQLEXPRESS";
            AppConfig.SqlConnConfig.SqlDbName = "WTP";
            AppConfig.SqlConnConfig.SqlUserID = "WTP";
            AppConfig.SqlConnConfig.SqlUserPWD = "Topcast";
            AppConfig.SqlConnConfig.SqlConnectionString = $"Server = {AppConfig.SqlConnConfig.SqlServerIP}\\{AppConfig.SqlConnConfig.SqlServerName}; Database = {AppConfig.SqlConnConfig.SqlDbName}; UID = {AppConfig.SqlConnConfig.SqlUserID}; PWD = {AppConfig.SqlConnConfig.SqlUserPWD}";

            AppConfig.PlotVar.Var.Add("TC1Cru");
            AppConfig.PlotVar.Var.Add("TC2Cru");
            AppConfig.PlotVar.Var.Add("TMedCru");
            AppConfig.PlotVar.Var.Add("PowerCru");
            AppConfig.PlotVar.Var.Add("TC1Tund");
            AppConfig.PlotVar.Var.Add("PowerTund");
            AppConfig.PlotVar.Var.Add("TempSH");
            AppConfig.PlotVar.Var.Add("UmidSH");
            AppConfig.PlotVar.Var.Add("TCValveSH");
            AppConfig.PlotVar.Var.Add("VacuumSH");
            AppConfig.PlotVar.Var.Add("WaterFlow");
            AppConfig.PlotVar.Var.Add("WaterTemp");
            AppConfig.PlotVar.Var.Add("WaterLevel");
            AppConfig.PlotVar.Var.Add("Alcohol");

            AppConfig.SaveFilePath = @"Z:\METIER\Process_Export";

            visualizationData.HidePlotVar.AddRange(AppConfig.PlotVar.Var.ToArray());

        }
    }
}
