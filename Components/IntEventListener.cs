namespace ScriptableEvents
{
    public class IntEventListener : GameEventListener<int, IntGameEvent, IntUnityEvent>
    {
        public override void OnEventRaised(int item)
        {
            base.OnEventRaised(item);
        }
    }
}
