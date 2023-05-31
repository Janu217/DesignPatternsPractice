using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class OnlineSource : Isource
    {
        public string getSourceName()
        {
            return "Online Source";
        }
    }
}
