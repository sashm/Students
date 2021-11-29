using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Students.Models
{
    public class DisplayTable
    {
        public string Photo { get; set; }

        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string CountryOfBirth { get; set; }

        public string Gender { get; set; }

        public string Grade { get; set; }

        public string QuestionnaireStatus { get; set; }

        public string PersonalPlanStatus { get; set; }        

        public string StudentStatus { get; set; }

        public string StudentType { get; set; }

        public int OldStudentId { get; set; }

    }
}