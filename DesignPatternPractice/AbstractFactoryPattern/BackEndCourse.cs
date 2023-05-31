using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class BackEndCourse : ICourse
    {
        public string GetCourseDuration()
        {
            return "4 months";
        }

        public int getCourseFee()
        {
            return 20000;
        }

        public string getCourseName()
        {
            return "C#, Java, Python";
        }
    }
}
