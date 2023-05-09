using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARTapToPlace : MonoBehaviour
{
    [SerializeField]
    private ARRaycastManager raycastManager;

    [SerializeField]
    private GameObject objectToPlace;

    private List<ARRaycastHit> hitResults = new List<ARRaycastHit>();

    private GameObject spawnedObject;

    private bool IsPlaced = false;
    bool TryGetTouchPos(out Vector2 touchPos)
    {

        if (Input.touchCount > 0)
        {

            touchPos = Input.GetTouch(0).position;
            return true;
        }

        touchPos = default;

        return false;

    }

    void Update()
    {
        if (!TryGetTouchPos(out Vector2 touchPos))
        {
            return;
        }

        if (raycastManager.Raycast(touchPos, hitResults, TrackableType.Planes))
        {
            Pose hitPose = hitResults[0].pose;
            if (!IsPlaced)
            {
                objectToPlace.SetActive(true);
                objectToPlace.transform.position = hitPose.position;
                objectToPlace.transform.rotation = hitPose.rotation;
                IsPlaced = true;
            }
        }

    }
}