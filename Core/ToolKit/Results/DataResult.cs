using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ToolKit.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        //overload
        public DataResult(T data, int resultCount, bool success, string message) : base(success, message)
        {
            ResultObject = data;
            ResultCount = Message==ResultMessages.NoRecordsFound ? 0 : resultCount;
        }

        public DataResult(T data, int resultCount, bool success) : base(success)
        {
            ResultObject = data;
            ResultCount = Message == ResultMessages.NoRecordsFound ? 0 : resultCount;
        }

        public T ResultObject { get; }
        public int ResultCount { get; }
    }
}
