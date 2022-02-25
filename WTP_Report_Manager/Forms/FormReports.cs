using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using WTP_Report_Manager.Workers;

namespace WTP_Report_Manager.Forms
{
    public partial class FormReports : Form
    {

        public FormReports()
        {
            InitializeComponent();
        }

        private void FormReports_Load(object sender, EventArgs e)
        {
            WTP_Report_Manager.visualizationData.ShowReportID.Clear();
            WTP_Report_Manager.visualizationData.ShowReportID.AddRange(WTP_Report_Manager.SelectedData.SelectedIDs.ToArray());

            listBoxShow.Items.AddRange(WTP_Report_Manager.visualizationData.ShowReportID.ToArray());
            listBoxHide.Update();

            if (WTP_Report_Manager.visualizationData.ShowReportID.Count == 0)
            {
                buttonSub.Visible = false;
                buttonSubAll.Visible = false;
                buttonPrintReport.Visible = false;
            }

            checkBoxInData.Checked = true;
            checkBoxOutData.Checked = true;
            checkBoxResume.Checked = true;
            checkBoxCountersData.Checked = true;

            textBoxFilePath.Text = WTP_Report_Manager.AppConfig.SaveFilePath;

            labelDeletePath.Text = WTP_Report_Manager.AppConfig.SaveFilePath;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBoxHide.SelectedItem != null)
            {
                WTP_Report_Manager.visualizationData.MoveIdHideToShow(listBoxHide.SelectedItem.ToString());
                listBoxHide.Items.Clear();
                listBoxHide.Items.AddRange(WTP_Report_Manager.visualizationData.HideReportID.ToArray());
                listBoxShow.Items.Clear();
                listBoxShow.Items.AddRange(WTP_Report_Manager.visualizationData.ShowReportID.ToArray());
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
                buttonPrintReport.Visible = false;
            }
            else
            {
                buttonSub.Visible = true;
                buttonSubAll.Visible = true;
                buttonPrintReport.Visible = true;
            }
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (listBoxShow.SelectedItem != null)
            {
                WTP_Report_Manager.visualizationData.MoveIdShowToHide(listBoxShow.SelectedItem.ToString());
                listBoxHide.Items.Clear();
                listBoxHide.Items.AddRange(WTP_Report_Manager.visualizationData.HideReportID.ToArray());
                listBoxShow.Items.Clear();
                listBoxShow.Items.AddRange(WTP_Report_Manager.visualizationData.ShowReportID.ToArray());
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
                buttonPrintReport.Visible = false;
            }
            else
            {
                buttonSub.Visible = true;
                buttonSubAll.Visible = true;
                buttonPrintReport.Visible = true;
            }
        }

        private void buttonAddAll_Click(object sender, EventArgs e)
        {
            WTP_Report_Manager.visualizationData.IdShowAll();
            listBoxHide.Items.Clear();
            listBoxHide.Items.AddRange(WTP_Report_Manager.visualizationData.HideReportID.ToArray());
            listBoxShow.Items.Clear();
            listBoxShow.Items.AddRange(WTP_Report_Manager.visualizationData.ShowReportID.ToArray());


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
                buttonPrintReport.Visible = false;
            }
            else
            {
                buttonSub.Visible = true;
                buttonSubAll.Visible = true;
                buttonPrintReport.Visible = true;
            }
        }

        private void buttonSubAll_Click(object sender, EventArgs e)
        {
            WTP_Report_Manager.visualizationData.IdHideAll();
            listBoxHide.Items.Clear();
            listBoxHide.Items.AddRange(WTP_Report_Manager.visualizationData.HideReportID.ToArray());
            listBoxShow.Items.Clear();
            listBoxShow.Items.AddRange(WTP_Report_Manager.visualizationData.ShowReportID.ToArray());


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
                buttonPrintReport.Visible = false;
            }
            else
            {
                buttonSub.Visible = true;
                buttonSubAll.Visible = true;
                buttonPrintReport.Visible = true;
            }
        }

        private void buttonSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = folderBrowserDialog.SelectedPath;
                labelDeletePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private async void buttonPrintReport_Click(object sender, EventArgs e)
        {
            calculateProgrssBar();


            List<Task> tasks = new List<Task>();

            if (checkBoxInData.Checked)
            {
                tasks.Add(Task.Run(() => weighInReport()));
            }

            if (checkBoxOutData.Checked)
            {
                tasks.Add(Task.Run(() => weighOutReport()));
            }

            if (checkBoxResume.Checked)
            {
                tasks.Add(Task.Run(() => resumeReport()));
            }

            if (checkBoxCountersData.Checked)
            {
                tasks.Add(Task.Run(() => countersReport()));
            }

            if (checkBoxMsgData.Checked)
            {
                tasks.Add(Task.Run(() => msgReport()));
            }

            if (checkBoxEventData.Checked)
            {
                tasks.Add(Task.Run(() => eventReport()));
            }

            if (checkBoxTrendData.Checked)
            {
                tasks.Add(Task.Run(() => trendReport()));
            }

            await Task.WhenAll(tasks);

            progressBar.Invoke(new Action(() => progressBar.Value = 0));
            MessageBox.Show("Print Done");

        }

        private void buttonDeleteOld_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure to delete all files in\n{textBoxFilePath.Text} ?", "Confirm delete operation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DirectoryInfo directory = new DirectoryInfo(textBoxFilePath.Text);

                foreach (FileInfo file in directory.EnumerateFiles())
                {
                    if (file.Name.Contains(".csv"))
                    {
                        file.Delete();
                    }
                }
            }
        }

        private void weighInReport()
        {
            string fileName = textBoxFilePath.Text + $"\\{DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")}_Weighing_In.csv";
            DataTable finalTable = new DataTable();

            foreach (string id in WTP_Report_Manager.visualizationData.ShowReportID)
            {

                string prodQry = SqlQryBuilder.BuildProdQry(id);
                DataTable prodTable = new DataTable();

                try
                {
                    prodTable = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, prodQry);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                for (int i = 1; i <= 3; i++)
                {
                    string wInBoxQry = SqlQryBuilder.BuildWinBoxQry(id, i);

                    DataTable weigInTable = new DataTable();

                    try
                    {
                        weigInTable = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, wInBoxQry);
                    }
                    catch (Exception ex)
                    {

                        richTextBoxLog.Invoke(new Action(() => {

                            richTextBoxLog.SelectionColor = Color.Green;
                            richTextBoxLog.AppendText(ex.Message + "\n");
                            richTextBoxLog.ScrollToCaret();

                        }));
                    }

                    try
                    {
                        DataTableManagement.MergeTables(finalTable, DataTableManagement.CombineWeigInProd(weigInTable, prodTable));
                    }
                    catch (Exception ex)
                    {
                        richTextBoxLog.Invoke(new Action(() => {

                            richTextBoxLog.SelectionColor = Color.Green;
                            richTextBoxLog.AppendText(ex.Message + "\n");
                            richTextBoxLog.ScrollToCaret();

                        }));
                    }
                }

                progressBar.Invoke(new Action(() => progressBar.Increment(1)));
                richTextBoxLog.Invoke(new Action(() => {

                    richTextBoxLog.SelectionColor = Color.Green;
                    richTextBoxLog.AppendText($"Fetched WEIGH IN data for {id} Done \n");
                    richTextBoxLog.ScrollToCaret();

                }));

            }

            ExportManagement.ExportDataTableToCSV(finalTable, fileName, ";");

            richTextBoxLog.Invoke(new Action(() => {

                richTextBoxLog.SelectionColor = Color.Green;
                richTextBoxLog.AppendText($"WEIGH IN report Done \n");
                richTextBoxLog.ScrollToCaret();

            }));

        }

        private void weighOutReport()
        {
            string fileName = textBoxFilePath.Text + $"\\{DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")}_Weighing_Out.csv";

            DataTable finalTable = new DataTable();

            foreach (string id in WTP_Report_Manager.visualizationData.ShowReportID)
            {
                string prodQry = SqlQryBuilder.BuildProdQry(id);
                string wOutBox1Qry = SqlQryBuilder.BuildReportWoutBoxQry(id, 1);
                string wOutBox2Qry = SqlQryBuilder.BuildReportWoutBoxQry(id, 2);
                string wOutBox3Qry = SqlQryBuilder.BuildReportWoutBoxQry(id, 3);
                string sampleQry = SqlQryBuilder.BuildReportSampleQry(id);
                string scrapQry = SqlQryBuilder.BuildReportScrapQry(id);

                DataTable prodTable = new DataTable();
                DataTable wOutBox1Table = new DataTable();
                DataTable wOutBox2Table = new DataTable();
                DataTable wOutBox3Table = new DataTable();
                DataTable sampletable = new DataTable();
                DataTable scrapTable = new DataTable();

                try
                {
                    prodTable = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, prodQry);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.DarkGreen;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                try
                {
                    wOutBox1Table = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, wOutBox1Qry);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.DarkGreen;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                try
                {
                    wOutBox1Table = DataTableManagement.CombineBoxWoutReport(wOutBox1Table, prodTable);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.DarkGreen;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                try
                {
                    DataTableManagement.MergeTables(finalTable, wOutBox1Table);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.DarkGreen;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                try
                {
                    wOutBox2Table = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, wOutBox2Qry);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.DarkGreen;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                try
                {
                    wOutBox2Table = DataTableManagement.CombineBoxWoutReport(wOutBox2Table, prodTable);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.DarkGreen;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                try
                {
                    DataTableManagement.MergeTables(finalTable, wOutBox2Table);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.DarkGreen;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                try
                {
                    wOutBox3Table = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, wOutBox3Qry);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.DarkGreen;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                try
                {
                    wOutBox3Table = DataTableManagement.CombineBoxWoutReport(wOutBox3Table, prodTable);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.DarkGreen;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                try
                {
                    DataTableManagement.MergeTables(finalTable, wOutBox3Table);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.DarkGreen;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                try
                {
                    sampletable = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, sampleQry);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.DarkGreen;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                try
                {
                    sampletable = DataTableManagement.CombineSampleWoutReport(sampletable, prodTable);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.DarkGreen;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                try
                {
                    DataTableManagement.MergeTables(finalTable, sampletable);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.DarkGreen;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                try
                {
                    scrapTable = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, scrapQry);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.DarkGreen;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                try
                {
                    scrapTable = DataTableManagement.CombineScrapWoutReport(scrapTable, prodTable);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.DarkGreen;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                try
                {
                    DataTableManagement.MergeTables(finalTable, scrapTable);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.DarkGreen;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                progressBar.Invoke(new Action(() => progressBar.Increment(1)));
                richTextBoxLog.Invoke(new Action(() => {

                    richTextBoxLog.SelectionColor = Color.DarkGreen;
                    richTextBoxLog.AppendText($"Fetched WEIGH OUT data for {id} Done \n");
                    richTextBoxLog.ScrollToCaret();

                }));

            }

            ExportManagement.ExportDataTableToCSV(finalTable, fileName, ";");

            richTextBoxLog.Invoke(new Action(() => {

                richTextBoxLog.SelectionColor = Color.DarkGreen;
                richTextBoxLog.AppendText($"WEIGH OUT report Done \n");
                richTextBoxLog.ScrollToCaret();

            }));
        }

        private void resumeReport()
        {
            string fileName = textBoxFilePath.Text + $"\\{DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")}_Resume.csv";

            DataTable finalTable = new DataTable();

            foreach (string id in WTP_Report_Manager.visualizationData.ShowReportID)
            {
                string resumeQry = SqlQryBuilder.BuildResumeQry(id);
                DataTable resumeTable = new DataTable();

                try
                {
                    resumeTable = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, resumeQry);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.Olive;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                try
                {
                    DataTableManagement.MergeTables(finalTable, resumeTable);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.Olive;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                progressBar.Invoke(new Action(() => progressBar.Increment(1)));
                richTextBoxLog.Invoke(new Action(() => {

                    richTextBoxLog.SelectionColor = Color.Olive;
                    richTextBoxLog.AppendText($"Fetched RESUME data for {id} Done \n");
                    richTextBoxLog.ScrollToCaret();

                }));

            }

            ExportManagement.ExportDataTableToCSV(finalTable, fileName, ";");

            richTextBoxLog.Invoke(new Action(() => {

                richTextBoxLog.SelectionColor = Color.Olive;
                richTextBoxLog.AppendText($"RESUME report Done \n");
                richTextBoxLog.ScrollToCaret();

            }));
        }

        private void countersReport()
        {
            string fileName = textBoxFilePath.Text + $"\\{DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")}_Counters.csv";

            DataTable finalTable = new DataTable();

            foreach (string id in WTP_Report_Manager.visualizationData.ShowReportID)
            {
                string countersQry = SqlQryBuilder.BuildCountersQry(id);
                DataTable countersTable = new DataTable();

                try
                {
                    countersTable = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, countersQry);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.DarkOliveGreen;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                try
                {
                    DataTableManagement.MergeTables(finalTable, countersTable);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.DarkOliveGreen;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                progressBar.Invoke(new Action(() => progressBar.Increment(1)));
                richTextBoxLog.Invoke(new Action(() => {

                    richTextBoxLog.SelectionColor = Color.DarkOliveGreen;
                    richTextBoxLog.AppendText($"Fetched COUNTERS data for {id} Done \n");
                    richTextBoxLog.ScrollToCaret();

                }));

            }

            ExportManagement.ExportDataTableToCSV(finalTable, fileName, ";");

            richTextBoxLog.Invoke(new Action(() => {

                richTextBoxLog.SelectionColor = Color.DarkOliveGreen;
                richTextBoxLog.AppendText($"COUNTERS report Done \n");
                richTextBoxLog.ScrollToCaret();

            }));
        }

        private void msgReport()
        {
            foreach (string id in WTP_Report_Manager.visualizationData.ShowReportID)
            {
                string fileName = textBoxFilePath.Text + $"\\OF_{id}_Msg.csv";
                string msgQry = SqlQryBuilder.BuildMsgQry(id);
                DataTable dataTable = new DataTable();

                try
                {
                    dataTable = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, msgQry);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.Coral;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                progressBar.Invoke(new Action(() => progressBar.Increment(1)));
                richTextBoxLog.Invoke(new Action(() => {

                    richTextBoxLog.SelectionColor = Color.Coral;
                    richTextBoxLog.AppendText($"Fetched MSG data for {id} Done \n");
                    richTextBoxLog.ScrollToCaret();

                }));

                ExportManagement.ExportDataTableToCSV(dataTable, fileName, ";");

                richTextBoxLog.Invoke(new Action(() => {

                    richTextBoxLog.SelectionColor = Color.Coral;
                    richTextBoxLog.AppendText($"MSG report for {id} Done \n");
                    richTextBoxLog.ScrollToCaret();

                }));

            }
        }

        private void eventReport()
        {
            foreach (string id in WTP_Report_Manager.visualizationData.ShowReportID)
            {
                string fileName = textBoxFilePath.Text + $"\\OF_{id}_Events.csv";
                string eventQry = SqlQryBuilder.BuildEventsQry(id);
                DataTable dataTable = new DataTable();

                try
                {
                    dataTable = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, eventQry);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.Teal;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                progressBar.Invoke(new Action(() => progressBar.Increment(1)));
                richTextBoxLog.Invoke(new Action(() => {

                    richTextBoxLog.SelectionColor = Color.Teal;
                    richTextBoxLog.AppendText($"Fetched EVENT data for {id} Done \n");
                    richTextBoxLog.ScrollToCaret();

                }));

                ExportManagement.ExportDataTableToCSV(dataTable, fileName, ";");

                richTextBoxLog.Invoke(new Action(() => {

                    richTextBoxLog.SelectionColor = Color.Teal;
                    richTextBoxLog.AppendText($"EVENT report for {id} Done \n");
                    richTextBoxLog.ScrollToCaret();

                }));

            }
        }

        private void trendReport()
        {
            foreach (string id in WTP_Report_Manager.visualizationData.ShowReportID)
            {
                string fileName = textBoxFilePath.Text + $"\\OF_{id}_Trends_Data.csv";
                string plotQry = SqlQryBuilder.BuildPlotQry(id, WTP_Report_Manager.AppConfig.PlotVar.Var);
                DataTable dataTable = new DataTable();

                try
                {
                    dataTable = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, plotQry);
                }
                catch (Exception ex)
                {
                    richTextBoxLog.Invoke(new Action(() => {

                        richTextBoxLog.SelectionColor = Color.MediumPurple;
                        richTextBoxLog.AppendText(ex.Message + "\n");
                        richTextBoxLog.ScrollToCaret();

                    }));
                }

                progressBar.Invoke(new Action(() => progressBar.Increment(1)));
                richTextBoxLog.Invoke(new Action(() => {

                    richTextBoxLog.SelectionColor = Color.MediumPurple;
                    richTextBoxLog.AppendText($"Fetched TREND data for {id} Done \n");
                    richTextBoxLog.ScrollToCaret();

                }));

                ExportManagement.ExportDataTableToCSV(dataTable, fileName, ";");

                richTextBoxLog.Invoke(new Action(() => {

                    richTextBoxLog.SelectionColor = Color.MediumPurple;
                    richTextBoxLog.AppendText($"TREND report for {id} Done \n");
                    richTextBoxLog.ScrollToCaret();

                }));

            }
        }

        private void calculateProgrssBar()
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = 0;
            
            if (checkBoxInData.Checked)
            {
                progressBar.Maximum += WTP_Report_Manager.visualizationData.ShowReportID.Count;
            }
            if (checkBoxOutData.Checked)
            {
                progressBar.Maximum += WTP_Report_Manager.visualizationData.ShowReportID.Count;
            }
            if (checkBoxResume.Checked)
            {
                progressBar.Maximum += WTP_Report_Manager.visualizationData.ShowReportID.Count;
            }
            if (checkBoxCountersData.Checked)
            {
                progressBar.Maximum += WTP_Report_Manager.visualizationData.ShowReportID.Count;
            }
            if (checkBoxMsgData.Checked)
            {
                progressBar.Maximum += WTP_Report_Manager.visualizationData.ShowReportID.Count;
            }
            if (checkBoxEventData.Checked)
            {
                progressBar.Maximum += WTP_Report_Manager.visualizationData.ShowReportID.Count;
            }
            if (checkBoxTrendData.Checked)
            {
                progressBar.Maximum += WTP_Report_Manager.visualizationData.ShowReportID.Count;
            }
        }

    }
}
