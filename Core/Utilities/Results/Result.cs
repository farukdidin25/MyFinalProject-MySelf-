using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //overloading

        public Result(bool success, string message):this(success)
        {
            success = success;
        }
        public Result(bool success)
        {
            success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
