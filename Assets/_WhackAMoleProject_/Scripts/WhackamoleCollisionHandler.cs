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

        DebugManager.Instance.AddDebugMessage("Träffad!");
        gameObject.SetActive(false);
        /*if (collision.gameObject.CompareTag("Hammer"))
        {
            eventManager.TriggerHitMoleEvent();
            gameObject.SetActive(false);
        }
        */
    }
}
