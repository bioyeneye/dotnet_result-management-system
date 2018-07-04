using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using Excel;

namespace RMS.Model
{
    public class ExcelData
    {
        string _path;

        public ExcelData(string path)
        {
            _path = path;
        }


        public IExcelDataReader GetExcelReader()
        {
            // ExcelDataReader works with the binary Excel file, so it needs a FileStream
            // to get started. This is how we avoid dependencies on ACE or Interop:
            FileStream stream = File.Open(_path, FileMode.Open, FileAccess.Read);

            // We return the interface, so that 
            IExcelDataReader reader = null;
            try
            {
                if (_path.EndsWith(".xls"))
                {
                    reader = ExcelReaderFactory.CreateBinaryReader(stream);
                }
                if (_path.EndsWith(".xlsx"))
                {
                    reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                }
                return reader;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<string> GetWorksheetNames()
        {
            var reader = this.GetExcelReader();
            var workbook = reader.AsDataSet();
            var sheets = from DataTable sheet in workbook.Tables select sheet.TableName;
            return sheets;
        }
        public IEnumerable<DataRow> GetData(string sheet, bool firstRowIsColumnNames = true)
        {
            var reader = this.GetExcelReader();
            reader.IsFirstRowAsColumnNames = firstRowIsColumnNames;
            var workSheet = reader.AsDataSet().Tables[sheet];
            foreach (DataRow a in workSheet.Rows)
                yield return a;

        }
    }
}