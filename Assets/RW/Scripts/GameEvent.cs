using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Game Event", menuName = "Game Event", order = 52)] // 1
public class GameEvent : ScriptableObject   //2
{
    private List<GameEventListener> listeners = new List<GameEventListener>();

    public void Raise() // 4
    {
        for (int i = listeners.Count - 1; i >= 0; i--)  // 5
        {
            listeners[i].OnEventRaised();   // 6
        }
    }

    public void RegsterListener(GameEventListener listener) // 7
    {
        listener.Add(listener);
    }

    public void UnregisterListener(GameEventListener listener)  // 8
    {
        listener.Remove(listener);
    }
}
