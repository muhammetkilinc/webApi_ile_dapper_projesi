using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BLL
{
    public static class CsvFile
    {
        public static List<string> Files()
        {
            var files = Directory.GetFiles(Path.Combine("StaticFiles"), "*.*", SearchOption.AllDirectories);
            List<string> result = new List<string>();
            foreach (var file in files)
            {
                var dateTime = File.GetCreationTime(file);
                if (dateTime < DateTime.Now.AddHours(-4))
                {
                    result.Add(file);
                }
            }
            return result;
        }
        public static bool Delete(List<string> deleteList)
        {
            foreach (var file in deleteList)
            {
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
            }
            return true;
        }
        public class FilePathReturnDto
        {
            public string? Path { get; set; }
        }
    }
}
