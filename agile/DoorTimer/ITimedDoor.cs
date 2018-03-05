namespace agile.DoorTimer
{
    public interface ITimedDoor: IDoor
    {
        void DoorTimeOut(int timoutId);
    }
}