using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Erros
{
    public class ApiValidationErrorResponnse : ApiResponse
    {
        public ApiValidationErrorResponnse() : base(400)
        {
        }
        public IEnumerable<string> Errors { get; set; }
    }
}