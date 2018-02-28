using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.ViewModel
{
    public class StudentModel
    {
        public StudentModel()
        {
            CreatedAt = DateTime.UtcNow;

        }

        public int Id { get; set; }

        public int SectionId { get; set; }

        public int LevelId { get; set; }

        public string MatricNumber { get; set; }

        public string Surname { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedAt { get; set; }
    }

    public class StudentItem : StudentModel
    {
        public string RegisteredSection { get; set; }
    }

    public class StudentDetail : StudentItem
    {

    }
}
