using System;
using System.Collections.Generic;

namespace Model.ViewModel
{
    public class SectionModel
    {
        public SectionModel()
        {
            CreatedAt = DateTime.UtcNow;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }
    }

    public class SectionItem : SectionModel
    {

    }

    public class SectionDetail : SectionItem
    {

    }
}
