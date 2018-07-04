using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.ActionResult
{
    public abstract class FormActionResult
    {
        public int ActionCode { get; set; }
        public object ActionResult { get; set; }

    }
}
