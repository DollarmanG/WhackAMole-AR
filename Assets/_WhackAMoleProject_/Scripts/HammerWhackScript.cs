using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AugmentedRealityCourse;
public class HammerWhackScript : MonoBehaviour
{
    [SerializeField] WhackamoleEventManager whackamoleEventManager;

    [SerializeField] private Animator hammerAnimator;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                gameObject.transform.position = hitInfo.point + new Vector3(0, 0, -0.2f);
                hammerAnimator.SetTrigger("HammerTrigger");
                DebugManager.Instance.AddDebugMessage(hitInfo.point.ToString());
            }
        }

    }
}
