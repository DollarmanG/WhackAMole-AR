using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class GameManagerController : MonoBehaviour
{
    [SerializeField] private WhackamoleEventManager eventManager;

    [SerializeField] private TMP_Text score;

    private int currentScore = 0;

    void OnEnable()
    {
        eventManager.OnHitMole += EventManager_OnHitMole;
    }

    void OnDisable()
    {
        eventManager.OnHitMole -= EventManager_OnHitMole;
    }

    private void EventManager_OnHitMole()
    {
        currentScore += 100;
        score.text = currentScore.ToString();
    }
}
