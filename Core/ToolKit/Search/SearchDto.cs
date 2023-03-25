using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ToolKit.Search
{
    public class SearchDto
    {
        //Dto -> Data Transfer Object

        public int StartIndex { get; set; }
        public int MaxCount { get; set; }
        public OrderByDto? OrderBy { get; set; }
    }

    public class OrderByDto
    {
        public string Name { get; set; } //A-Z
        public string Type { get; set; } //Desc
    }
}
