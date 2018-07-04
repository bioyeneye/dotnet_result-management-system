using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using LumenWorks.Framework.IO.Csv;

namespace RMS.Model
{
    public class CsvData
    {
        private string _fileSavePath;
        public CsvData(string fileSavePath)
        {
            _fileSavePath = fileSavePath;
        }
        public static IEnumerable<DataRow> GetData(string fileSavePath)
        {
            DataTable csvTable = new DataTable();
            FileStream stream = File.Open(fileSavePath, FileMode.Open, FileAccess.Read);
            using (CsvReader csvReader =
                new CsvReader(new StreamReader(stream), true))
            {
                csvTable.Load(csvReader);
                var rows = from DataRow a in csvTable.Rows select a;
                return rows;
            }
        }
    }
}