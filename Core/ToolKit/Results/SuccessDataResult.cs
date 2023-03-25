using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ToolKit.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, int resultCount, string message) : base(data, resultCount, true, message)
        {

        }
        public SuccessDataResult(T data, string message) : base(data, 1, true, message)
        {

        }
        public SuccessDataResult(T data, int resultCount) : base(data, resultCount, true, ResultMessages.OperationSuccess)
        {

        }
        public SuccessDataResult(T data) : base(data, 1, true, ResultMessages.OperationSuccess)
        {

        }
        public SuccessDataResult() : base(default, 1, true, ResultMessages.OperationSuccess)
        {

        }
        public SuccessDataResult(string message) : base(default, 1, true, message)
        {

        }
        public SuccessDataResult(int resultCount) : base(default, resultCount, true, ResultMessages.OperationSuccess)
        {

        }
    }
}
