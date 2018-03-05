namespace agile.DoorTimer
{
    public interface IDoor
    {
        void Lock();
        void Unlock();
        bool IsDoorOpen();
    }
}