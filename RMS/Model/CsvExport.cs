using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Model
{
    public class SkipAttribute : Attribute
    {

    }
    public class CsvExport<T> where T : class
    {
        private readonly IList<int> _columns;
        private readonly IList<T> _objects;

        public CsvExport(IList<int> columns, IList<T> objects)
        {
            _columns = columns;
            _objects = objects;
        }

        public string Export()
        {
            return Export(true);
        }
        public static IEnumerable<NameAndIndex> GetReportColumns()
        {
            IList<PropertyInfo> propertyInfos = typeof(T).GetProperties();
            for (int i = 0; i < propertyInfos.Count; i++)
            {
                var propertyInfo = propertyInfos[i];

                var skip = propertyInfo.GetCustomAttributes(typeof(SkipAttribute),
                     false).Cast<SkipAttribute>().SingleOrDefault();
                if (skip != null)
                    continue;

                var display = propertyInfo.GetCustomAttributes(typeof(DisplayNameAttribute),
                    false).Cast<DisplayNameAttribute>().SingleOrDefault();
                if (display != null)
                {
                    yield return new NameAndIndex()
                    {
                        Name = display.DisplayName,
                        Id = i
                    };
                }

                else
                    yield return new NameAndIndex()
                    {
                        Name = propertyInfo.Name,
                        Id = i
                    };
            }
        }
        public string Export(bool includeHeaderLine)
        {
            StringBuilder sb = new StringBuilder();
            //Get properties using reflection.
            IList<PropertyInfo> propertyInfos = typeof(T).GetProperties();

            if (includeHeaderLine)
            {
                for (int i = 0; i < propertyInfos.Count; i++)
                {
                    if (!_columns.Contains(i))
                        continue;

                    var propertyInfo = propertyInfos[i];

                    var skip = propertyInfo.GetCustomAttributes(typeof(SkipAttribute),
                       false).Cast<SkipAttribute>().SingleOrDefault();
                    if (skip != null)
                        continue;

                    var display = propertyInfo.GetCustomAttributes(typeof(DisplayNameAttribute),
                        false).Cast<DisplayNameAttribute>().SingleOrDefault();
                    if (display != null)
                    {
                        sb.Append(display.DisplayName).Append(",");
                    }

                    else
                        sb.Append(propertyInfo.Name).Append(",");
                }
                sb.Remove(sb.Length - 1, 1).AppendLine();
            }

            //add value for each property.
            foreach (T obj in _objects)
            {
                for (int i = 0; i < propertyInfos.Count; i++)
                {
                    if (!_columns.Contains(i))
                        continue;
                    var propertyInfo = propertyInfos[i];

                    var skip = propertyInfo.GetCustomAttributes(typeof(SkipAttribute),
                      false).Cast<SkipAttribute>().SingleOrDefault();
                    if (skip != null)
                        continue;

                    sb.Append(MakeValueCsvFriendly(propertyInfo.GetValue(obj, null))).Append(",");
                }

                sb.Remove(sb.Length - 1, 1).AppendLine();
            }

            return sb.ToString();
        }

        //export to a file.
        public void ExportToFile(string path)
        {
            File.WriteAllText(path, Export());
        }

        //export as binary data.
        public byte[] ExportToBytes()
        {
            return Encoding.UTF8.GetBytes(Export());
        }

        //get the csv value for field.
        private string MakeValueCsvFriendly(object value)
        {
            if (value == null) return "";
            if (value is Nullable && ((INullable)value).IsNull) return "";

            if (value is DateTime)
            {
                if (((DateTime)value).TimeOfDay.TotalSeconds == 0)
                    return ((DateTime)value).ToString("dd-MM-yyyy");
                return ((DateTime)value).ToString("dd-MM-yyyy HH:mm:ss");
            }
            string output = value.ToString();

            if (output.Contains(",") || output.Contains("\""))
                output = '"' + output.Replace("\"", "\"\"") + '"';

            return output;

        }
    }
}
