using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public bool IsActive { get; set; }

        public int LevelId { get; set; }
    }

    public class SectionItem : SectionModel
    {
        public string LevelName { get; set; }
    }

    public class SectionDetail : SectionItem
    {

    }
}
