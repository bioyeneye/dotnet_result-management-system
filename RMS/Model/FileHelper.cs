using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RMS.Model
{
    public class FileHelper
    {

        public static IEnumerable<DataRow> GetDataFromFile(string fileSavePath)
        {
            try
            {
                if (fileSavePath.EndsWith(".csv"))
                {
                    return GetDataFromCsv(fileSavePath);
                }
                return GetDataFromExcel(fileSavePath);
            }
            catch (Exception ec)
            {
                throw new Exception(ec.Message);
            }

        }
        private static IEnumerable<DataRow> GetDataFromCsv(string fileSavePath)
        {
            return CsvData.GetData(fileSavePath);
        }
        private static IEnumerable<DataRow> GetDataFromExcel(string fileSavePath)
        {
            var excelData = new ExcelData(fileSavePath);
            var sheetName = excelData.GetWorksheetNames();
            var data = excelData.GetData(sheetName.First());
            return data;
        }

        public static DateTime? RetrieveDate(DataRow row, string date)
        {
            if (!String.IsNullOrWhiteSpace(row[date].ToString()))
            {
                try
                {
                    return DateTime.Parse(row[date].ToString());
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return null;
        }


    }

}
