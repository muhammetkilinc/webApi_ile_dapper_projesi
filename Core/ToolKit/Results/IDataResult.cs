using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ToolKit.Results
{
    public interface IDataResult<out T> : IResult
    {
        // T -> listeyi/tabloyu temsil edet
        T ResultObject { get; }
        int ResultCount { get; }
    }
}
