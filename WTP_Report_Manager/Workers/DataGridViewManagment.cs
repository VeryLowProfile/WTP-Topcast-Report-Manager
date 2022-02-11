using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

namespace WTP_Report_Manager.Workers
{
    static public class DataGridViewManagment
    {
        public static DataTable GetDataTableFromDataGrid(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.Name);
            }

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataTable.Rows.Add();

                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    dataTable.Rows[i][j] = dataGridView.Rows[i].Cells[j].Value;
                }
            }

            return dataTable;
        }

        public static DataTable GetSelectedDatagridRows(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.Name);
            }

            for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
            {
                dataTable.Rows.Add();

                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    dataTable.Rows[i][j] = dataGridView.SelectedRows[i].Cells[j].Value;
                }
            }

            return dataTable;
        }

        public static List<string> GetListFromDatagridSelectedRowCol(DataGridView dataGridView, int colIndex)
        {
            List<string> selectedValuesList = new List<string>();

            foreach (DataGridViewRow selectedRow in dataGridView.SelectedRows)
            {
                selectedValuesList.Add(dataGridView.Rows[selectedRow.Index].Cells[colIndex].Value.ToString());
            }

            return selectedValuesList;
        }
    }
}
