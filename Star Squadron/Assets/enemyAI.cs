using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float rotationSpeed = 10f;
    [SerializeField]
    private float speed = 0.5f;
    [SerializeField]
    private float handlingPenalty = 3f;
    [SerializeField]
    private float followDistance = 4f;

    private float distanceTraveled = 0f;
    private

    // Start is called before the first frame update
    void Start()
    {

    }

    void LateUpdate() {
        if (Vector3.Distance(target.position, transform.position) > followDistance) {

            Vector3 lookRotation = target.position - transform.position;
            float angleToTarget = Mathf.Abs(Vector3.Angle(transform.forward, lookRotation));

            float speedToUse = speed;
            float rotationSpeedToUse = rotationSpeed;

            float remappedPenalty = angleToTarget.Remap(0f, 180f, 1, handlingPenalty);
            speedToUse = speed/remappedPenalty;
            rotationSpeedToUse = rotationSpeed/remappedPenalty;

            // TRAVEL.
            // Distance moved equals elapsed time times speed..
            float distCovered = Time.deltaTime * speedToUse;

            // Fraction of journey completed equals current distance divided by total distance.
            float fractionOfJourney = distCovered / Vector3.Distance(transform.position, target.position);

            // Set our position as a fraction of the distance between the markers.
            transform.position = Vector3.Lerp(transform.position, target.position, fractionOfJourney);


            // ROTATION.
            
            if (lookRotation != Vector3.zero) {
                Quaternion targetRotation = Quaternion.LookRotation(lookRotation);
                float str = Mathf.Min (rotationSpeedToUse * Time.deltaTime, 1);
                transform.rotation = Quaternion.Lerp (transform.rotation, targetRotation, str);
            }
        }
    }
}
