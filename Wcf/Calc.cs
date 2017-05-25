using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calc" in both code and config file together.
    public class Calc : Icalc
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

       

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
