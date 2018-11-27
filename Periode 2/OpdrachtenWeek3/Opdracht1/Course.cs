using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    class Course
    {
        public string Name;
        public int Grade;
        public PracticalGrade pGrade;

    }
    public enum PracticalGrade
    {
        None, Absent, Insufficient, Sufficient, Good
    }
}
