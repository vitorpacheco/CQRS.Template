using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Template.Application.ResponseModels
{
    public class ErrorResponseModel
    {
        public string Type { get; set; }

        public string Message { get; set; }

        public string StackTrace { get; set; }

        public ErrorResponseModel(Exception ex)
        {
            Type = ex.GetType().Name;
            Message = ex.Message;
            StackTrace = ex.ToString();
        }
    }
}
