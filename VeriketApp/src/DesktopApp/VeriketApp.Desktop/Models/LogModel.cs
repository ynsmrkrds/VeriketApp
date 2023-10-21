namespace VeriketApp.Desktop.Models
{
    public class LogModel
    {
        public DateTime Date { get; set; }

        public string ComputerName { get; set; }

        public string UserName { get; set; }

        public LogModel(DateTime date, string computerName, string userName)
        {
            Date = date;
            ComputerName = computerName;
            UserName = userName;
        }
    }
}
