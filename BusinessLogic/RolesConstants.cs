using System.ComponentModel;

namespace BusinessLogic
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
