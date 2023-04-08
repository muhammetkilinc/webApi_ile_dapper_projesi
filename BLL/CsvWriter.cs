using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static BLL.CsvFile;

namespace BLL
{
    public class CsvWriterFile
    {
        public string GuidCreate()=>
            Guid.NewGuid().ToString();
        public string GuidCreateAddCsvFile() =>
           Guid.NewGuid().ToString()+".csv";

        public byte[] WriteCsvFileByte<T>(IEnumerable<T> objects)
        {
            StringBuilder sb = new StringBuilder();
            var objs = objects as IList<T> ?? objects.ToList();
            sb.AppendLine(ToCsvHeader(objs.First()));
            foreach (var obj in objs)
            {
                sb.AppendLine(ToCsv(obj));
            }
           
            Encoding iso = Encoding.GetEncoding("ISO-8859-1");
            Encoding utf8 = Encoding.UTF8;
            byte[] utfBytes = utf8.GetBytes(sb.ToString());
            return Encoding.Convert(utf8, iso, utfBytes);
        }
        public StringBuilder WriteCsvFileStringBuilder<T>(IEnumerable<T> objects)
        {
            StringBuilder sb = new StringBuilder();
            var objs = objects as IList<T> ?? objects.ToList();
            sb.AppendLine(ToCsvHeader(objs.First()));
            foreach (var obj in objs)
            {
                sb.AppendLine(ToCsv(obj));
            }
            return sb;
        }
        private string ReplaceText(string input)
        {
            input = input
                .Replace('ı', 'i')
                .Replace('ş', 's')
                .Replace('İ', 'I')
                .Replace('Ç', 'C')
                .Replace('Ö', 'O')
                .Replace('Ş', 'S')
                .Replace('Ü', 'U')
                .Replace('Ğ', 'G')
                .Trim();
          
            return input;
        }
        public FilePathReturnDto WriteCsv<T>(IEnumerable<T> objects)
        {
            var objs = objects as IList<T> ?? objects.ToList();
            var guid = Guid.NewGuid().ToString();
            string pathUrl = Path.Combine("StaticFiles", guid + ".csv");
            if (objs.Any())
            {
                using (var sw = new StreamWriter(pathUrl))
                {
                    sw.WriteLine(ToCsvHeader(objs.First()));
                    foreach (var obj in objs)
                    {
                        sw.WriteLine(ToCsv(obj));
                    }
                }
            }
            return new FilePathReturnDto()
            {
                Path = "/StaticFiles/" + guid + ".csv"
            };
        }

        public string ToCsv<T>(T t)
        {
            var propValues = new List<string>();
            foreach (var propertyInfo in t.GetType().GetProperties())
            {
                var propertyName = propertyInfo.Name;
                var propertyValue = propertyInfo.GetValue(t, null);
                if (propertyValue != null)
                {
                    propValues.Add(ReplaceText(propertyValue.ToString()));
                }
                else
                {
                    propValues.Add("");
                }
            }
            return string.Join(";", propValues);
        }
        public string ToCsvHeader<T>(T t)
        {
            var propNames = new List<string>();
            foreach (var propertyInfo in t.GetType().GetProperties())
            {
                var propertyName = propertyInfo.Name;
                var propertyValue = propertyInfo.GetValue(t, null);
                if (propertyName != null)
                {
                    propNames.Add(propertyName.ToString());
                }
                else
                {
                    propNames.Add("");
                }
            }
            return string.Join(";", propNames);
        }
    }
}
