using System;

namespace Model.ViewModel
{
    public class UserModel
    {
        public UserModel()
        {
            CreatedAt = DateTime.UtcNow;
        }
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }

        public DateTime CreatedAt { get; set; }
    }

    public class UserItem : UserModel
    {
    }

    public class UserDetail : UserItem
    {

    }
}
