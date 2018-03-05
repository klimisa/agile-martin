using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agile.DoorTimer
{
    public class Timer
    {
        public void Register(int timeout, int timeoutId, ITimerClient client)
        {
            client.Timeout(timeoutId);
        }
    }
}
