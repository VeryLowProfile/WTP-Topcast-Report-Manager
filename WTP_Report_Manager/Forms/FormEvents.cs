using System;
using System.Data;
using System.Windows.Forms;
using WTP_Report_Manager.Workers;

namespace WTP_Report_Manager.Forms
{
    public partial class FormEvents : Form
    {
        public FormEvents()
        {
            InitializeComponent();
        }

        private void FormEvents_Load(object sender, EventArgs e)
        {
            comboBoxIDList.Items.AddRange(WTP_Report_Manager.SelectedData.SelectedIDs.ToArray());
            comboBoxIDList.Text = comboBoxIDList.Items[0].ToString();
        }

        private void buttonShowEvents_Click(object sender, EventArgs e)
        {
            string msgQry = SqlQryBuilder.BuildMsgQry(comboBoxIDList.Text);
            string eventQry = SqlQryBuilder.BuildEventsQry(comboBoxIDList.Text);

            DataTable msgTable = new DataTable();
            DataTable eventTable = new DataTable();

            try
            {
                msgTable = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, msgQry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            dataGridViewMsg.DataSource = msgTable;
            dataGridViewMsg.Update();

            try
            {
                eventTable = SqlManagment.SqlExecuteQuery(WTP_Report_Manager.AppConfig.SqlConnConfig.SqlConnectionString, eventQry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            dataGridViewEvents.DataSource = eventTable;
            dataGridViewEvents.Update();

        }
    }
}
