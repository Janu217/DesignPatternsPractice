using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class OfflineSource : Isource
    {
        public string getSourceName()
        {
            return "Offline Source";
        }
    }
}
