using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Event Manager", menuName = "Wackamole/EventManager")]
public class WhackamoleEventManager : ScriptableObject
{
    public event Action OnHitMole;

    public event Action OnStartGame;

    public void TriggerHitMoleEvent()
    {
        OnHitMole?.Invoke();
    }

    public void TriggerGameStart()
    {
        OnStartGame?.Invoke();
    }
}
