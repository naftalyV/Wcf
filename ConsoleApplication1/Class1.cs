using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using Wcf;

namespace ConsoleApplication1
{
    class Class1
    {
        ServiceHost Host;
        public Class1()
        {
            Host = new ServiceHost(typeof(Calc));
        }

        public void Open()
        {
            if (Host.State != CommunicationState.Opened )
            {
                Host.Open();
            }
        }
        public void Close()
        {
            if (Host.State == CommunicationState.Opened)
            {
                Host.Close();
            }
        }
    }
}
