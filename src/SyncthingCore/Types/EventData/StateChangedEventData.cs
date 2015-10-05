namespace SyncthingCore.Types.EventData
{
    public class StateChangedEventData : IEventData
    {
        public float Duration { get; set; }
        public string Folder { get; set; }
        public string FromState { get; set; }
        public string ToState { get; set; }
    }
}