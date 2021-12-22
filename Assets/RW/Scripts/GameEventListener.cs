using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;   // 1

public class GameEventListener : MonoBehaviour
{
    [SerializeField]
    private GameEvent gameEvent;    // 2
    [SerializeField]
    private UnityEvent response;    // 3
    
    private void OnEnable() // 4
    {
        gameEvent.RegsterListener(this);
    }

    private void OnDisable()    // 5
    {
        gameEvent.UnregisterListener(this);
    }

    public void OnEventRaised() // 6
    {
        response.Invoke();
    }

    public void Add(GameEventListener listener)
    {

    }

    public void Remove(GameEventListener listener)
    {

    }
}
