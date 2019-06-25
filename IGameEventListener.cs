namespace ScriptableEvents
{
    public interface IGameEventListener<T>
    {
        void OnEventRaised(T item);
    }
}