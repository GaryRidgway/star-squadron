using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squadSlotFollower : MonoBehaviour
{
    [SerializeField]
    private Transform SlotTransform;
    [SerializeField]
    private Transform MainShiptransform;
    [SerializeField]
    private Transform TravelTo;
    [SerializeField]
    private bool Travel = false;
    [SerializeField]
    private float PositionLerpSpeed = 5f;
    [SerializeField]
    private float RotationLerpSpeed = 1f;

    void FixedUpdate() {
        if (!Travel) {
            float dist = Vector3.Distance(transform.position, SlotTransform.position);
            transform.position = Vector3.Lerp(transform.position, SlotTransform.position, Time.deltaTime * PositionLerpSpeed * dist);
        }
        else if (Travel) {
            float dist = Vector3.Distance(transform.position, TravelTo.position);
            transform.position = Vector3.Lerp(transform.position, TravelTo.position, Time.deltaTime * PositionLerpSpeed * dist);
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, MainShiptransform.rotation, Time.deltaTime * RotationLerpSpeed);
    }
}
