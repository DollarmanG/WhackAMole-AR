using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using AugmentedRealityCourse;

public class WhackamoleCollisionHandler : MonoBehaviour
{
    [SerializeField] private WhackamoleEventManager eventManager;

    void OnCollisionEnter(Collision collision)
    {
        //eventManager.TriggerHitMoleEvent();
        Debug.Log("Träffad");
        DebugManager.Instance.AddDebugMessage("Träffad!");
        eventManager.TriggerHitMoleEvent();
        gameObject.SetActive(false);
    }
}
