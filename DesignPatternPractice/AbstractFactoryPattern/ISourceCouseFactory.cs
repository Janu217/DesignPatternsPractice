using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
   public interface ISourceCouseFactory
    {
        Isource GetIsource();
        ICourse GetCourse();
    }
}
