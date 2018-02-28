using System;

namespace Model.ViewModel
{
    public class SemeterModel
    {
        public SemeterModel()
        {
            CreatedAt = DateTime.UtcNow;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class SemeterItem : SemeterModel
    {

    }

    public class SemeterDetail : SemeterItem
    {

    }
}
