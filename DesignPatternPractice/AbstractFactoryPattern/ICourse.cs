using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public interface ICourse
    {
        string getCourseName();
        int getCourseFee();
        string GetCourseDuration();
    }
}
