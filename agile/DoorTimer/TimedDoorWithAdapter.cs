using System;

namespace agile.DoorTimer
{
    public class TimedDoorWithAdapter : ITimedDoor
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
                _timer.Register(1,1, new DoorTimerAdapter(this));
            }
            throw new NotImplementedException();
        }

        public void DoorTimeOut(int timoutId)
        {
            throw new NotImplementedException();
        }
    }
}