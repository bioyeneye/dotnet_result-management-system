using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.ActionResult
{
    class BadRequest<T> : FormActionResult
    {
        public BadRequest(T actionResult, int actionCode)
        {
            ActionCode = actionCode;
            ActionResult = actionResult;
        }
    }
}
