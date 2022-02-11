namespace WTP_Report_Manager.Data
{
    public class AppConfig
    {
        public SqlConnConfig SqlConnConfig { get; set; }
        public PlotVar PlotVar { get; set; }
        public string SaveFilePath { get; set; }

        public AppConfig()
        {
            SqlConnConfig = new SqlConnConfig();
            PlotVar = new PlotVar();
        }
    }
}
