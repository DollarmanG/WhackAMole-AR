using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Event Manager", menuName = "Wackamole/EventManager")]
public class WhackamoleEventManager : ScriptableObject
{
    public event Action OnHitMole;

    public void TriggerHitMoleEvent()
    {
        OnHitMole?.Invoke();
    }
}
