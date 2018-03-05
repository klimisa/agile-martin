using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agile.DoorTimer
{
    public class DoorTimerAdapter: ITimerClient
    {
        private readonly ITimedDoor _timedDoor;

        public DoorTimerAdapter(ITimedDoor timedDoor)
        {
            _timedDoor = timedDoor;
        }

        public void Timeout(int timeoutId)
        {
            _timedDoor.DoorTimeOut(timeoutId);
        }
    }
}
