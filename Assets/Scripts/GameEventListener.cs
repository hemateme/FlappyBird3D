using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    public GameEventSo gameEvent;
    public UnityEvent Response;

    public void OnEnable() => gameEvent.RegisterListener(this);
    public void OnDisable() => gameEvent.UnregisterListener(this);
    
    public void OnEventRaised() => Response.Invoke();
}
