﻿using System.Collections.Generic;
using UnityEngine;

namespace ScriptableEvents
{
    public class GameEvent<T> : ScriptableObject
    {
        private List<IGameEventListener<T>> listeners = new List<IGameEventListener<T>>();

        public void Raise(T item)
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised(item);
            }
        }

        public void RegisterListener(IGameEventListener<T> listener)
        {
            listeners.Add(listener);
        }

        public void UnregisterListener(IGameEventListener<T> listener)
        {
            listeners.Remove(listener);
        }
    }
}