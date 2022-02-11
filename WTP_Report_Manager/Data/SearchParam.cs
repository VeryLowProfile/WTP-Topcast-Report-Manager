using System;

namespace WTP_Report_Manager.Data
{
    public class SearchParam
    {
        public DateTime SearchDateFrom { get; set; }
        public DateTime SearchDateTo { get; set; }
        public string SearchID { get; set; }
        public bool SearchByDate { get; set; }
        public bool SearchByID { get; set; }
    }
}
