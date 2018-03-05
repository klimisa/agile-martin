namespace agile.DoorTimer
{
    public interface ITimerClient
    {
        void Timeout(int timeoutId);
    }
}