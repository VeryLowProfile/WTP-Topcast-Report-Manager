using System.Collections.Generic;
using System.Text;
using WTP_Report_Manager.Data;


namespace WTP_Report_Manager.Workers
{
    public static class SqlQryBuilder
    {
        public static string BuildSearchQry(SearchParam searchParam)
        {
            string qry = "";

            if (searchParam.SearchByID)
            {
                qry = $"SELECT Fo AS [OF], DateTime FROM Resume WHERE Fo LIKE '%{searchParam.SearchID}%' ORDER BY DateTime";
            }

            if (searchParam.SearchByDate)
            {
                if (searchParam.SearchDateFrom.Date == searchParam.SearchDateTo.Date)
                {
                    searchParam.SearchDateTo = searchParam.SearchDateTo.AddDays(1);
                } 

                qry = $"SELECT Fo AS [OF], DateTime FROM Resume WHERE DateTime >= '{searchParam.SearchDateFrom.Date.ToString("yyyy-MM-dd HH:mm:ss")}' AND DateTime <= '{searchParam.SearchDateTo.Date.ToString("yyyy-MM-dd HH:mm:ss")}' ORDER BY DateTime";
            }

            return qry;
        }

        public static string BuildMsgQry(string id)
        {
            string qry;

            qry = $"SELECT Msg.Msg, MsgDef.fr, MsgDef.it, MsgDef.en, DateTime from Msg LEFT JOIN MsgDef on Msg.Msg = MsgDef.Msg Where Fo = '{id}' ORDER BY DateTime";

            return qry;
        }

        public static string BuildEventsQry(string id)
        {
            string qry;

            qry = $"SELECT Events.Event, EventDef.fr, EventDef.it, EventDef.en, DateTime from Events LEFT JOIN EventDef on Events.Event = EventDef.Event Where Fo = '{id}' ORDER BY DateTime";

            return qry;
        }

        public static string BuildResumeQry(string id)
        {
            string qry;

            qry = $"SELECT Fo AS [OF]," +
                $"Prod AS[Matière]," +
                $"RcpName AS [Nom recette]," +
                $"RcpNb AS [Num recette]," +
                $"BoxNbIN AS [Nb bidon déchet]," +
                $"BoxNbOUT AS [Nb bidon grenaille]," +
                $"FumesExtimation AS [Evaluation fumées]," +
                $"GrainsEvaluation AS [Evaluation grenaille]," +
                $"Datetime AS [Date - heure contrôle] " +
                $"FROM Resume " +
                $"Where Fo = '{id}'";

            return qry;
        }

        public static string BuildWinBoxQry(string id, int boxNb)
        {
            string qry;

            qry = $"SELECT Fo AS [OF]," +
                $"BoxCode{boxNb} AS [Num Bidon], " +
                $"BoxTareRol{boxNb} AS [Tare bidon SAP (g)], " +
                $"BoxNetRol{boxNb} AS [Poids net bidon SAP (g)], " +
                $"BoxGrossRol{boxNb} AS [Poids brut bidon SAP (g)], " +
                $"BoxGross{boxNb} AS [Poids brut bidon contrôlé (g)], " +
                $"BoxDeltaNetWeight{boxNb} [Ecart de poids Brut (g)], " +
                $"Datetime AS [Date - heure contrôle] " +
                $"FROM WeigIN " + 
                $"WHERE Fo = '{id}'";

            return qry;
        }

        public static string BuildWoutBoxQry(string id, int boxNb)
        {
            string qry;

            qry = $"SELECT Fo AS [OF]," +
                $"BoxCode{boxNb} AS [Num Bidon]," +
                $"BoxTare{boxNb} AS [Tare bidon (g)]," +
                $"BoxNet{boxNb} AS [Poids net bidon (g)]," +
                $"BoxGrossNoPlmb{boxNb} AS [Poids brut bidon (g)]," +
                $"BoxGross{boxNb} AS [Poids cerclé bidon (g)]," +
                $"BoxPlmbA{boxNb} AS [Num plomb A bidon]," +
                $"BoxPlmbB{boxNb} AS [Num Plomb B bidon]," +
                $"Datetime AS [Date - heure contrôle] " +
                $"FROM WeigOut " +
                $"Where Fo = '{id}'";

            return qry;
        }

        public static string BuildSampleQry(string id)
        {
            string qry;

            qry = $"SELECT Fo AS [OF]," +
                $"SampleTare AS [Tare échantillon (g)]," +
                $"SampleNet AS [Poids net échantillon (g)]," +
                $"SampleGross AS [Poids brut échantillon (g)]," +
                $"Datetime AS [Date - heure contrôle] " +
                $"FROM WeigOut " +
                $"Where Fo = '{id}'";

            return qry; 
        }

        public static string BuildScrapQry(string id)
        {
            string qry;

            qry = $"SELECT Fo AS [OF]," +
                $"ScrapboxCode AS [Num boîte déchet]," +
                $"ScrapTare AS [Tare déchet (g)]," +
                $"ScrapNet AS [Poids net déchet (g)]," +
                $"ScrapGrossNoPlmb AS [Poids brut déchet (g)]," +
                $"ScrapGross AS [Poids cerclé déchet (g)]," +
                $"ScrapPlmb AS [Num plomb déchet]," +
                $"Datetime AS [Date - heure contrôle] " +
                $"FROM WeigOut " +
                $"Where Fo = '{id}'";

            return qry;
        }

        public static string BuildProdQry(string id)
        {
            string qry;

            qry = $"SELECT Prod FROM Resume WHERE Fo = '{id}'";

            return qry;
        }

        public static string BuildPlotQry(string id, List<string> plotVar)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("SELECT ");

            foreach (string var in plotVar)
            {
                builder.Append($"{var}, ");
            }
            builder.Append($"DateTime FROM Trends WHERE Fo = '{id}' ORDER BY DateTime");

            return builder.ToString();
        }

        public static string BuildCountersQry(string id)
        {
            string qry;

            qry = "SELECT Fo AS [OF], " +
                "CruCount, " +
                "CruID, " +
                "Tund1Count, " +
                "Tund1ID, " +
                "Tund2Count, " +
                "Tund2ID, " +
                "ChannelCount, " +
                "ChannelID, " +
                "SHFilterCount, " +
                "SHFilterID " +
                $"FROM Counters " +
                $"Where Fo = '{id}'";

            return qry;
        }

        public static string BuildReportWoutBoxQry(string id, int boxNb)
        {
            string qry;

            qry = $"SELECT Fo AS [OF]," +
                $"BoxCode{boxNb} AS [Num]," +
                $"BoxTare{boxNb} AS [Tare (g)]," +
                $"BoxNet{boxNb} AS [Poids net (g)]," +
                $"BoxGrossNoPlmb{boxNb} AS [Poids brut (g)]," +
                $"BoxGross{boxNb} AS [Poids cerclé (g)]," +
                $"BoxPlmbA{boxNb} AS [Num Plomb A]," +
                $"BoxPlmbB{boxNb} AS [Num Plomb B]," +
                $"Datetime AS [Date - heure contrôle] " +
                $"FROM WeigOut " +
                $"Where Fo = '{id}'";

            return qry;
        }

        public static string BuildReportSampleQry(string id)
        {
            string qry;

            qry = $"SELECT Fo AS [OF]," +
                $"SampleTare AS [Tare (g)]," +
                $"SampleNet AS [Poids net (g)]," +
                $"SampleGross AS [Poids brut (g)]," +
                $"Datetime AS [Date - heure contrôle] " +
                $"FROM WeigOut " +
                $"Where Fo = '{id}'";

            return qry;
        }

        public static string BuildReportScrapQry(string id)
        {
            string qry;

            qry = $"SELECT Fo AS [OF]," +
                $"ScrapboxCode AS [Num]," +
                $"ScrapTare AS [Tare (g)]," +
                $"ScrapNet AS [Poids net (g)]," +
                $"ScrapGrossNoPlmb AS [Poids brut (g)]," +
                $"ScrapGross AS [Poids cerclé (g)]," +
                $"ScrapPlmb AS [Num Plomb A]," +
                $"Datetime AS [Date - heure contrôle] " +
                $"FROM WeigOut " +
                $"Where Fo = '{id}'";

            return qry;
        }

    }
}
