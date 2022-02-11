using System;
using System.Collections.Generic;

namespace WTP_Report_Manager.Data
{
    public class SelectedData
    {
        public List<string> SelectedIDs { get; set; }

        public SelectedData()
        {
            SelectedIDs = new List<string>();
        }
    }
}
