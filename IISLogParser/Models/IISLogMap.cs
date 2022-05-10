using CsvHelper.Configuration;

namespace IISLogParser.Models
{
    internal class IISLogMap : ClassMap<IISLog>
    {
        public IISLogMap()
        {
            Map(m => m.Date).Index(0);
            Map(m => m.Time).Index(1);
            Map(m => m.ServerIpAddress).Index(2);
            Map(m => m.ClientMethod).Index(3);
            Map(m => m.ClientUriStem).Index(4);
            Map(m => m.ClientUriQuery).Index(5);
            Map(m => m.ServerPort).Index(6);
            Map(m => m.ClientUserName).Index(7);
            Map(m => m.ClientIp).Index(8);
            Map(m => m.ServerUserAgent).Index(9);
            Map(m => m.ClientReferer).Index(10);
            Map(m => m.ScStatus).Index(11);
            Map(m => m.ScSubStatus).Index(12);
            Map(m => m.ScWin32Status).Index(13);
            Map(m => m.TimeTaken).Index(14);
            Map(m => m.XForwardedFor).Index(15);
        }
    }
}
