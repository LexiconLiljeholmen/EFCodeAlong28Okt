using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LexiconUniversity.Models {
    public class Student {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string FullName {
            get {
                var fullName = FirstName + " " + LastName;
                fullName.Trim();
                return fullName;
            }
        }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}