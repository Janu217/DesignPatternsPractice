using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class OnlineSourceFrondEndCourseFactory : ISourceCouseFactory
    {
        public ICourse GetCourse()
        {
            return new FrontEndCourse();
        }

        public Isource GetIsource()
        {
            return new OnlineSource();
        }
    }
}
