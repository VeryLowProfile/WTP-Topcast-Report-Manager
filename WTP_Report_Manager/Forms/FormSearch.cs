using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using WTP_Report_Manager.Workers;


namespace WTP_Report_Manager.Forms
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            datePickerFrom.Value = DateTime.Now;
            datePickerTo.Value = DateTime.Now;

            checkBoxSearchDate.Checked = false;
            checkBoxSearchID.Checked = true;

            WTP_Report_Manager.SearchParam.SearchByDate = checkBoxSearchDate.Checked;
            WTP_Report_Manager.SearchParam.SearchByID = checkBoxSearchID.Checked;

            datePickerFrom.Visible = false;
            datePickerTo.Visible = false;
            labelSearchFrom.Visible = false;
            labelSearchTo.Visible = false;

            textBoxBatchID.Visible = true;
            labelSerachID.Visible = true;
        }

        private void checkBoxSearchDate_Click(object sender, EventArgs e)
        {
            checkBoxSearchID.Checked = false;

            WTP_Report_Manager.SearchParam.SearchByDate = checkBoxSearchDate.Checked;
            WTP_Report_Manager.SearchParam.SearchByID = checkBoxSearchID.Checked;

            datePickerFrom.Visible = true;
            datePickerTo.Visible = true;
            labelSearchFrom.Visible = true;
            labelSearchTo.Visible = true;

            textBoxBatchID.Visible = false;
            labelSerachID.Visible = false;
        }

        private void checkBoxSearchID_Click(object sender, EventArgs e)
        {
            checkBoxSearchDate.Checked = false;

            WTP_Report_Manager.SearchParam.SearchByDate = checkBoxSearchDate.Checked;
            WTP_Report_Manager.SearchParam.SearchByID = checkBoxSearchID.Checked;

            datePickerFrom.Visible = false;
            datePickerTo.Visible = false;
            labelSearchFrom.Visible = false;
            labelSearchTo.Visible = false;

            textBoxBatchID.Visible = true;
            labelSerachID.Visible = true;
        }

        private void datePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            WTP_Report_Manager.SearchParam.SearchDateFrom = datePickerFrom.Value;
            WTP_Report_Manager.SearchParam.SearchDateFrom.AddHours(-WTP_Report_Manager.SearchParam.SearchDateFrom.Hour);
            WTP_Report_Manager.SearchParam.SearchDateFrom.AddMinutes(-WTP_Report_Manager.SearchParam.SearchDateFrom.Minute);
            WTP_Report_Manager.SearchParam.SearchDateFrom.AddSeconds(-WTP_Report_Manager.SearchParam.SearchDateFrom.Second);
            WTP_Report_Manager.SearchParam.SearchDateFrom.AddMilliseconds(-WTP_Report_Manager.SearchParam.SearchDateFrom.Millisecond);
        }

        private void datePickerTo_ValueChanged(object sender, EventArgs e)
        {
            WTP_Report_Manager.SearchParam.SearchDateTo = datePickerTo.Value;
            WTP_Report_Manager.SearchParam.SearchDateTo.AddHours(-WTP_Report_Manager.SearchParam.SearchDateTo.Hour);
            WTP_Report_Manager.SearchParam.SearchDateTo.AddMinutes(-WTP_Report_Manager.SearchParam.SearchDateTo.Minute);
            WTP_Report_Manager.SearchParam.SearchDateTo.AddSeconds(-WTP_Report_Manager.SearchParam.SearchDateTo.Second);
            WTP_Report_Manager.SearchParam.SearchDateTo.AddMilliseconds(-WTP_Report_Manager.SearchParam.SearchDateTo.Millisecond);
            WTP_Report_Manager.SearchParam.SearchDateTo.AddHours(23).AddMinutes(59).AddSeconds(59);
        }

        private void textBoxBatchID_TextChanged(object sender, EventArgs e)
        {
            WTP_Report_Manager.SearchParam.SearchID = textBoxBatchID.Text;
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            string qry = SqlQryBuilder.BuildSearchQry(WTP_Report_Manager.SearchParam);
            DataTable dataTable = new DataTable();

            try
            {
                dataTable = await SqlManagment.SqlExecuteQueryAsync(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, qry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            dataGridViewSearchResult.DataSource = dataTable;
            dataGridViewSearchResult.Update();

            WTP_Report_Manager.SelectedData.SelectedIDs.Clear();
            dataGridViewSelected.DataSource = DataGridViewManagment.GetSelectedDatagridRows(dataGridViewSearchResult);
            dataGridViewSelected.Update();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            List<string> selectedIDs = new List<string>();

            if (dataGridViewSearchResult.SelectedRows.Count > 0)
            {
                //Show Selected IDs
                dataGridViewSelected.DataSource = DataGridViewManagment.GetSelectedDatagridRows(dataGridViewSearchResult);
                dataGridViewSelected.Update();

                //Get List of Selected IDs
                selectedIDs = DataGridViewManagment.GetListFromDatagridSelectedRowCol(dataGridViewSearchResult, 0);
                WTP_Report_Manager.SelectedData.SelectedIDs = selectedIDs;
            }
            else
            {
                MessageBox.Show("No ID Selected", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
