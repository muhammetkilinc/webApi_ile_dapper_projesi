using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ToolKit.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //bize gelen veya gelmeyen veri tiplerini belirleme
        public ErrorDataResult(T data, string message) : base(data, 0, false, message)
        {

        }
        public ErrorDataResult(T data) : base(data, 0, false, ResultMessages.OperationUnSuccess)
        {

        }

        //null default olarak temsil edilir.
        public ErrorDataResult(string message) : base(default, 0, false, message)
        {

        }
        public ErrorDataResult() : base(default, 0, false, ResultMessages.OperationUnSuccess)
        {

        }
    }
}
