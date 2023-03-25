using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core.ToolKit.Results
{
    public class Result : IResult
    {
        public Result(bool success)
        {
            IsSuccess = success;
        }

        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }



        //kullanıcı tarafından gözükmemesi için;
        [JsonIgnore]
        public bool IsSuccess { get; }
        public string Message { get; }
        public Error Error 
        { 
            get
            {
                if (!IsSuccess)
                {
                    return new Error
                    {
                        Message = Message
                    };
                }
                return null;
            }
        }
    }
}
