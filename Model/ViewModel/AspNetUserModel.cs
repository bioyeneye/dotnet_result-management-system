using System;
using System.Collections.Generic;
using DataAccess.EF;

namespace Model.ViewModel
{
    public class AspNetUserModel
    {
        public AspNetUserModel()
        {
            CreatedAt = DateTime.UtcNow;
        }

        public string Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string UserName { get; set; }

        public DateTime CreatedAt { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }
        public string MatricNumber { get; set; }

    }

    public class AspNetUserItem : AspNetUserModel
    {
        public List<ResultModel> Results { get; set; }
    }

    public class AspNetUserDetail : AspNetUserItem
    {

    }

    public class StudentTemplateDownloadModel
    {
        public string Surname { get; set; }
        public string OtherName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string MatricNumber { get; set; }
    }
}
