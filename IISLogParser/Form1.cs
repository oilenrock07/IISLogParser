using CsvHelper;
using CsvHelper.Configuration;
using IISLogParser.Models;
using System.Globalization;

namespace IISLogParser
{
    public partial class Form1 : Form
    {
        private List<IISLog> _logs = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadCsv()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                WhiteSpaceChars = new[] { '•' },
                BadDataFound = null,
                Delimiter = " ",
                MissingFieldFound = null
            };

            using var reader = new StreamReader(FileBox.Text);
            using var csv = new CsvReader(reader, config);
            csv.Context.RegisterClassMap<IISLogMap>();
            
            //skip the first 4 rows
            for (var i = 0; i < 4; i++)
                csv.Read();

            var data = csv.GetRecords<IISLog>();
            if (ChkServerFocus.Checked)
            {
                data = data.Where(x => !x.ClientUriStem.EndsWith(".js") &&
                                       !x.ClientUriStem.EndsWith(".css") &&
                                       !x.ClientUriStem.EndsWith(".png") &&
                                       !x.ClientUriStem.EndsWith(".jpg") &&
                                       !x.ClientUriStem.EndsWith(".gif") &&
                                       !x.ClientUriStem.EndsWith(".woff2") &&
                                       !x.ClientUriStem.EndsWith(".woff") &&
                                       !x.ClientUriStem.EndsWith(".svg") &&
                                       !x.ClientUriStem.EndsWith(".ico"));
            }

            _logs = data.ToList();
        }

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;
            Search();
        }

        private void FileBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;

            LoadCsv();
            MainGrid.DataSource = _logs;
        }

        private void FileBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null)
                return;

            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Any())
                FileBox.Text = files.First();
        }

        private void FileBox_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainGrid.AutoGenerateColumns = false;
            MainGrid.DataSource = _logs;
            FileBox.Focus();
        }

        private void Search()
        {
            var searchResult = _logs.Where(x => x.ClientUriQuery.Contains(SearchBox.Text, StringComparison.OrdinalIgnoreCase) ||
                                                x.ClientUriStem.Contains(SearchBox.Text, StringComparison.OrdinalIgnoreCase) ||
                                                x.ClientReferer.Contains(SearchBox.Text, StringComparison.OrdinalIgnoreCase) ||
                                                x.ClientUserName.Contains(SearchBox.Text, StringComparison.OrdinalIgnoreCase) || 
                                                x.ClientIp == SearchBox.Text);
            if (ChkTimeStart.Checked)
                searchResult = searchResult.Where(x => x.Time.ToTimeSpan() >= TimeStart.Value.TimeOfDay);
            if (ChkTimeEnd.Checked)
                searchResult = searchResult.Where(x => x.Time.ToTimeSpan() <= TimeEnd.Value.TimeOfDay);

            MainGrid.DataSource = searchResult.ToList();
        }

        private void BtnApplyTimeFilter_Click_1(object sender, EventArgs e)
        {
            Search();
        }

        private void MenuBar_Click(object sender, EventArgs e)
        {

        }
    }
}