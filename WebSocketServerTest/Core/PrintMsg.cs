using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSocketServerTest.Core
{
    public static class PrintMsg
    {
        public static event Action<string> Send;
        public static void SendMsg(string msg)
        {
            Send(msg);
        }
    }
}
