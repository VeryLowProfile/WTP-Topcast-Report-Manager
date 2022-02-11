using System;
using System.Data;
using System.Windows.Forms;
using WTP_Report_Manager.Workers;

namespace WTP_Report_Manager.Forms
{
    public partial class FormResume : Form
    {
        public FormResume()
        {
            InitializeComponent();
        }

        private void FormResume_Load(object sender, EventArgs e)
        {
            comboBoxIDList.Items.AddRange(WTP_Report_Manager.SelectedData.SelectedIDs.ToArray());
            comboBoxIDList.Text = comboBoxIDList.Items[0].ToString();
        }

        private async void buttonShowResume_Click(object sender, EventArgs e)
        {

            dataGridViewResume.DataSource = null;
            dataGridViewResume.Update();

            dataGridViewBox1In.DataSource = null;
            dataGridViewBox1In.Update();

            dataGridViewBox2In.DataSource = null;
            dataGridViewBox2In.Update();

            dataGridViewBox3In.DataSource = null;
            dataGridViewBox3In.Update();

            dataGridViewBox1Out.DataSource = null;
            dataGridViewBox1Out.Update();

            dataGridViewBox2Out.DataSource = null;
            dataGridViewBox2Out.Update();

            dataGridViewBox3Out.DataSource = null;
            dataGridViewBox3Out.Update();

            dataGridViewSample.DataSource = null;
            dataGridViewSample.Update();

            dataGridViewScrap.DataSource = null;
            dataGridViewScrap.Update();

            dataGridViewCounters.DataSource = null;
            dataGridViewCounters.Update();


            string resumeQry = SqlQryBuilder.BuildResumeQry(comboBoxIDList.Text);
            string prodQry = SqlQryBuilder.BuildProdQry(comboBoxIDList.Text);
            string wInBox1Qry = SqlQryBuilder.BuildWinBoxQry(comboBoxIDList.Text, 1);
            string wInBox2Qry = SqlQryBuilder.BuildWinBoxQry(comboBoxIDList.Text, 2);
            string wInBox3Qry = SqlQryBuilder.BuildWinBoxQry(comboBoxIDList.Text, 3);

            DataTable resumeTable = new DataTable();
            DataTable prodTable = new DataTable();
            DataTable wInBox1Table = new DataTable();
            DataTable wInBox2Table = new DataTable();
            DataTable wInBox3Table = new DataTable();

            try
            {
                prodTable = await SqlManagment.SqlExecuteQueryAsync(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, prodQry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " prodQry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                resumeTable = await SqlManagment.SqlExecuteQueryAsync(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, resumeQry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " resumeQry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                wInBox1Table = await SqlManagment.SqlExecuteQueryAsync(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, wInBox1Qry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " wInBox1Qry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                wInBox2Table = await SqlManagment.SqlExecuteQueryAsync(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, wInBox2Qry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " wInBox2Qry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                wInBox3Table = await SqlManagment.SqlExecuteQueryAsync(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, wInBox3Qry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " wInBox3Qry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            string wOutBox1Qry = SqlQryBuilder.BuildWoutBoxQry(comboBoxIDList.Text, 1);
            string wOutBox2Qry = SqlQryBuilder.BuildWoutBoxQry(comboBoxIDList.Text, 2);
            string wOutBox3Qry = SqlQryBuilder.BuildWoutBoxQry(comboBoxIDList.Text, 3);

            DataTable wOutBox1Table = new DataTable();
            DataTable wOutBox2Table = new DataTable();
            DataTable wOutBox3Table = new DataTable();


            try
            {
                wOutBox1Table = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, wOutBox1Qry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " wOutBox1Qry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                wOutBox2Table = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, wOutBox2Qry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " wOutBox2Qry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                wOutBox3Table = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, wOutBox3Qry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " woutBox3Qry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            string sampleQry = SqlQryBuilder.BuildSampleQry(comboBoxIDList.Text);
            string scrapQry = SqlQryBuilder.BuildScrapQry(comboBoxIDList.Text);
            string countersQry = SqlQryBuilder.BuildCountersQry(comboBoxIDList.Text);

            DataTable sampleTable = new DataTable();
            DataTable scrapTable = new DataTable();
            DataTable countersTable = new DataTable();

            try
            {
                sampleTable = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, sampleQry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " sampleQry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                scrapTable = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, scrapQry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " scrapQry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                countersTable = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, countersQry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " countersQry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                dataGridViewResume.DataSource = resumeTable;
                dataGridViewResume.Update();

                dataGridViewBox1In.DataSource = DataTableManagement.CombineWeigInProd(wInBox1Table, prodTable);
                dataGridViewBox1In.Update();

                dataGridViewBox2In.DataSource = DataTableManagement.CombineWeigInProd(wInBox2Table, prodTable);
                dataGridViewBox2In.Update();

                dataGridViewBox3In.DataSource = DataTableManagement.CombineWeigInProd(wInBox3Table, prodTable);
                dataGridViewBox3In.Update();

                dataGridViewBox1Out.DataSource = DataTableManagement.CombineWeigOutProd(wOutBox1Table, prodTable);
                dataGridViewBox1Out.Update();

                dataGridViewBox2Out.DataSource = DataTableManagement.CombineWeigOutProd(wOutBox2Table, prodTable);
                dataGridViewBox2Out.Update();

                dataGridViewBox3Out.DataSource = DataTableManagement.CombineWeigOutProd(wOutBox3Table, prodTable);
                dataGridViewBox3Out.Update();

                dataGridViewSample.DataSource = DataTableManagement.CombineSampleProd(sampleTable, prodTable);
                dataGridViewSample.Update();

                dataGridViewScrap.DataSource = DataTableManagement.CombineScrapProd(scrapTable, prodTable);
                dataGridViewScrap.Update();

                dataGridViewCounters.DataSource = countersTable;
                dataGridViewCounters.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
