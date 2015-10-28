using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LexiconUniversity.Models {
    public class Enrollment {
        public Grade Grade { get; set; }
    }

    public enum Grade {
        A, B, C, D, E, F
    }
}