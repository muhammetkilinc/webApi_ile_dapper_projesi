using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ToolKit.Results
{
    public class ErrorResult : Result
    {
        //Result içerisindeki constructor'lara karşılık gelen komutlar.
        public ErrorResult() : base(false, ResultMessages.OperationUnSuccess)
        {

        }
        public ErrorResult(string message) : base(false, message)
        {

        }
    }
}
