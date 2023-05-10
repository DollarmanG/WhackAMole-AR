using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerWhackScript : MonoBehaviour
{

    [SerializeField] private Camera camera;

    [SerializeField] WhackamoleEventManager whackamoleEventManager;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hitInfo))
        {
            gameObject.transform.position = hitInfo.point;
        }
    }
}
