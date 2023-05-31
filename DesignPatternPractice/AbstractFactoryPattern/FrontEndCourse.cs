using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class FrontEndCourse : ICourse
    {
        public string GetCourseDuration()
        {
            return "3 months";
        }

        public int getCourseFee()
        {
            return 6000;
        }

        public string getCourseName()
        {
            return "HTML, CSS, Javascript";
        }
    }
}
