using System;
using System.Data;

namespace WTP_Report_Manager.Workers
{
    static public class DataTableManagement
    {
        public static DataTable CombineWeigInProd(DataTable weigInTable, DataTable prodTable)
        {
            DataTable combineTable = new DataTable();

            combineTable.Columns.Add(weigInTable.Columns[0].ColumnName, weigInTable.Columns[0].DataType);
            combineTable.Columns.Add(prodTable.Columns[0].ColumnName, prodTable.Columns[0].DataType);
            combineTable.Columns.Add(weigInTable.Columns[1].ColumnName, weigInTable.Columns[1].DataType);
            combineTable.Columns.Add(weigInTable.Columns[2].ColumnName, weigInTable.Columns[2].DataType);
            combineTable.Columns.Add(weigInTable.Columns[3].ColumnName, weigInTable.Columns[3].DataType);
            combineTable.Columns.Add(weigInTable.Columns[4].ColumnName, weigInTable.Columns[4].DataType);
            combineTable.Columns.Add(weigInTable.Columns[5].ColumnName, weigInTable.Columns[5].DataType);
            combineTable.Columns.Add(weigInTable.Columns[6].ColumnName, weigInTable.Columns[6].DataType);
            combineTable.Columns.Add(weigInTable.Columns[7].ColumnName, weigInTable.Columns[7].DataType);

            DataRow newRow = combineTable.NewRow();
            combineTable.Rows.Add(newRow);

            try
            {
                combineTable.Rows[0][0] = weigInTable.Rows[0][0];
                combineTable.Rows[0][1] = prodTable.Rows[0][0];
                combineTable.Rows[0][2] = weigInTable.Rows[0][1];
                combineTable.Rows[0][3] = weigInTable.Rows[0][2];
                combineTable.Rows[0][4] = weigInTable.Rows[0][3];
                combineTable.Rows[0][5] = weigInTable.Rows[0][4];
                combineTable.Rows[0][6] = weigInTable.Rows[0][5];
                combineTable.Rows[0][7] = weigInTable.Rows[0][6];
                combineTable.Rows[0][8] = weigInTable.Rows[0][7];
            }
            catch (Exception ex)
            {
                throw new Exception($"DataTableManagement.CombineWeigInProd - {ex.Message}");
            }

            return combineTable;
        }

        public static DataTable CombineWeigOutProd(DataTable weigOutTable, DataTable prodTable)
        {
            DataTable combineTable = new DataTable();

            combineTable.Columns.Add(weigOutTable.Columns[0].ColumnName, weigOutTable.Columns[0].DataType);
            combineTable.Columns.Add(prodTable.Columns[0].ColumnName, prodTable.Columns[0].DataType);
            combineTable.Columns.Add(weigOutTable.Columns[1].ColumnName, weigOutTable.Columns[1].DataType);
            combineTable.Columns.Add(weigOutTable.Columns[2].ColumnName, weigOutTable.Columns[2].DataType);
            combineTable.Columns.Add(weigOutTable.Columns[3].ColumnName, weigOutTable.Columns[3].DataType);
            combineTable.Columns.Add(weigOutTable.Columns[4].ColumnName, weigOutTable.Columns[4].DataType);
            combineTable.Columns.Add(weigOutTable.Columns[5].ColumnName, weigOutTable.Columns[5].DataType);
            combineTable.Columns.Add(weigOutTable.Columns[6].ColumnName, weigOutTable.Columns[6].DataType);
            combineTable.Columns.Add(weigOutTable.Columns[7].ColumnName, weigOutTable.Columns[7].DataType);
            combineTable.Columns.Add(weigOutTable.Columns[8].ColumnName, weigOutTable.Columns[8].DataType);

            DataRow newRow = combineTable.NewRow();
            combineTable.Rows.Add(newRow);

            try
            {
                combineTable.Rows[0][0] = weigOutTable.Rows[0][0];
                combineTable.Rows[0][1] = prodTable.Rows[0][0];
                combineTable.Rows[0][2] = weigOutTable.Rows[0][1];
                combineTable.Rows[0][3] = weigOutTable.Rows[0][2];
                combineTable.Rows[0][4] = weigOutTable.Rows[0][3];
                combineTable.Rows[0][5] = weigOutTable.Rows[0][4];
                combineTable.Rows[0][6] = weigOutTable.Rows[0][5];
                combineTable.Rows[0][7] = weigOutTable.Rows[0][6];
                combineTable.Rows[0][8] = weigOutTable.Rows[0][7];
                combineTable.Rows[0][9] = weigOutTable.Rows[0][8];
            }
            catch(Exception ex)
            {
                throw new Exception($"DataTableManagement.CombineWeigOutProd - {ex.Message}");
            }

            return combineTable;
        }

        public static DataTable CombineSampleProd(DataTable sampleTable, DataTable prodTable)
        {
            DataTable combineTable = new DataTable();

            combineTable.Columns.Add(sampleTable.Columns[0].ColumnName, sampleTable.Columns[0].DataType);
            combineTable.Columns.Add(prodTable.Columns[0].ColumnName, prodTable.Columns[0].DataType);
            combineTable.Columns.Add(sampleTable.Columns[1].ColumnName, sampleTable.Columns[1].DataType);
            combineTable.Columns.Add(sampleTable.Columns[2].ColumnName, sampleTable.Columns[2].DataType);
            combineTable.Columns.Add(sampleTable.Columns[3].ColumnName, sampleTable.Columns[3].DataType);
            combineTable.Columns.Add(sampleTable.Columns[4].ColumnName, sampleTable.Columns[4].DataType);

            DataRow newRow = combineTable.NewRow();
            combineTable.Rows.Add(newRow);

            try
            {
                combineTable.Rows[0][0] = sampleTable.Rows[0][0];
                combineTable.Rows[0][1] = prodTable.Rows[0][0];
                combineTable.Rows[0][2] = sampleTable.Rows[0][1];
                combineTable.Rows[0][3] = sampleTable.Rows[0][2];
                combineTable.Rows[0][4] = sampleTable.Rows[0][3];
                combineTable.Rows[0][5] = sampleTable.Rows[0][4];
            }
            catch(Exception ex)
            {
                throw new Exception($"DataTableManagement.CombineSampleProd - {ex.Message}");
            }

            return combineTable;
        }

        public static DataTable CombineScrapProd(DataTable scrapTable, DataTable prodTable)
        {
            DataTable combineTable = new DataTable();

            combineTable.Columns.Add(scrapTable.Columns[0].ColumnName, scrapTable.Columns[0].DataType);
            combineTable.Columns.Add(prodTable.Columns[0].ColumnName, prodTable.Columns[0].DataType);
            combineTable.Columns.Add(scrapTable.Columns[1].ColumnName, scrapTable.Columns[1].DataType);
            combineTable.Columns.Add(scrapTable.Columns[2].ColumnName, scrapTable.Columns[2].DataType);
            combineTable.Columns.Add(scrapTable.Columns[3].ColumnName, scrapTable.Columns[3].DataType);
            combineTable.Columns.Add(scrapTable.Columns[4].ColumnName, scrapTable.Columns[4].DataType);
            combineTable.Columns.Add(scrapTable.Columns[5].ColumnName, scrapTable.Columns[5].DataType);
            combineTable.Columns.Add(scrapTable.Columns[6].ColumnName, scrapTable.Columns[6].DataType);
            combineTable.Columns.Add(scrapTable.Columns[7].ColumnName, scrapTable.Columns[7].DataType);

            DataRow newRow = combineTable.NewRow();
            combineTable.Rows.Add(newRow);

            try
            {
                combineTable.Rows[0][0] = scrapTable.Rows[0][0];
                combineTable.Rows[0][1] = prodTable.Rows[0][0];
                combineTable.Rows[0][2] = scrapTable.Rows[0][1];
                combineTable.Rows[0][3] = scrapTable.Rows[0][2];
                combineTable.Rows[0][4] = scrapTable.Rows[0][3];
                combineTable.Rows[0][5] = scrapTable.Rows[0][4];
                combineTable.Rows[0][6] = scrapTable.Rows[0][5];
                combineTable.Rows[0][7] = scrapTable.Rows[0][6];
                combineTable.Rows[0][8] = scrapTable.Rows[0][7];
            }
            catch(Exception ex)
            {
                throw new Exception($"DataTableManagement.CombineScrapProd - {ex.Message}");
            }

            return combineTable;
        }

        public static DataTable CombineBoxWoutReport(DataTable boxTable, DataTable prodTable)
        {
            DataTable combineTable = new DataTable();

            combineTable.Columns.Add(boxTable.Columns[0].ColumnName, boxTable.Columns[0].DataType);
            combineTable.Columns.Add(prodTable.Columns[0].ColumnName, prodTable.Columns[0].DataType);
            combineTable.Columns.Add(boxTable.Columns[1].ColumnName, boxTable.Columns[1].DataType);
            combineTable.Columns.Add(boxTable.Columns[2].ColumnName, boxTable.Columns[2].DataType);
            combineTable.Columns.Add(boxTable.Columns[3].ColumnName, boxTable.Columns[3].DataType);
            combineTable.Columns.Add(boxTable.Columns[4].ColumnName, boxTable.Columns[4].DataType);
            combineTable.Columns.Add(boxTable.Columns[5].ColumnName, boxTable.Columns[5].DataType);
            combineTable.Columns.Add(boxTable.Columns[6].ColumnName, boxTable.Columns[6].DataType);
            combineTable.Columns.Add(boxTable.Columns[7].ColumnName, boxTable.Columns[7].DataType);
            combineTable.Columns.Add(boxTable.Columns[8].ColumnName, boxTable.Columns[8].DataType);
            combineTable.Columns.Add("Type");

            DataRow newRow = combineTable.NewRow();
            combineTable.Rows.Add(newRow);

            try
            {
                combineTable.Rows[0][0] = boxTable.Rows[0][0];
                combineTable.Rows[0][1] = prodTable.Rows[0][0];
                combineTable.Rows[0][2] = boxTable.Rows[0][1];
                combineTable.Rows[0][3] = boxTable.Rows[0][2];
                combineTable.Rows[0][4] = boxTable.Rows[0][3];
                combineTable.Rows[0][5] = boxTable.Rows[0][4];
                combineTable.Rows[0][6] = boxTable.Rows[0][5];
                combineTable.Rows[0][7] = boxTable.Rows[0][6];
                combineTable.Rows[0][8] = boxTable.Rows[0][7];
                combineTable.Rows[0][9] = boxTable.Rows[0][8];
                combineTable.Rows[0][10] = "Box";
            }
            catch (Exception ex)
            {
                throw new Exception($"DataTableManagement.CombineBoxWoutReport - {ex.Message}");
            }

            return combineTable;
        }

        public static DataTable CombineSampleWoutReport(DataTable sampleTable, DataTable prodTable)
        {
            DataTable combineTable = new DataTable();

            combineTable.Columns.Add(sampleTable.Columns[0].ColumnName, sampleTable.Columns[0].DataType);
            combineTable.Columns.Add(prodTable.Columns[0].ColumnName, prodTable.Columns[0].DataType);
            combineTable.Columns.Add("Num");
            combineTable.Columns.Add(sampleTable.Columns[1].ColumnName, sampleTable.Columns[1].DataType);
            combineTable.Columns.Add(sampleTable.Columns[2].ColumnName, sampleTable.Columns[2].DataType);
            combineTable.Columns.Add(sampleTable.Columns[3].ColumnName, sampleTable.Columns[3].DataType);
            combineTable.Columns.Add("Poids cerclé (g)", typeof(Single));
            combineTable.Columns.Add("Num Plomb A");
            combineTable.Columns.Add("Num Plomb B");
            combineTable.Columns.Add(sampleTable.Columns[4].ColumnName, sampleTable.Columns[4].DataType);
            combineTable.Columns.Add("Type");

            DataRow newRow = combineTable.NewRow();
            combineTable.Rows.Add(newRow);

            try
            {
                combineTable.Rows[0][0] = sampleTable.Rows[0][0];
                combineTable.Rows[0][1] = prodTable.Rows[0][0];
                combineTable.Rows[0][2] = "";
                combineTable.Rows[0][3] = sampleTable.Rows[0][1];
                combineTable.Rows[0][4] = sampleTable.Rows[0][2];
                combineTable.Rows[0][5] = sampleTable.Rows[0][3];
                combineTable.Rows[0][6] = 0;
                combineTable.Rows[0][7] = "";
                combineTable.Rows[0][8] = "";
                combineTable.Rows[0][9] = sampleTable.Rows[0][4];
                combineTable.Rows[0][10] = "Échantillon";
            }
            catch (Exception ex)
            {
                throw new Exception($"DataTableManagement.CombineSampleWoutReport - {ex.Message}");
            }

            return combineTable;
        }

        public static DataTable CombineScrapWoutReport(DataTable scrapleTable, DataTable prodTable)
        {
            DataTable combineTable = new DataTable();

            combineTable.Columns.Add(scrapleTable.Columns[0].ColumnName, scrapleTable.Columns[0].DataType);
            combineTable.Columns.Add(prodTable.Columns[0].ColumnName, prodTable.Columns[0].DataType);
            combineTable.Columns.Add(scrapleTable.Columns[1].ColumnName, scrapleTable.Columns[1].DataType);
            combineTable.Columns.Add(scrapleTable.Columns[2].ColumnName, scrapleTable.Columns[2].DataType);
            combineTable.Columns.Add(scrapleTable.Columns[3].ColumnName, scrapleTable.Columns[3].DataType);
            combineTable.Columns.Add(scrapleTable.Columns[4].ColumnName, scrapleTable.Columns[4].DataType);
            combineTable.Columns.Add(scrapleTable.Columns[5].ColumnName, scrapleTable.Columns[5].DataType);
            combineTable.Columns.Add(scrapleTable.Columns[6].ColumnName, scrapleTable.Columns[6].DataType);
            combineTable.Columns.Add("Num Plomb B");
            combineTable.Columns.Add(scrapleTable.Columns[7].ColumnName, scrapleTable.Columns[7].DataType);
            combineTable.Columns.Add("Type");

            DataRow newRow = combineTable.NewRow();
            combineTable.Rows.Add(newRow);

            try
            {
                combineTable.Rows[0][0] = scrapleTable.Rows[0][0];
                combineTable.Rows[0][1] = prodTable.Rows[0][0];
                combineTable.Rows[0][2] = scrapleTable.Rows[0][1];
                combineTable.Rows[0][3] = scrapleTable.Rows[0][2];
                combineTable.Rows[0][4] = scrapleTable.Rows[0][3];
                combineTable.Rows[0][5] = scrapleTable.Rows[0][4];
                combineTable.Rows[0][6] = scrapleTable.Rows[0][5]; ;
                combineTable.Rows[0][7] = scrapleTable.Rows[0][6]; ;
                combineTable.Rows[0][8] = "";
                combineTable.Rows[0][9] = scrapleTable.Rows[0][7];
                combineTable.Rows[0][10] = "Dechet";
            }
            catch (Exception ex)
            {
                throw new Exception($"DataTableManagement.CombineScrapWoutReport - {ex.Message}");
            }

            return combineTable;
        }

        public static void MergeTables(DataTable origTable, DataTable dataTable)
        {
            if (origTable.Columns.Count == 0)
            {
                foreach(DataColumn col in dataTable.Columns)
                {
                    origTable.Columns.Add(col.ColumnName, col.DataType);
                }
            }

            if (origTable.Columns.Count == dataTable.Columns.Count)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    DataRow newRow = origTable.NewRow();
                    newRow.ItemArray = row.ItemArray;
                    origTable.Rows.Add(newRow);
                }
            }
            else
            {
                throw new Exception("DataTableManagement.MergeTables - Table's columns are not equal");
            }
        }
    }
}
