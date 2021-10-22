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
    [SerializeField]
    private float sensorDistance = 40f;
    [SerializeField]
    private float fireDistance = 60f;
    [SerializeField]
    private List<weapon> weapons;

    private float distanceTraveled = 0f;
    private float lastDisance = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = new Color(255, 255, 255, 0.2f);
        Gizmos.DrawSphere(transform.position, sensorDistance);
    }

    void LateUpdate() {
        float distanceToTarget = Vector3.Distance(target.position, transform.position);
        if (distanceToTarget > followDistance) {

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

        if (distanceToTarget <= fireDistance) {
            ExtensionMethods.setFireWeapons(weapons, true);
        }
        else if (distanceToTarget > fireDistance) {
            ExtensionMethods.setFireWeapons(weapons, false);
        }


        // Do this last.
        lastDisance = distanceToTarget;
    }
}
