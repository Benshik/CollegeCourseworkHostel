using CollegeCourseworkHostel.Service;

namespace CollegeCourseworkHostel
{
    public partial class Report : DevExpress.XtraEditors.XtraForm
    {
        public Report()
        {
            InitializeComponent();
            LoadReportData();
        }

        private void LoadReportData()
        {
            SQLAdapter sqAdapter = new SQLAdapter();
           // bsReport.DataSource = sqAdapter.SelectData(Query.AllReservedPlaces);
        }

    }
}
