using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class OfflineSourceBackEndCourse : ISourceCouseFactory
    {
        public ICourse GetCourse()
        {
            return new BackEndCourse();
        }

        public Isource GetIsource()
        {
            return new OfflineSource();
        }
    }
}
