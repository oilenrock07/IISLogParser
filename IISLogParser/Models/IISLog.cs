namespace IISLogParser.Models
{
    public class IISLog
    {
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string ServerIpAddress { get; set; }
        public string ClientMethod { get; set; }
        public string ClientUriStem { get; set; }
        public string ClientUriQuery { get; set; }
        public string ServerPort { get; set; }
        public string ClientUserName { get; set; }
        public string ClientIp { get; set; }
        public string ServerUserAgent { get; set; }
        public string ClientReferer { get; set; }
        public string ScStatus { get; set; }
        public string ScSubStatus { get; set; }
        public string ScWin32Status { get; set; }
        public string TimeTaken { get; set; }
        public string XForwardedFor { get; set; }
    }
}
