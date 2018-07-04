using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.ViewModel
{
    public class LevelModel
    {
        public LevelModel()
        {
            CreatedAt = DateTime.UtcNow;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }


    }

    public class LevelItem : LevelModel
    {
        public List<SectionModel> SectionModels { get; set; }

    }

    public class LevelDetail : LevelItem
    {

    }
}
