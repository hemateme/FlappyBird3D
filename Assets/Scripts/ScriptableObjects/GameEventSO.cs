using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameEventSO", menuName = "ScriptableObjects/GameEventSO")]
public class GameEventSo : ScriptableObject
{
   private readonly List<GameEventListener> _listeners = new List<GameEventListener>();

    public void Raise()
    {
        Debug.Log("Raise");
        foreach (var listener in _listeners)
        {
            listener.OnEventRaised();
        }
    }

    public void RegisterListener(GameEventListener listener) => _listeners.Add(listener);
    public void UnregisterListener(GameEventListener listener) => _listeners.Remove(listener);
    
    [ContextMenu("Raise GameEvent")]
    public void RaiseGameEvent() => Raise();

}
