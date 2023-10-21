using VeriketApp.Desktop.Models;
using VeriketApp.Desktop.Utilities.Logging;
using VeriketApp.Desktop.Utilities.Logging.Concrete;

namespace VeriketApp.Desktop
{
    public partial class MainForm : Form
    {
        private readonly LogUtility _logUtility;

        public MainForm()
        {
            InitializeComponent();

            _logUtility = new LogUtility(new FileLogger());
        }

        private void GetLogsButton_Click(object sender, EventArgs e)
        {
            List<LogModel> logs = _logUtility.GetLogs();

            FillLogsDataGridView(logs);
        }

        private void FillLogsDataGridView(List<LogModel> logs)
        {
            LogsDataGridView.Rows.Clear();

            foreach (LogModel log in logs)
            {
                int index = LogsDataGridView.Rows.Add();
                var row = LogsDataGridView.Rows[index];

                row.Cells["Date"].Value = log.Date;
                row.Cells["ComputerName"].Value = log.ComputerName;
                row.Cells["UserName"].Value = log.UserName;
            }

            LogsDataGridView.ClearSelection();
        }
    }
}