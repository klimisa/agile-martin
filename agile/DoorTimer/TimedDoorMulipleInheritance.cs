using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agile.DoorTimer
{
    public class TimedDoorMulipleInheritance: IDoor, ITimerClient
    {
        private readonly Timer _timer = new Timer();

        public void Lock()
        {
            throw new NotImplementedException();
        }

        public void Unlock()
        {
            throw new NotImplementedException();
        }

        public bool IsDoorOpen()
        {
            if (true)
            {
                _timer.Register(1, 1, this);
            }
            throw new NotImplementedException();
        }

        public void Timeout(int timeoutId)
        {
            throw new NotImplementedException();
        }
    }
}
