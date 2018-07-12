using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.View.Reporting.Report
{
    public class StudentSemesterResultModel
    {
        public List<StudentSemesterCourse> StudentSemesterCourses { get; set; }
        public string StudentName { get; set; }
        public string MatricNumber { get; set; }
        public string Session { get; set; }
        public string Semester { get; set; }
        public string Level { get; set; }
        public string SemesterTotalUnits { get; set; }
        public string SemesterTotalPoint { get; set; }
        public string SemesterGPA { get; set; }
        public string CumulativeTotalPoints { get; set; }
        public string CumulativeTotalUnits { get; set; }
        public string CumulativeGPA { get; set; }
    }

    public class StudentSemesterCourse
    {
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public int Unit { get; set; }
        public int Score { get; set; }

        private char _grade;
        public char Grade
        {
            get => _grade;
            set
            {
                _grade = value;
                _grade = ProcessGrade(Score);
            }
        }

        private char ProcessGrade(int score)
        {
            char grade = 'F';
            if (score > 70 && score <= 100)
            {
                grade = 'A';
            }else if (score > 59 && score < 70)
            {
                grade = 'B';
            }
            else if (score > 49 && score < 60)
            {
                grade = 'C';
            }
            else if (score > 44 && score < 50)
            {
                grade = 'D';
            }
            else if (score > 40 && score < 45)
            {
                grade = 'E';
            }
            else
            {
                grade = 'F';
            }

            return grade;
        }
    }
}
