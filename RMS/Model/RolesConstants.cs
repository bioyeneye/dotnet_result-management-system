using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Model
{
    public class RolesConstants
    {
        public enum Enum
        {
            [Description("Super Administrator")] SuperAdmin = 1,
            [Description("Administrator")] Admin,
            [Description("Student")] Student
        }
    }

}
