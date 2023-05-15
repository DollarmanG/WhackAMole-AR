using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AugmentedRealityCourse;
using Unity.VisualScripting;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;

using refToTouch = UnityEngine.InputSystem.EnhancedTouch;
public class HammerWhackScript : MonoBehaviour
{
    [SerializeField] WhackamoleEventManager whackamoleEventManager;

    [SerializeField] private Animator hammerAnimator;

    [SerializeField] private LayerMask layerMask;



    private bool IsGameRunning;

    void Awake()
    {
        EnhancedTouchSupport.Enable();
    }

    void OnEnable()
    {
        whackamoleEventManager.OnStartGame += WhackamoleEventManager_OnStartGame;
        refToTouch.Touch.onFingerDown += Touch_onFingerDown;
    }

    void OnDisable()
    {
        whackamoleEventManager.OnStartGame -= WhackamoleEventManager_OnStartGame;
        refToTouch.Touch.onFingerDown -= Touch_onFingerDown;
    }

    private void Touch_onFingerDown(Finger obj)
    {
        if (Input.touchCount > 0 && IsGameRunning)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hitInfo, 10f, layerMask))
            {
                gameObject.transform.parent.position = hitInfo.point + new Vector3(0, 0, -0.2f);
                hammerAnimator.SetTrigger("HammerTrigger");
                DebugManager.Instance.AddDebugMessage(hitInfo.point.ToString());
            }
        }
    }

    private void WhackamoleEventManager_OnStartGame()
    {
        if (IsGameRunning == false)
        {
            IsGameRunning = true;
        }
    }
}
