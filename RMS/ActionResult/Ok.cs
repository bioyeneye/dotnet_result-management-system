using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.ActionResult
{
    public sealed class OkCollection<T> : FormActionResult
    {
        public OkCollection(List<T> actionResult)
        {
            ActionCode = 200;
            ActionResult = actionResult;
        }
    }
}
