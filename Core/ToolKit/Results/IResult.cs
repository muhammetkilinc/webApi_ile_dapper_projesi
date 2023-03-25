using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core.ToolKit.Results
{
    public interface IResult
    {
        string Message { get; }

        //kullanıcı tarafından gözükmemesi için;
        [JsonIgnore]
        bool IsSuccess { get; }
        Error Error { get; }
    }
}
