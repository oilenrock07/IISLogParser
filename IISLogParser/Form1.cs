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
                MissingFieldFound = null,
                
            };

            using var reader = new StreamReader(FileBox.Text);
            using var csv = new CsvReader(reader, config);
            csv.Context.RegisterClassMap<IISLogMap>();
            
            //skip the first 4 rows
            for (var i = 0; i < 4; i++)
                csv.Read();

            _logs = csv.GetRecords<IISLog>().ToList();
        }

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;

            var searchResult = _logs.Where(x => x.ClientUriQuery.Contains(SearchBox.Text) ||
                                                x.ClientUriStem.Contains(SearchBox.Text) ||
                                                x.ClientReferer.Contains(SearchBox.Text) ||
                                                x.ClientUserName.Contains(SearchBox.Text)).ToList();

            MainGrid.DataSource = searchResult;
        }

        private void FileBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadButton_Click(sender, e);
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

        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadCsv();
            MainGrid.DataSource = _logs;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainGrid.AutoGenerateColumns = true;
            MainGrid.DataSource = _logs;
            FileBox.Focus();
        }
    }
}